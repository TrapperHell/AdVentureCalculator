using System.ComponentModel;

namespace AdVentureCalculator.Model
{
    public enum BusinessTypes
    {
        All,

        // Earth Businesses
        [Description("Lemonade Stand")]
        Lemon,
        [Description("Newspaper Delivery")]
        Newspaper,
        [Description("Car Wash")]
        Car,
        [Description("Pizza Delivery")]
        Pizza,
        [Description("Donut Shop")]
        Donut,
        [Description("Shrimp Boat")]
        Shrimp,
        [Description("Hockey Team")]
        Hockey,
        [Description("Movie Studio")]
        Movie,
        [Description("Bank")]
        Bank,
        [Description("Oil Company")]
        Oil,

        // Moon Businesses
        [Description("Moon Shoe")]
        Shoe,
        [Description("Gravity Booth")]
        Booth,
        [Description("Payday Clone")]
        Clone,
        [Description("Moon Express")]
        Express,
        [Description("Oxygen Bar")]
        Bar,
        [Description("Helium-3")]
        Helium,
        [Description("Cheese Mine")]
        Mine,
        [Description("Amusement Park")]
        Park,
        [Description("Werewolf Colony")]
        Colony,
        [Description("Giant Laser")]
        Laser
    }
}