using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace AdVentureCalculator.Model
{
    public class Business : PurchasableObject, INotifyPropertyChanged
    {
        public BusinessTypes Type { get; set; }

        public Planets Planet { get; set; }

        string name;
        public new string Name
        {
            get
            {
                if (String.IsNullOrWhiteSpace(name))
                    name = EnumHelper.GetEnumDescription(Type);

                return name;
            }
        }

        FunctionChainer<double> profit;
        public FunctionChainer<double> Profit
        {
            get { return this.profit; }
            set { this.profit = value; }
        }
        //public double Profit
        //{
        //    get
        //    {
        //        return this.profit.Value;
        //    }
        //    set
        //    {
        //        if (this.profit == null || this.profit.Value != value)
        //        {
        //            this.profit = new FunctionChainer<double>(value);

        //            InvokePropertyChanged(new PropertyChangedEventArgs("Profit"));
        //            InvokePropertyChanged(new PropertyChangedEventArgs("InfoString"));
        //        }
        //    }
        //}

        /// <summary>
        /// A value by which the business cost is increased each time a level is
        /// purchased.
        /// </summary>
        public double Modifier { get; set; }

        /// <summary>
        /// Cooldown until profit is applied, in Seconds
        /// </summary>
        public FunctionChainer<double> Cooldown { get; set; }

        public int Level { get; set; }

        FunctionChainer<int> freeLevel { get; set; }
        /// <summary>
        /// Changing the property directly will result in a loss of all functions
        /// associated with this property. Use the AddFreeLevel() and RemoveFreeLevel()
        /// functions instead.
        /// </summary>
        public int FreeLevel
        {
            get
            {
                return this.freeLevel.Value;
            }
            set
            {
                if (this.freeLevel == null || this.freeLevel.Value != value)
                {
                    this.freeLevel = new FunctionChainer<int>(value);

                    InvokePropertyChanged(new PropertyChangedEventArgs("TotalLevel"));
                    InvokePropertyChanged(new PropertyChangedEventArgs("FreeLevel"));
                    InvokePropertyChanged(new PropertyChangedEventArgs("InfoString"));
                }
            }
        }

        public int TotalLevel
        {
            get
            {
                /*
                 * If a FreeLevel upgrade has been added that brings the TotalLevel
                 * greater than the MaxLevel, we have to reduce the (paid) Level.
                */
                if ((Level + FreeLevel) > MaxLevel)
                    Level = MaxLevel - freeLevel;

                //return Math.Min(Level + FreeLevel, MaxLevel);
                return Level + FreeLevel;
            }
            set
            {
                Level = (value - FreeLevel);

                InvokePropertyChanged(new PropertyChangedEventArgs("TotalLevel"));
                InvokePropertyChanged(new PropertyChangedEventArgs("InfoString"));
            }
        }

        public int MaxLevel { get; set; }



        public Business()
        {
            this.Cooldown = 0;
            this.freeLevel = 0;
            this.profit = 0;
        }



        public string InfoString
        {
            get
            {
                MonetaryValueDisplay.MonetaryTypes monetaryType;
                double totalProfit = MonetaryValueDisplay.GetMonetaryValue(Profit.Value, MonetaryValueDisplay.MonetaryTypes.Base, out monetaryType);
                string totalProfitString = String.Format(new DecimalTruncateFormatProvider(), "{0:T(3)} {1}", totalProfit, EnumHelper.GetEnumDescription(monetaryType));

                double profitPerSec = MonetaryValueDisplay.GetMonetaryValue(Profit.Value / Cooldown, MonetaryValueDisplay.MonetaryTypes.Base, out monetaryType);
                string profitPerSecString = String.Format(new DecimalTruncateFormatProvider(), "{0:T(3)} {1}", profitPerSec, EnumHelper.GetEnumDescription(monetaryType));

                //return String.Format("Cooldown: {0}, Profit: {1} ({2} / sec)", Cooldown, totalProfitString, profitPerSecString);
                return String.Format("{0} -> ({1} / {2} sec)", String.Format("Profit: {0} / sec", profitPerSecString).PadRight(40, ' '), totalProfitString, Cooldown);
            }
        }


        //public void AddProfits(Dictionary<string, Func<double, double>> fns)
        //{
        //    this.profit.AddRange(fns);

        //    InvokePropertyChanged(new PropertyChangedEventArgs("Profit"));
        //    InvokePropertyChanged(new PropertyChangedEventArgs("InfoString"));
        //}

        //public void AddProfit(string affectName, Func<double, double> fn)
        //{
        //    this.profit.Add(affectName, fn);

        //    InvokePropertyChanged(new PropertyChangedEventArgs("Profit"));
        //    InvokePropertyChanged(new PropertyChangedEventArgs("InfoString"));
        //}

        //public void RemoveProfit(string affectName)
        //{
        //    this.profit.Remove(affectName);

        //    InvokePropertyChanged(new PropertyChangedEventArgs("Profit"));
        //    InvokePropertyChanged(new PropertyChangedEventArgs("InfoString"));
        //}

        public void AddFreeLevel(string affectName, Func<int, int> fn)
        {
            this.freeLevel.Add(affectName, fn);

            InvokePropertyChanged(new PropertyChangedEventArgs("TotalLevel"));
            InvokePropertyChanged(new PropertyChangedEventArgs("FreeLevel"));
            InvokePropertyChanged(new PropertyChangedEventArgs("InfoString"));
        }

        public void RemoveFreeLevel(string affectName)
        {
            this.freeLevel.Remove(affectName);

            InvokePropertyChanged(new PropertyChangedEventArgs("TotalLevel"));
            InvokePropertyChanged(new PropertyChangedEventArgs("FreeLevel"));
            InvokePropertyChanged(new PropertyChangedEventArgs("InfoString"));
        }



        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }

        #endregion INotifyPropertyChanged Implementation
    }
}