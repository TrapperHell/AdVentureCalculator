namespace AdVentureCalculator.Model
{
    public class AdVentureObject : IAdVentureObject
    {
        public enum Currencies
        {
            Monetary = 1,
            Angels = 2
        }

        public string Name { get; set; }
    }
}