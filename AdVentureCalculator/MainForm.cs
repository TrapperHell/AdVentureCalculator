using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AdVentureCalculator.Controller;
using AdVentureCalculator.Model;

namespace AdVentureCalculator
{
    public partial class MainForm : Form
    {
        #region Fields, Properties & Constructor(s)

        double _totalProfitPerSecond = 0;
        bool _allCashUpgradesBought = false, _allAngelUpgradesBought = false;

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion Fields, Properties & Constructor(s)



        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text += " v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            #region Data Bindings

            // Set the Businesses Combobox
            cmbCBusiness.DataSource = BusinessController.Businesses;
            cmbCBusiness.DisplayMember = "Name";

            cmbCToEarnValueType.DataSource = Enum.GetValues(typeof(MonetaryValueDisplay.MonetaryTypes));
            cmbAICurrentAIValueType.DataSource = Enum.GetValues(typeof(MonetaryValueDisplay.MonetaryTypes));
            cmbCDesiredAIValueType.DataSource = Enum.GetValues(typeof(MonetaryValueDisplay.MonetaryTypes));

            nudAICurrentAI.DataBindings.Add("Value", AngelInvestorController.AngelInvestors, "Amount", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbAICurrentAIValueType.DataBindings.Add("SelectedValue", AngelInvestorController.AngelInvestors, "Type", true, DataSourceUpdateMode.OnPropertyChanged);
            nudAIEffectiveness.DataBindings.Add("Value", AngelInvestorController.AngelInvestors, "Effectiveness", false, DataSourceUpdateMode.OnPropertyChanged);

            #endregion Data Bindings

            #region Drawing Stuff

            // Draw the list of Managers
            DrawManagers(ManagerController.Managers);
            DrawBusinesses(BusinessController.Businesses);

            // Draw the list of Upgrades
            DrawCashUpgrades(UpgradeController.CashUpgrades);
            DrawAngelUpgrades(UpgradeController.AngelUpgrades);

            #endregion Drawing Stuff
        }

        private void NumericUpDown_Enter(object sender, EventArgs e)
        {
            NumericUpDown nud = sender as NumericUpDown;

            if (nud != null)
                nud.Select(0, nud.Text.Length);
        }

        #region Businesses Tab

        /// <summary>
        /// Draws the supplied businesses and their information. If infoOnly is set to
        /// true, the Controls will not be redrawn, instead the InfoString
        /// PropertyChanged is invoked to refresh the information.
        /// </summary>
        /// <param name="businesses">
        /// A List of Businesses whose information is used to draw the businesses or show
        /// their information.
        /// </param>
        /// <param name="infoOnly">
        /// Determines whether the businesses will be drawn as controls, or have their
        /// information updated.
        /// </param>
        private void DrawBusinesses(List<Business> businesses, bool infoOnly = false)
        {
            if (businesses == null)
                return;

            this.SuspendLayout();

            if (!infoOnly)
            {
                for (int i = 0; i < businesses.Count; i++)
                {
                    Label lbl = new Label()
                    {
                        Location = new System.Drawing.Point(5, 8 + (23 * i)),
                        Name = "lbl" + businesses[i].Name.Replace(" ", String.Empty),
                        Size = new System.Drawing.Size(100, 18),
                        Text = businesses[i].Name + ":"
                    };

                    pnlBBusinesses.Controls.Add(lbl);

                    NumericUpDown nud = new NumericUpDown()
                    {
                        Location = new System.Drawing.Point(105, 5 + (23 * i)),
                        Maximum = businesses[i].MaxLevel,
                        Name = "nud" + businesses[i].Name.Replace(" ", String.Empty),
                        Size = new System.Drawing.Size(50, 23),
                        Tag = businesses[i],
                    };
                    nud.DataBindings.Add("Minimum", businesses[i], "FreeLevel", false, DataSourceUpdateMode.OnPropertyChanged);
                    nud.DataBindings.Add("Value", businesses[i], "TotalLevel", false, DataSourceUpdateMode.OnPropertyChanged);
                    nud.Enter += NumericUpDown_Enter;
                    nud.MouseClick += NumericUpDown_Enter;

                    pnlBBusinesses.Controls.Add(nud);

                    Label lblInfo = new Label()
                    {
                        Font = new System.Drawing.Font("Lucida Console", 7),
                        AutoSize = true,
                        Location = new System.Drawing.Point(175, 10 + (23 * i)),
                        Text = businesses[i].InfoString,
                    };
                    lblInfo.DataBindings.Add("Text", businesses[i], "InfoString");

                    pnlBBusinesses.Controls.Add(lblInfo);
                }
            }
            else
            {
                BusinessController.RefreshBusinessInfo();

                // Get the max MonetaryType value, and reduce it per business...
                MonetaryValueDisplay.MonetaryTypes minMonetaryType = Enum.GetValues(typeof(MonetaryValueDisplay.MonetaryTypes)).Cast<MonetaryValueDisplay.MonetaryTypes>().Last();

                BusinessController.Businesses.ForEach(b =>
                {
                    MonetaryValueDisplay.MonetaryTypes idealMonetaryType;
                    MonetaryValueDisplay.GetMonetaryValue(b.Profit.Value / b.Cooldown.Value, MonetaryValueDisplay.MonetaryTypes.Base, out idealMonetaryType);

                    if (idealMonetaryType < minMonetaryType)
                        minMonetaryType = idealMonetaryType;
                });

                chtBusinessProfits.Series[0].Points.Clear();
                for (int i = 0; i < BusinessController.Businesses.Count; i++)
                {
                    chtBusinessProfits.Series[0].Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint()
                    {
                        YValues = new double[] { MonetaryValueDisplay.GetMonetaryValue(businesses[i].Profit.Value / businesses[i].Cooldown.Value, MonetaryValueDisplay.MonetaryTypes.Base, minMonetaryType) },
                        Label = businesses[i].Type.ToString()
                    });
                }
            }

            // Total Profit Information calculations
            MonetaryValueDisplay.MonetaryTypes monetaryType;
            double totalProfit = BusinessController.Businesses.Select(b => b.Profit).Aggregate((a, b) => a + b);
            double totalProfitFormatted = MonetaryValueDisplay.GetMonetaryValue(totalProfit, MonetaryValueDisplay.MonetaryTypes.Base, out monetaryType);
            lblCEarnPerCycle.Text = String.Format(new DecimalTruncateFormatProvider(), "Earning {0:T(3)} {1} in one cycle.", totalProfitFormatted, EnumHelper.GetEnumDescription(monetaryType));

            this._totalProfitPerSecond = BusinessController.Businesses.Select(b => b.Profit / b.Cooldown).Aggregate((a, b) => a + b);
            double totalProfitPerSecondFormatted = MonetaryValueDisplay.GetMonetaryValue(this._totalProfitPerSecond, MonetaryValueDisplay.MonetaryTypes.Base, out monetaryType);
            lblCEarnPerSecond.Text = String.Format(new DecimalTruncateFormatProvider(), "i.e. {0:T(3)} {1} / sec", totalProfitPerSecondFormatted, EnumHelper.GetEnumDescription(monetaryType));

            this.ResumeLayout();
        }

        #endregion Businesses Tab

        #region Upgrades Tab

        private void DrawCashUpgrades(List<CashUpgrade<IAdVentureObject>> cashUpgrades)
        {
            if (cashUpgrades == null)
                return;

            this.SuspendLayout();

            for (int i = 0; i < cashUpgrades.Count; i++)
            {
                CheckBox ckb = new CheckBox()
                {
                    Location = new System.Drawing.Point(5, 25 + (23 * i)),
                    Name = "ckb" + cashUpgrades[i].Name.Replace(" ", String.Empty),
                    Size = new System.Drawing.Size(300, 17),
                    Tag = cashUpgrades[i],
                    Text = cashUpgrades[i].Name
                };
                ckb.CheckedChanged += ((s, e) =>
                {
                    CheckBox ck = (CheckBox)s;
                    CashUpgrade<IAdVentureObject> cashUpgrade = (CashUpgrade<IAdVentureObject>)ck.Tag;
                    cashUpgrade.IsActive = ck.Checked;

                    for (int j = 0; j < BusinessController.Businesses.Count; j++)
                        BusinessController.Businesses[j] = (Business)cashUpgrade.ProcessAffect((IAdVentureObject)BusinessController.Businesses[j]);

                    AngelInvestorController.AngelInvestors = (AngelInvestor)cashUpgrade.ProcessAffect((IAdVentureObject)AngelInvestorController.AngelInvestors);

                    // TODO: Improve Logic
                    DrawBusinesses(BusinessController.Businesses, true);
                });

                pnlUCashUpgrades.Controls.Add(ckb);
            }

            this.ResumeLayout();
        }

        private void DrawAngelUpgrades(List<AngelUpgrade<IAdVentureObject>> angelUpgrades)
        {
            if (angelUpgrades == null)
                return;

            this.SuspendLayout();

            for (int i = 0; i < angelUpgrades.Count; i++)
            {
                CheckBox ckb = new CheckBox()
                {
                    Location = new System.Drawing.Point(5, 25 + (23 * i)),
                    Name = "ckb" + angelUpgrades[i].Name.Replace(" ", String.Empty),
                    Size = new System.Drawing.Size(300, 17),
                    Tag = angelUpgrades[i],
                    Text = angelUpgrades[i].Name
                };
                ckb.CheckedChanged += ((s, e) =>
                {
                    CheckBox ck = (CheckBox)s;
                    AngelUpgrade<IAdVentureObject> angelUpgrade = (AngelUpgrade<IAdVentureObject>)ck.Tag;
                    angelUpgrade.IsActive = ck.Checked;

                    for (int j = 0; j < BusinessController.Businesses.Count; j++)
                        BusinessController.Businesses[j] = (Business)angelUpgrade.ProcessAffect((IAdVentureObject)BusinessController.Businesses[j]);

                    AngelInvestorController.AngelInvestors = (AngelInvestor)angelUpgrade.ProcessAffect((IAdVentureObject)AngelInvestorController.AngelInvestors);

                    // TODO: Improve Logic
                    DrawBusinesses(BusinessController.Businesses, true);
                });

                pnlUAngelUpgrades.Controls.Add(ckb);
            }

            this.ResumeLayout();
        }



        private void btnUBuyAllCashUpgrades_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnlUCashUpgrades.Controls)
            {
                CheckBox ckb = ctrl as CheckBox;

                if (ckb != null)
                    ckb.Checked = !_allCashUpgradesBought;
            }

            _allCashUpgradesBought = !_allCashUpgradesBought;
        }

        private void btnUBuyAllAngelUpgrades_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnlUAngelUpgrades.Controls)
            {
                CheckBox ckb = ctrl as CheckBox;

                if (ckb != null)
                    ckb.Checked = !_allAngelUpgradesBought;
            }

            _allAngelUpgradesBought = !_allAngelUpgradesBought;
        }

        #endregion Upgrades Tab

        #region Managers Tab

        private void DrawManagers(List<Manager> managers)
        {
            if (managers == null)
                return;

            this.SuspendLayout();

            for (int i = 0; i < managers.Count; i++)
            {
                CheckBox ckb = new CheckBox()
                {
                    Location = new System.Drawing.Point(5, 5 + (23 * i)),
                    Name = "ckb" + managers[i].Name.Replace(" ", String.Empty),
                    Size = new System.Drawing.Size(300, 17),
                    Tag = managers[i],
                    Text = managers[i].Name
                };
                ckb.CheckedChanged += ((s, e) =>
                {
                    CheckBox ck = (CheckBox)s;
                    Manager manager = (Manager)ck.Tag;
                    manager.IsActive = ck.Checked;

                    for (int j = 0; j < BusinessController.Businesses.Count; j++)
                        BusinessController.Businesses[j] = manager.ProcessAffect(BusinessController.Businesses[j]);
                });

                if (!String.IsNullOrWhiteSpace(managers[i].Description))
                {
                    ToolTip toolTip = new ToolTip();
                    toolTip.AutoPopDelay = 0;
                    toolTip.InitialDelay = 100;
                    //toolTip.ReshowDelay = 100;
                    toolTip.ShowAlways = true;

                    toolTip.SetToolTip(ckb, managers[i].Description);
                }

                pnlMManagers.Controls.Add(ckb);
            }

            this.ResumeLayout(true);
        }

        #endregion Managers Tab

        #region Export Reader Tab

        private void btnERReadExport_Click(object sender, EventArgs e)
        {
            /*
             * Base64 decrypt > LZF Decompression > UTF-8 > .JSON|checkSum
             * If MD5 checksum of the string decrypted and decompressed == checkSum
             *  Accept export and load details
            */

            // Trim invalid characters from export data
            // The valid Base64 character set is: A-Z a-z 0-9 +/=
            if (txtERExportText.Text.StartsWith("."))
                txtERExportText.Text = txtERExportText.Text.Substring(1);
            int pipeIndex = txtERExportText.Text.IndexOf('|');
            if (pipeIndex >= 0)
                txtERExportText.Text = txtERExportText.Text.Substring(0, pipeIndex);

            byte[] exportBytes = Convert.FromBase64String(txtERExportText.Text);
            byte[] exportBytesDecompressed = new byte[exportBytes.Length * 10];

            int newLength = new Lzf.LZF().Decompress(exportBytes, exportBytes.Length, exportBytesDecompressed, exportBytesDecompressed.Length);
            Array.Resize<byte>(ref exportBytesDecompressed, newLength); // Optional?

            Encoding encoding = Encoding.UTF8; // OR: Encoding.GetEncoding("ISO-8859-6");
            txtERExportText.Text = encoding.GetString(exportBytesDecompressed);
        }

        #endregion Export Reader Tab

        #region Calculations Tab

        private void RefreshBusinessCalculations(object sender, EventArgs e)
        {
            // TODO: Improve Logic
            if (tbcMain.SelectedTab.Text == "Calculations")
                DrawBusinesses(BusinessController.Businesses, true);
        }



        private void cmbCBusiness_SelectedIndexChanged(object sender, EventArgs e)
        {
            string freeLevelInfoString = "(including {0} free levels)";

            Business business = (Business)cmbCBusiness.SelectedValue;

            if (business != null)
                nudCCurrentBuildingCount.Minimum = business.FreeLevel;
            else
                nudCCurrentBuildingCount.Minimum = 0;

            lblCFreeLevels.Text = String.Format(freeLevelInfoString, business == null ? 0 : business.FreeLevel);
        }

        private void btnCCalculateCost_Click(object sender, EventArgs e)
        {
            double price = 0;
            MonetaryValueDisplay.MonetaryTypes monetaryType = MonetaryValueDisplay.MonetaryTypes.Base;

            Business business = (Business)cmbCBusiness.SelectedValue;

            if (business != null)
            {
                for (int i = 0; i < nudCBuyCount.Value; i++)
                    price += business.Cost * Math.Pow(business.Modifier, ((int)nudCCurrentBuildingCount.Value + i) - business.FreeLevel);

                // Select the best ValueModifier to show the total price.
                price = MonetaryValueDisplay.GetMonetaryValue(price, MonetaryValueDisplay.MonetaryTypes.Base, out monetaryType);
            }

            lblCCostDisplay.Text = String.Format(new DecimalTruncateFormatProvider(), "That'll cost {0:T(3)} {1}", price, monetaryType.ToString());
        }

        private void btnAICalculate_Click(object sender, EventArgs e)
        {
            /*
             * https://www.desmos.com/calculator/rfzjsgudsb
             * 
             * The formula is to calculate the sum of Total Angels, Currently Waiting Angels and Sacrificed Angels.
             * Here’s the formula only for Currently Waiting Angels:

((150 × (√L − √(L − S))) / √1 quadrillion) − K

             * Where L is Lifetime Earnings, S is Session Earnings and K is Sacrificed Angels

(150*(sqrt(L) – sqrt(L – S))) / (sqrt(10^15)) – K
            */

            MonetaryValueDisplay.MonetaryTypes monetaryType = (MonetaryValueDisplay.MonetaryTypes)cmbCDesiredAIValueType.SelectedValue;
            double actualValue = new MonetaryValueDisplay(Convert.ToDouble(nudCDesiredAI.Value), monetaryType).Value;

            double quadrillions = Math.Pow(actualValue / 150, 2);

            double value = MonetaryValueDisplay.GetMonetaryValue(quadrillions, MonetaryValueDisplay.MonetaryTypes.Quadrillion, out monetaryType);

            lblCTotalDisplay.Text = String.Format(new DecimalTruncateFormatProvider(), "You'll need a total of {0:T(3)} {1}\r\n(lifetime earnings).", value, monetaryType.ToString());
        }

        private void btnCToEarn_Click(object sender, EventArgs e)
        {
            double desiredTotalProfit = MonetaryValueDisplay.GetMonetaryValue(Convert.ToDouble(nudCToEarn.Value), (MonetaryValueDisplay.MonetaryTypes)cmbCToEarnValueType.SelectedItem, MonetaryValueDisplay.MonetaryTypes.Base);
            if (desiredTotalProfit > 0 && (desiredTotalProfit / this._totalProfitPerSecond) >= 1)
            {
                if ((desiredTotalProfit / this._totalProfitPerSecond) <= TimeSpan.MaxValue.TotalSeconds)
                    lblCTimeToWait.Text = String.Format("You need to wait {0} days", TimeSpan.FromSeconds(desiredTotalProfit / this._totalProfitPerSecond).ToString("dd\\.hh\\:mm\\:ss"));
                else
                    lblCTimeToWait.Text = "You need to wait a long, long time (restart or give up)...";
            }
            else
                lblCTimeToWait.Text = "You don't need to wait. You've already got it :)";
        }

        #endregion Calculations Tab
    }
}