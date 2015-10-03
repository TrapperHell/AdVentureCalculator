using System;

namespace AdVentureCalculator.Model
{
    public class PurchasableObject : AdVentureObject
    {
        public MonetaryValueDisplay Value { get; set; }

        public FunctionChainer<double> Cost { get; set; }

        public Currencies Currency { get; set; }
    }
}