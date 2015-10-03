using System;

namespace AdVentureCalculator.Model
{
    public class UpgradeObject<T> : AdVentureObject where T : IAdVentureObject
    {
        public string Id { get; set; }

        public bool IsActive { get; set; }

        public Func<UpgradeObject<T>, T, T> Affect { get; set; }

        public T ProcessAffect(T type)
        {
            if (Affect != null)
                return Affect(this, type);
            else
                return type;
        }
    }
}