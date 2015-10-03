using System.ComponentModel;

namespace AdVentureCalculator.Model
{
    public class AngelInvestor : AdVentureObject, INotifyPropertyChanged
    {
        public double Total
        {
            get
            {
                return MonetaryValueDisplay.GetMonetaryValue(amount, type, MonetaryValueDisplay.MonetaryTypes.Base);
            }
        }

        MonetaryValueDisplay.MonetaryTypes type;
        public MonetaryValueDisplay.MonetaryTypes Type
        {
            get { return type; }
            set
            {
                type = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Type"));
                InvokePropertyChanged(new PropertyChangedEventArgs("Total"));
            }
        }

        double amount = 0;
        public double Amount
        {
            get { return amount; }
            set
            {
                amount = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Amount"));
                InvokePropertyChanged(new PropertyChangedEventArgs("Total"));
            }
        }

        double effectiveness = 2;
        public double Effectiveness
        {
            get { return effectiveness; }
            set
            {
                effectiveness = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("Effectiveness"));
            }
        }



        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }

        #endregion INotifyPropertyChanged Implementation
    }
}