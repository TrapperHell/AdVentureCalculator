using System;

namespace AdVentureCalculator.Model
{
    public class Manager : AdVentureObject
    {
        public enum Types
        {
            Normal = 1,
            Accountant = 2,
            Discount = 3
        }

        public bool IsActive { get; set; }

        public Func<Manager, Business, Business> Affect { get; set; }

        public Business ProcessAffect(Business business)
        {
            return Affect(this, business);
        }

        public string Description { get; set; }

        public Types Type { get; set; }
    }
}