using System;
using System.Collections.Generic;
using AdVentureCalculator.Model;

namespace AdVentureCalculator.Controller
{
    public static class UpgradeController
    {
        #region Initializer

        #region Angel Upgrades

        public static List<AngelUpgrade<IAdVentureObject>> AngelUpgrades = new List<AngelUpgrade<IAdVentureObject>>(new List<AngelUpgrade<IAdVentureObject>>()
        {
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Angel Sacrifice",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Angel Sacrifice", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Angelic Mutiny",
                Affect = AngelInvestorEffectiveness(2)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Angelic Rebellion",
                Affect = AngelInvestorEffectiveness(2)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Angelic Selection",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Angelic Selection", 5)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Divine Intervention",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Divine Intervention", 9)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Newspaper Swap",
                Affect = BusinessFreeLevel(BusinessTypes.Newspaper, "Newspaper Swap", 10)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Car Wash Swap",
                Affect = BusinessFreeLevel(BusinessTypes.Car, "Car Wash Swap", 10)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Pizza Swap",
                Affect = BusinessFreeLevel(BusinessTypes.Pizza, "Pizza Swap", 10)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Donut Swap",
                Affect = BusinessFreeLevel(BusinessTypes.Donut, "Donut Swap", 10)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Newspaper Surge",
                Affect = BusinessFreeLevel(BusinessTypes.Newspaper, "Newspaper Surge", 50)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Car Wash Surge",
                Affect = BusinessFreeLevel(BusinessTypes.Car, "Car Wash Surge", 50)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Pizza Surge",
                Affect = BusinessFreeLevel(BusinessTypes.Pizza, "Pizza Surge", 50)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Donut Surge",
                Affect = BusinessFreeLevel(BusinessTypes.Donut, "Donut Surge", 50)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Newspaper Merger",
                Affect = BusinessFreeLevel(BusinessTypes.Newspaper, "Newspaper Merger", 50)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Car Wash Merger",
                Affect = BusinessFreeLevel(BusinessTypes.Car, "Car Wash Merger", 50)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Pizza Merger",
                Affect = BusinessFreeLevel(BusinessTypes.Pizza, "Pizza Merger", 50)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Donut Merger",
                Affect = BusinessFreeLevel(BusinessTypes.Donut, "Donut Merger", 50)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Rapture Contingent",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Rapture Contingent", 11)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Newspaperion Ultrus",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Newspaperion Ultrus", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Washicus Maximus",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Washicus Maximus", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Pizzeria Primus",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Pizzeria Primus", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Ultimus Donuticus",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Ultimus Donuticus", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Shrimpus Glorious",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Shrimpus Glorious", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Puckus Alotus",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Puckus Alotus", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Cinemaxima Spiritus",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Cinemaxima Spiritus", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Fundorium Sanctum",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Fundorium Sanctum", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Oil Vincit Omnia",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Oil Vincit Omnia", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Lemonus Supremus",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Lemonus Supremus", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Buy Earth",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Buy Earth", 15)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Newspaper Takeover",
                Affect = BusinessFreeLevel(BusinessTypes.Newspaper, "Newspaper Takeover", 75)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Car Wash Takeover",
                Affect = BusinessFreeLevel(BusinessTypes.Car, "Car Wash Takeover", 75)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Pizza Takeover",
                Affect = BusinessFreeLevel(BusinessTypes.Pizza, "Pizza Takeover", 75)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Donut Takeover",
                Affect = BusinessFreeLevel(BusinessTypes.Donut, "Donut Takeover", 75)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Shrimp Take Over",
                Affect = BusinessFreeLevel(BusinessTypes.Shrimp, "Shrimp Take Over", 75)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Newspaper Assimilation",
                Affect = BusinessFreeLevel(BusinessTypes.Newspaper, "Newspaper Assimilation", 75)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Car Wash Assimilation",
                Affect = BusinessFreeLevel(BusinessTypes.Car, "Car Wash Assimilation", 75)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Pizza Assimilation",
                Affect = BusinessFreeLevel(BusinessTypes.Pizza, "Pizza Assimilation", 75)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Donut Assimilation",
                Affect = BusinessFreeLevel(BusinessTypes.Donut, "Donut Assimilation", 75)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Shrimp Assimilation",
                Affect = BusinessFreeLevel(BusinessTypes.Shrimp, "Shrimp Assimilation", 75)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "First Amen-dment",
                Affect = BusinessFreeLevel(BusinessTypes.Newspaper, "First Amen-dment", 100)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Unrefusable Offer",
                Affect = BusinessFreeLevel(BusinessTypes.Car, "Unrefusable Offer", 100)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Paradise Lost and Found",
                Affect = AngelInvestorEffectiveness(10)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Black Friday the 13th",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Black Friday the 13th", 15)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Divine Write Off",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Divine Write Off", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "In Brightest Day…",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "In Brightest Day…", 5)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "In Darkest Night…",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "In Darkest Night…", 5)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "The Good News",
                Affect = BusinessFreeLevel(BusinessTypes.Newspaper, "The Good News", 50)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Synergize Suds",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Synergize Suds", 4)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Feta Beta-Testing",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Feta Beta-Testing", 6)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Pumpkin Spice",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Pumpkin Spice", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Cocktail Parties",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Cocktail Parties", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Free Jerseys",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Free Jerseys", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "In-Universe Continuity",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "In-Universe Continuity", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Dolla Bills Ya'll",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Dolla Bills Ya'll", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Anti-Solar Research",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Anti-Solar Research", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Divine Squeeze",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Divine Squeeze", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Perfumed Pages",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Perfumed Pages", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Hark!",
                Affect = AngelInvestorEffectiveness(10)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Fold Into Hats",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Fold Into Hats", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Free Breakfast",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Free Breakfast", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Little Nero's",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Little Nero's", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Donut Isotopes",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Donut Isotopes", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Son Of A Shrimp",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Son Of A Shrimp", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Quack!",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Quack!", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Rotten Potatoes",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Rotten Potatoes", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Money Bin Life Guards",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Money Bin Life Guards", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Texas Tea",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Texas Tea", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Lemonster",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Lemonster", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Recycling Boom",
                Affect = BusinessFreeLevel(BusinessTypes.Newspaper, "Recycling Boom", 30)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Redundant Facilities",
                Affect = BusinessFreeLevel(BusinessTypes.Car, "Redundant Facilities", 30)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "No Competitors",
                Affect = BusinessFreeLevel(BusinessTypes.Pizza, "No Competitors", 30)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Donut Boutiques",
                Affect = BusinessFreeLevel(BusinessTypes.Donut, "Donut Boutiques", 30)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Hokey Honky Hockey",
                Affect = BusinessFreeLevel(BusinessTypes.Hockey, "Hokey Honky Hockey", 30)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Sacred Trust Fund",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Sacred Trust Fund", 5)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Effective Marketing",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Effective Marketing", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Car Dirty-ers",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Car Dirty-ers", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Guaranteed Horse Free",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Guaranteed Horse Free", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Cartoon Endorsments",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Cartoon Endorsments", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Government Subsidy",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Government Subsidy", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Union Busting",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Union Busting", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Hire Viewers",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Hire Viewers", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Sue Everything",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Sue Everything", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Accident Free Week",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Accident Free Week", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Fund Favorable Studies",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Fund Favorable Studies", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Hallelujah!",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Hallelujah!", 7)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Heavenly News",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Heavenly News", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Discount For Investors",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Discount For Investors", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Ascended Pizza",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Ascended Pizza", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Holy Donut Holes",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Holy Donut Holes", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Shrimp Saints",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Shrimp Saints", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Angelic Refs",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Angelic Refs", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Angel Best Boys",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Angel Best Boys", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Seraph Saturdays",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Seraph Saturdays", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "The Cleansing Fires",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "The Cleansing Fires", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Thirsty Cherubs",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Thirsty Cherubs", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "It Is Done",
                Affect = BusinessFreeLevel(BusinessTypes.Newspaper, "It Is Done", 50)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Profit-dence",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Profit-dence", 7.777777)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Emergency Reserves",
                Affect = BusinessFreeLevel(BusinessTypes.Newspaper, "Emergency Reserves", 10)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Bite The Cost",
                Affect = BusinessFreeLevel(BusinessTypes.Car, "Bite The Cost", 10)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "A Little Further",
                Affect = BusinessFreeLevel(BusinessTypes.Pizza, "A Little Further", 10)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Desperate Measures",
                Affect = BusinessFreeLevel(BusinessTypes.Donut, "Desperate Measures", 10)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Impulse Bay",
                Affect = BusinessFreeLevel(BusinessTypes.Shrimp, "Impulse Bay", 10)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Seize Every Inch",
                Affect = BusinessFreeLevel(BusinessTypes.Hockey, "Seize Every Inch", 10)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Small Opportunity",
                Affect = BusinessFreeLevel(BusinessTypes.Movie, "Small Opportunity", 10)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Off Shore Refuge",
                Affect = BusinessFreeLevel(BusinessTypes.Bank, "Off Shore Refuge", 10)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Shell Corporations",
                Affect = BusinessFreeLevel(BusinessTypes.Oil, "Shell Corporations", 10)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Expensive",
                Affect = BusinessFreeLevel(BusinessTypes.Lemon, "Expensive", 10)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Manufacture The News",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Manufacture The News", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Freak Dust Storms",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Freak Dust Storms", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Famine Zone Delivery",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Famine Zone Delivery", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Heritage Appeal",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Heritage Appeal", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Onboard Orchestra",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Onboard Orchestra", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Pay Per view",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Pay Per view", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Enough Parking Spots",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Enough Parking Spots", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Catapults",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Catapults", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Large Hadron Pumps",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Large Hadron Pumps", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Oktoberlemon",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Oktoberlemon", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Propped Up",
                Affect = BusinessFreeLevel(BusinessTypes.Car, "Propped Up", 25)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Aunty Idol",
                Affect = BusinessFreeLevel(BusinessTypes.Newspaper, "Aunty Idol", 25)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Pizza Clicker",
                Affect = BusinessFreeLevel(BusinessTypes.Pizza, "Pizza Clicker", 25)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Donut Box",
                Affect = BusinessFreeLevel(BusinessTypes.Donut, "Donut Box", 25)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Clicker Shrimps",
                Affect = BusinessFreeLevel(BusinessTypes.Shrimp, "Clicker Shrimps", 25)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Dark Hockey",
                Affect = BusinessFreeLevel(BusinessTypes.Hockey, "Dark Hockey", 25)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Farley's Angels",
                Affect = BusinessFreeLevel(BusinessTypes.Movie, "Farley's Angels", 25)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Aggressive Negotiation",
                Affect = BusinessFreeLevel(BusinessTypes.Bank, "Aggressive Negotiation", 25)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Worth It?",
                Affect = BusinessFreeLevel(BusinessTypes.Oil, "Worth It?", 25)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Lemon Scented Angels",
                Affect = BusinessFreeLevel(BusinessTypes.Lemon, "Lemon Scented Angels", 25)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Loyal Readers",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Loyal Readers", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Mud Enthusiasts",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Mud Enthusiasts", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Gamers",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Gamers", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Police Officers",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Police Officers", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Voracious Tourists",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Voracious Tourists", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Canadian Angels",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Canadian Angels", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Movie Buffs",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Movie Buffs", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Up And Coming Capitalists",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Up And Coming Capitalists", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Off Roaders",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Off Roaders", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Thirsty Neighbors",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Thirsty Neighbors", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Proverbs",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Proverbs", 13.11)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Pile Of Haloes",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Pile Of Haloes", 5)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Last Lunch Special",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Last Lunch Special", 3)
            },
			new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Holy Guacamole",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Holy Guacamole", 4)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Low Sinterest Rates",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Low Sinterest Rates", 5)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Newspaper Dealing",
                Affect = BusinessFreeLevel(BusinessTypes.Newspaper, "Newspaper Dealing", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Carwash Dealing",
                Affect = BusinessFreeLevel(BusinessTypes.Car, "Carwash Dealing", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Pizza Dealing",
                Affect = BusinessFreeLevel(BusinessTypes.Pizza, "Pizza Dealing", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Donut Dealing",
                Affect = BusinessFreeLevel(BusinessTypes.Donut, "Donut Dealing", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Shrimp Dealing",
                Affect = BusinessFreeLevel(BusinessTypes.Shrimp, "Shrimp Dealing", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Hockey Dealing",
                Affect = BusinessFreeLevel(BusinessTypes.Hockey, "Hockey Dealing", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Movie Dealing",
                Affect = BusinessFreeLevel(BusinessTypes.Movie, "Movie Dealing", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Bank Dealing",
                Affect = BusinessFreeLevel(BusinessTypes.Bank, "Bank Dealing", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Oil Dealing",
                Affect = BusinessFreeLevel(BusinessTypes.Oil, "Oil Dealing", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Lemon Dealing",
                Affect = BusinessFreeLevel(BusinessTypes.Lemon, "Lemon Dealing", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Ultra Mega Death Holiness",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Ultra Mega Death Holiness", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Angel-Sourced Ingredients",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Angel-Sourced Ingredients", 3)
            },

            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Blessed Fuzzy Dice",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Blessed Fuzzy Dice", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Holy Moley Guacamole",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Holy Moley Guacamole", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Heavenly Sprinkles",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Heavenly Sprinkles", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Tridents",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Tridents", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Turn Water Into Teeth",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Turn Water Into Teeth", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Answered Movie Prayers",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Answered Movie Prayers", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Security Guardians",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Security Guardians", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Peppy Laborforce",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Peppy Laborforce", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Awe-Inspiring Toasts",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Awe-Inspiring Toasts", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Pizza Transaction",
                Affect = BusinessFreeLevel(BusinessTypes.Pizza, "Pizza Transaction", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Donut Transaction",
                Affect = BusinessFreeLevel(BusinessTypes.Donut, "Donut Transaction", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Shrimp Transaction",
                Affect = BusinessFreeLevel(BusinessTypes.Shrimp, "Shrimp Transaction", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Hockey Transaction",
                Affect = BusinessFreeLevel(BusinessTypes.Hockey, "Hockey Transaction", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Movie Transaction",
                Affect = BusinessFreeLevel(BusinessTypes.Movie, "Movie Transaction", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Bank Transaction",
                Affect = BusinessFreeLevel(BusinessTypes.Bank, "Bank Transaction", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Oil Transaction",
                Affect = BusinessFreeLevel(BusinessTypes.Oil, "Oil Transaction", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Lemon Transaction",
                Affect = BusinessFreeLevel(BusinessTypes.Lemon, "Lemon Transaction", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Venerated Bike Baskets",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Venerated Bike Baskets", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Venerated Hoses",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Venerated Hoses", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Venerated Pizza Savers",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Venerated Pizza Savers", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Venerated Novelty Mugs",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Venerated Novelty Mugs", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Venerated Rain Caps",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Venerated Rain Caps", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Venerated Hockey Tape",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Venerated Hockey Tape", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Venerated Clackers",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Venerated Clackers", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Venerated Spreadsheets",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Venerated Spreadsheets", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Venerated Lunch Boxes",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Venerated Lunch Boxes", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Venerated Sippy Cups",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Venerated Sippy Cups", 3)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Let There Be Stories",
                Affect = BusinessFreeLevel(BusinessTypes.Newspaper, "Let There Be Stories", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Let There Be Clean",
                Affect = BusinessFreeLevel(BusinessTypes.Car, "Let There Be Clean", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Let There Be Feasts",
                Affect = BusinessFreeLevel(BusinessTypes.Pizza, "Let There Be Feasts", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Let There Be Pastries",
                Affect = BusinessFreeLevel(BusinessTypes.Donut, "Let There Be Pastries", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Let There Be Cocktails",
                Affect = BusinessFreeLevel(BusinessTypes.Shrimp, "Let There Be Cocktails", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Let There Be Games",
                Affect = BusinessFreeLevel(BusinessTypes.Hockey, "Let There Be Games", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Let There Be Classics",
                Affect = BusinessFreeLevel(BusinessTypes.Movie, "Let There Be Classics", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Let There Be Cashflow",
                Affect = BusinessFreeLevel(BusinessTypes.Bank, "Let There Be Cashflow", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Let There Be Blood",
                Affect = BusinessFreeLevel(BusinessTypes.Oil, "Let There Be Blood", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Let There Be Lemons",
                Affect = BusinessFreeLevel(BusinessTypes.Lemon, "Let There Be Lemons", 25)
            },
            new AngelUpgrade<IAdVentureObject>()
            {
                Name = "Forever And Ever",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Forever And Ever", 19)
            }
        });

        #endregion Angel Upgrades

        #region Cash Upgrades

        public static List<CashUpgrade<IAdVentureObject>> CashUpgrades = new List<CashUpgrade<IAdVentureObject>>(new CashUpgrade<IAdVentureObject>[]
        {
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Little Umbrellas",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Little Umbrellas", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Funny Pages",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Funny Pages", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Drive Through Wash",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Drive Through Wash", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Robot Cars",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Robot Cars", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Pre-packaged Pastries",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Pre-packaged Pastries", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Shrimp Satellite",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Shrimp Satellite", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Team Jet",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Team Jet", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "3D Cameras",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "3D Cameras", 3)
            },new CashUpgrade<IAdVentureObject>()
            {
                Name = "Gold Plated Vaults",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Gold Plated Vaults", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Spill Proof Tankers",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Spill Proof Tankers", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Monopoly",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Monopoly", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Novelty Straws",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Novelty Straws", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Sports Pages",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Sports Pages", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Automatic Vacuums",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Automatic Vacuums", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Online Ordering",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Online Ordering", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Donut Holes",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Donut Holes", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Shrimp Magnets",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Shrimp Magnets", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Energy Drink Sponsors",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Energy Drink Sponsors", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Green Screens",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Green Screens", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Free Fancy Pens",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Free Fancy Pens", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Eco-safe Pipeline",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Eco-safe Pipeline", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Monopsony",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Monopsony", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Holy Moola",
                Affect = AngelInvestorEffectiveness(1),
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Imported Ice Cubes",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Imported Ice Cubes", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Business Pages",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Business Pages", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Microfiber Sponges",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Microfiber Sponges", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Drone Delivery",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Drone Delivery", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Bacon Sprinkles",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Bacon Sprinkles", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Carbon Nanotube Nets",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Carbon Nanotube Nets", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "GPS Puck Tracker",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "GPS Puck Tracker", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Smell-O-Vision",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Smell-O-Vision", 3)
            },new CashUpgrade<IAdVentureObject>()
            {
                Name = "Credit Card Implants",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Credit Card Implants", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Hyperloop Pumps",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Hyperloop Pumps", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Illuminati",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Illuminati", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Immaculate Consumption",
                Affect = AngelInvestorEffectiveness(1),
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Combustible Lemons",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Combustible Lemons", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Gossip Pages",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Gossip Pages", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Blue Sky Brand Wax",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Blue Sky Brand Wax", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Caviar Stuffed Crust",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Caviar Stuffed Crust", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Free Coffee",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Free Coffee", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "3D Printed Shrimp",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "3D Printed Shrimp", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Lord Stanley's Cup",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Lord Stanley's Cup", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "James Camera",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "James Camera", 3)
            },new CashUpgrade<IAdVentureObject>()
            {
                Name = "Dogecoin",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Dogecoin", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Biodiesel Derricks",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Biodiesel Derricks", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Profit Prophet",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Profit Prophet", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Eternal Revenue Service",
                Affect = AngelInvestorEffectiveness(2),
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Gold Plated Lemons",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Gold Plated Lemons", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Celebrity Delivery",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Celebrity Delivery", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Bikini Babes",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Bikini Babes", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Dessert Pizzas",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Dessert Pizzas", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Intravenous Java",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Intravenous Java", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Alcubierre Drives",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Alcubierre Drives", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Holy Hockey Sticks",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Holy Hockey Sticks", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Rebooted Sequels",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Rebooted Sequels", 7)
            },new CashUpgrade<IAdVentureObject>()
            {
                Name = "Giant Novelty Cheques",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Giant Novelty Cheques", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Solar Powered Derricks",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Solar Powered Derricks", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Super PAC Man",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Super PAC Man", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Low Orbit Delivery",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Low Orbit Delivery", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Beef Cake Buffers",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Beef Cake Buffers", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Recyclable Pizza",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Recyclable Pizza", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Donut Bosons",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Donut Bosons", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "All You Can Eat (Upgrade)",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "All You Can Eat (Upgrade)", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Oculus Pucks",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Oculus Pucks", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Temporal Retcon",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Temporal Retcon", 3)
            },new CashUpgrade<IAdVentureObject>()
            {
                Name = "Friendly Staff",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Friendly Staff", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Self Aware Wells",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Self Aware Wells", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Self Picking Lemons",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Self Picking Lemons", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Trust Buster Buster",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Trust Buster Buster", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Bias Detector",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Bias Detector", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "New Car Odorants",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "New Car Odorants", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Pizzaception",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Pizzaception", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Graham's Donut",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Graham's Donut", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Shrimp Is Life",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Shrimp Is Life", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Teeth Replacements",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Teeth Replacements", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Post-Credit Newralyzer",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Post-Credit Newralyzer", 3)
            },new CashUpgrade<IAdVentureObject>()
            {
                Name = "No Service Charges",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "No Service Charges", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Zombie Proof Rigs",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Zombie Proof Rigs", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Unlimited Refills",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Unlimited Refills", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Smiles Are Free",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Smiles Are Free", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Heavenly Tax Shelter",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Heavenly Tax Shelter", 5)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Employ Humanity",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Employ Humanity", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Old Timey Charm",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Old Timey Charm", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Matchbox Adapter",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Matchbox Adapter", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Moxie Injections",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Moxie Injections", 9)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Deep Dish 9",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Deep Dish 9", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Mug-Friendly Diapers",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Mug-Friendly Diapers", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Immortality Research",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Immortality Research", 11)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Talk Like A Pirate",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Talk Like A Pirate", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Kicking Soundtrack",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Kicking Soundtrack", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Your Body Is Ready",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Your Body Is Ready", 13)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Crass Pandering",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Crass Pandering", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Golden Money Clip",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Golden Money Clip", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "A Towel",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "A Towel", 15)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Air Fresheners",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Air Fresheners", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Lemon Hope",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Lemon Hope", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "LOTS Of Sticky Notes",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "LOTS Of Sticky Notes", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Pi Charts",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Pi Charts", 3.1415926)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Faux News",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Faux News", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Free Bobblehead",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Free Bobblehead", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Superfood Status",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Superfood Status", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "King Horton",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "King Horton", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Deadliest Catcher",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Deadliest Catcher", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Shiny Pucks",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Shiny Pucks", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Kitten Ushers",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Kitten Ushers", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "+1% Interest",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "+1% Interest", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Asteroid Drillers",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Asteroid Drillers", 3)
            },
			new CashUpgrade<IAdVentureObject>()
			{
                Name = "Mass Thirst-eria",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Mass Thirst-eria", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Golden Parachute",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Golden Parachute", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Black Tuesday Deals",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Black Tuesday Deals", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Crash Memorial Sale",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Crash Memorial Sale", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Patriotic Pizza",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Patriotic Pizza", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Open Holidays",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Open Holidays", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Sheesh-kabobs",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Sheesh-kabobs", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Capped Salaries",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Capped Salaries", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Pleasing Distraction",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Pleasing Distraction", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Googol",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Googol", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "2 Googols",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "2 Googols", 6)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Bailouts For Everyone",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Bailouts For Everyone", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Pumping Freedom",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Pumping Freedom", 2)
            },
			new CashUpgrade<IAdVentureObject>()
			{
                Name = "'Merica Flavored",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "'Merica Flavored", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Recession Progression",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Recession Progression", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Capitaltastic!",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Capitaltastic!", 5)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Car Wash Focus",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Car Wash Focus", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Enable Employees",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Enable Employees", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Diversify Brand",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Diversify Brand", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Pizza Focus",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Pizza Focus", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Adorable Mascot",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Adorable Mascot", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Free Bread Sticks",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Free Bread Sticks", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Donut Focus",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Donut Focus", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Soylent Frosting",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Soylent Frosting", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Hand Made",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Hand Made", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Stock Tips",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Stock Tips", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Shrimp Focus",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Shrimp Focus", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Tiny Top Hats",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Tiny Top Hats", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Shrimp Shaped Boats",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Shrimp Shaped Boats", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Hockey Focus",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Hockey Focus", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Cloud Based Goalies",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Cloud Based Goalies", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Friendly Commissioner",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Friendly Commissioner", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Cigar Shaped Mansion",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Cigar Shaped Mansion", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Movie Focus",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Movie Focus", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Catered Lunches",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Catered Lunches", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "More Sparkles",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "More Sparkles", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Bank Focus",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Bank Focus", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Booth Banks",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Booth Banks", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "More Evil",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "More Evil", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Oil Focus",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Oil Focus", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "All The Lobbyists",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "All The Lobbyists", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Climate Sch-limate",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Climate Sch-limate", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Disposable Veyrons",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Disposable Veyrons", 3)
            },
			new CashUpgrade<IAdVentureObject>()
			{
                Name = "Lemon Focus",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Lemon Focus", 3)
            },
			new CashUpgrade<IAdVentureObject>()
			{
                Name = "Hybrid Lemons",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Hybrid Lemons", 3)
            },
			new CashUpgrade<IAdVentureObject>()
			{
                Name = "Money In The Stand",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Money In The Stand", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Newspaper Focus",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Newspaper Focus", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Self Advertising",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Self Advertising", 3)
            },new CashUpgrade<IAdVentureObject>()
            {
                Name = "Free Puppies",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Free Puppies", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "The Capital Capital",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "The Capital Capital", 5)
            },new CashUpgrade<IAdVentureObject>()
            {
                Name = "Make It Storm",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Make It Storm", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Printed On Money",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Printed On Money", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Conflict Free Suds",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Conflict Free Suds", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Anti-Terrorism Toppings",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Anti-Terrorism Toppings", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Freedom Infused",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Freedom Infused", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Shrimply Amazing",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Shrimply Amazing", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Elocution Lessons",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Elocution Lessons", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Drama Llamas",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Drama Llamas", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "You Can Bank On It",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "You Can Bank On It", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Oil/Oil Hybrid",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Oil/Oil Hybrid", 3)
            },
			new CashUpgrade<IAdVentureObject>()
			{
                Name = "Frosted Glasses",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Frosted Glasses", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "A Sinister Proposal",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "A Sinister Proposal", 6.66)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Frankly Ridiculous",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Frankly Ridiculous", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Self Fetching",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Self Fetching", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Mr. Sheen",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Mr. Sheen", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "It's Not Delivery",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "It's Not Delivery", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Mmmmm… Sprinkles",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Mmmmm… Sprinkles", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "The Shrimp Must Flow",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "The Shrimp Must Flow", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Heated Seats",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Heated Seats", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Movie-ception",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Movie-ception", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Fat Cat Scratch Post",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Fat Cat Scratch Post", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Sparkly Derricks",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Sparkly Derricks", 3)
            },
			new CashUpgrade<IAdVentureObject>()
			{
                Name = "Haunted Trees",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Haunted Trees", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Cross Promotions",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Cross Promotions", 5)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Car Sweaters",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Car Sweaters", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Free Candy",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Free Candy", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Shakers",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Shakers", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Complementary Pretzels",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Complementary Pretzels", 3)
            },
			new CashUpgrade<IAdVentureObject>()
			{
                Name = "Mineral Infused",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Mineral Infused", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Action Figures",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Action Figures", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Public Access Publishing",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Public Access Publishing", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Pre-Screen Ads",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Pre-Screen Ads", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Holiday Specials",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Holiday Specials", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Inspiring Documentary",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Inspiring Documentary", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Lax Regulations",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Lax Regulations", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Slow News Day",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Slow News Day", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Sluggish Sales",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Sluggish Sales", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "10 For 1 Sale",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "10 For 1 Sale", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Sprinkle Fatigue",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Sprinkle Fatigue", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Antihistamine Cocktails",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Antihistamine Cocktails", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Ratings Slippage",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Ratings Slippage", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Anti-Piracy Measures",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Anti-Piracy Measures", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Credit Union Smear Ads",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Credit Union Smear Ads", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Raise Prices",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Raise Prices", 2)
            },
			new CashUpgrade<IAdVentureObject>()
			{
                Name = "Suppress Iced Tea",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Suppress Iced Tea", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Restructuring",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Restructuring", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Price Reduction",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Price Reduction", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Sign Spinners",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Sign Spinners", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Buzzing Signs",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Buzzing Signs", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Couch Cushions Check",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Couch Cushions Check", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Tax Free Tuesdays",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Tax Free Tuesdays", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Pollock Substitue",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Pollock Substitue", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Kids Watch Free",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Kids Watch Free", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Cheap Night",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Cheap Night", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "ReOrg",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "ReOrg", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Think Tanks",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Think Tanks", 3)
            },
			new CashUpgrade<IAdVentureObject>()
			{
                Name = "Artifical Sugar",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Artifical Sugar", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Market Recovery",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Market Recovery", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Newspaper Ads",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Newspaper Ads", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Germaphobic Public",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Germaphobic Public", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Secret Ingredients",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Secret Ingredients", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Mildly Addictive",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Mildly Addictive", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Fad Diet",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Fad Diet", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Collectible Players",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Collectible Players", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Effective DRM",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Effective DRM", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Staff Parties",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Staff Parties", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Rollin' Cool Kits",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Rollin' Cool Kits", 3)
            },
			new CashUpgrade<IAdVentureObject>()
			{
                Name = "3 Star Stands",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "3 Star Stands", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "''e' Business",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "''e' Business", 2.71828)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Inflate Demand",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Inflate Demand", 5)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Life Saving Instructions",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Life Saving Instructions", 5)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Lifetime Guarantees",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Lifetime Guarantees", 5)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Tax Free Savings",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Tax Free Savings", 5)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Reading Club",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Reading Club", 5)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Gas Additives",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Gas Additives", 5)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Vending Machines",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Vending Machines", 5)
            },
			new CashUpgrade<IAdVentureObject>()
			{
                Name = "Only Moisture Sauce",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Only Moisture Sauce", 5)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Hypnotic Jumbotrons",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Hypnotic Jumbotrons", 5)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "More Superheros",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "More Superheros", 5)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Four Score",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Four Score", 4.44444444444444)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Shrimp Consultants",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Shrimp Consultants", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Yes Men",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Yes Men", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Rainbow Suds",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Rainbow Suds", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Tinted Windows",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Tinted Windows", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Cloth Napkins",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Cloth Napkins", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Pay At The Pump",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Pay At The Pump", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Mood Lighting",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Mood Lighting", 2)
            },
			new CashUpgrade<IAdVentureObject>()
			{
                Name = "Fresh Paint",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Fresh Paint", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "24 Hour Channel",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "24 Hour Channel", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Self Serve Butter",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Self Serve Butter", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Oh say, can you 'c'?",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Oh say, can you 'c'?", 2.99792458)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Sustainable Methods",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Sustainable Methods", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Biodegradable Pages",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Biodegradable Pages", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Scan To Pay",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Scan To Pay", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Wheelchair Ramps",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Wheelchair Ramps", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Clean Bathrooms",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Clean Bathrooms", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Smog Recycling",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Smog Recycling", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Memberships",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Memberships", 3)
            },
			new CashUpgrade<IAdVentureObject>()
			{
                Name = "Themed Idle Game",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Themed Idle Game", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Vuvuzelas",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Vuvuzelas", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Partisan Documentaries",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Partisan Documentaries", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Optimize Prime",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Optimize Prime", 2.35711)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "The Great Movie Upgrade",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "The Great Movie Upgrade", 24)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Abacus Upgrades",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Abacus Upgrades", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "The Huge Newspaper Upgrade",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "The Huge Newspaper Upgrade", 22)
            },new CashUpgrade<IAdVentureObject>()
            {
                Name = "Reinvest Profits",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Reinvest Profits", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "The Big Car Wash Upgrade",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "The Big Car Wash Upgrade", 20)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Placate Investors",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Placate Investors", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "The Fat Bank Upgrade",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "The Fat Bank Upgrade", 18)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Market Buzz",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Market Buzz", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "The Giant Shrimp Upgrade",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "The Giant Shrimp Upgrade", 16)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Break The Piggy Bank",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Break The Piggy Bank", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "The Massive Hockey Upgrade",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "The Massive Hockey Upgrade", 14)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Bed Mattress Savings",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Bed Mattress Savings", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "The Vast Oil Upgrade",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "The Vast Oil Upgrade", 12)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Wad Patent",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Wad Patent", 2)
            },
			new CashUpgrade<IAdVentureObject>()
			{
                Name = "The Mega Lemon Upgrade",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "The Mega Lemon Upgrade", 10)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Cornu Copiae",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Cornu Copiae", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "The X Large Pizza Upgrade",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "The X Large Pizza Upgrade", 8)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Fabuluous Fiat",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Fabuluous Fiat", 2)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "The Jumbo Donut Upgrade",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "The Jumbo Donut Upgrade", 4)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Brobdingnagian Upgrade",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Brobdingnagian Upgrade", 9)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "The Final Countdown?",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "The Final Countdown?", 9.87654321)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Cana-dough Exchange",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Cana-dough Exchange", 5)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Diamond Teeth",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Diamond Teeth", 3)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "Discontinue Pennies",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Discontinue Pennies", 4)
            },
			new CashUpgrade<IAdVentureObject>()
            {
                Name = "T-Shirts For All",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "T-Shirts For All", 5)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Wandering Magicians",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Wandering Magicians", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Neato Bike Fleet",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Neato Bike Fleet", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "New Paint Job",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "New Paint Job", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Double Ply Napkins",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Double Ply Napkins", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Swivel Chair",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Swivel Chair", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Trusty Nets",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Trusty Nets", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Skate Sharpeners",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Skate Sharpeners", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Weather Proof Cameras",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Weather Proof Cameras", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Velvety Ropes",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Velvety Ropes", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Tea For Protestors",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Tea For Protestors", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Condensation Supplements",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Condensation Supplements", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "More Ads",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "More Ads", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "A Skyler",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "A Skyler", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "GPS Tracked",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "GPS Tracked", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Gravy Filled",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Gravy Filled", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Superflous Motors",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Superflous Motors", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Anger Injections",
                Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Anger Injections", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Animated Shorts",
                Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Animated Shorts", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Free Calendars",
                Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Free Calendars", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Lobby Hobbys",
                Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Lobby Hobbys", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Chocolate Money",
                Affect = BusinessProfitMultiplier(BusinessTypes.All, "Chocolate Money", 5)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Refrigerated Straws",
                Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Refrigerated Straws", 11)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Aerodynamics Fold",
                Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Aerodynamics Fold", 11)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Can Transform",
                Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Can Transform", 11)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Aerodynamics Crust",
                Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Aerodynamics Crust", 11)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Crispy Protocols",
                Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Crispy Protocols", 11)
            },
            new CashUpgrade<IAdVentureObject>()
            {
                Name = "Blended With Ice",
                Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Blended With Ice", 11)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Simpsons Did It",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Simpsons Did It", 11)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "More Musicals",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "More Musicals", 11)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Scratch N Sniff Notes",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Scratch N Sniff Notes", 11)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Stress Balls",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Stress Balls", 11)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Lemon Scientists",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Lemon Scientists", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Crowd Sourced",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Crowd Sourced", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Soapier Soap",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Soapier Soap", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Show Pony Pepperoni",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Show Pony Pepperoni", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Radical New Slogan",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Radical New Slogan", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Responsibly Sourced",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Responsibly Sourced", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Skull Helmets",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Skull Helmets", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Call In Cumberbatch",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Call In Cumberbatch", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Sassy Clerks",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Sassy Clerks", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Brand Makeover",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Brand Makeover", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Cross The Stream-ables",
	            Affect = BusinessProfitMultiplier(BusinessTypes.All, "Cross The Stream-ables", 5)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Rind Recycling",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Rind Recycling", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Bamboo-based Paper",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Bamboo-based Paper", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Scifi Sound Effects",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Scifi Sound Effects", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Anti-Pizza Roof Sealant",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Anti-Pizza Roof Sealant", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Still More Glaze",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Still More Glaze", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Sailing Lessons",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Sailing Lessons", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Extra Slippery Ice",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Extra Slippery Ice", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Soft Lighting",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Soft Lighting", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Cartoonish Vaults",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Cartoonish Vaults", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Operation Oil-E",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Operation Oil-E", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Lemon Based Cleanse",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Lemon Based Cleanse", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Controversial Headline",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Controversial Headline", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Quick Queues",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Quick Queues", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Asbestos Free",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Asbestos Free", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "10,000 Folds",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "10,000 Folds", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Harpoons",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Harpoons", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Robot Refs",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Robot Refs", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Pretension Dampeners",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Pretension Dampeners", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Evil Busniess Cards",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Evil Busniess Cards", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Helpful Wise Old Guy",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Helpful Wise Old Guy", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Mini Lemons",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Mini Lemons", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Newsworthy Articles",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Newsworthy Articles", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Cafe Expansions",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Cafe Expansions", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Self-Delivering Boxes",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Self-Delivering Boxes", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Ancient Forbidden Recipe",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Ancient Forbidden Recipe", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Mini Jumbo Shrimp",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Mini Jumbo Shrimp", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Better Pads",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Better Pads", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Scheduled Bathroom Breaks",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Scheduled Bathroom Breaks", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "A Website",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "A Website", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Stunt Drivers",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Stunt Drivers", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Reinvest Dividends",
	            Affect = BusinessProfitMultiplier(BusinessTypes.All, "Reinvest Dividends", 5)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Colorful Glasses",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Colorful Glasses", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Cholesterol Free Paper",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Cholesterol Free Paper", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Meteor Proofing",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Meteor Proofing", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Ghost-repellant",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Ghost-repellant", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Diplomatic Immunity",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Diplomatic Immunity", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Flood Insurance",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Flood Insurance", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Free College Tuition",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Free College Tuition", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Coup-Resistant Coating",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Coup-Resistant Coating", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Slot Machine ATMs",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Slot Machine ATMs", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Mega Filters",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Mega Filters", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Genetic Improvements",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Genetic Improvements", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Discover New Markets",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Discover New Markets", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Send Mud Assassins",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Send Mud Assassins", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Hunger Provoking Gas",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Hunger Provoking Gas", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Bacon-Based Super Glaze",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Bacon-Based Super Glaze", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Salt Water Engines",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Salt Water Engines", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Fan Piggy Backs",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Fan Piggy Backs", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Kaiju Chickflicks",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Kaiju Chickflicks", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Receipts",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Receipts", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Really Big Jerry Cans",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Really Big Jerry Cans", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "More Colors",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "More Colors", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Homing Technology",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Homing Technology", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Awe-inspiring Eyebrows",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Awe-inspiring Eyebrows", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Quintuple Meat",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Quintuple Meat", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Donutrition Research",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Donutrition Research", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Pirate-y Accents",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Pirate-y Accents", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Free Punches",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Free Punches", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "More ZomRomComs",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "More ZomRomComs", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Awesome New Stationary",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Awesome New Stationary", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Tycoon-y Executive Suits",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Tycoon-y Executive Suits", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Self-Squeezing GMO",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Self-Squeezing GMO", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Slam Poems",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Slam Poems", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Petting Zoos",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Petting Zoos", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Exotic Moon Ingredients",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Exotic Moon Ingredients", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Smaller Portions",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Smaller Portions", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Adorable Steam Whistles",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Adorable Steam Whistles", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Butt Guards",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Butt Guards", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Super Nice Gofers",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Super Nice Gofers", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Ample Parking",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Ample Parking", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Oil Resistant Monocles",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Oil Resistant Monocles", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "One Workforce. One Uniform.",
	            Affect = BusinessProfitMultiplier(BusinessTypes.All, "One Workforce. One Uniform.", 5)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Gum Applications",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Gum Applications", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Anti-News Papers",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Anti-News Papers", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Manicures While You Wait",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Manicures While You Wait", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Triangle Pizza Discovery",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Triangle Pizza Discovery", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Gluten Free Coffee",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Gluten Free Coffee", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Gentler Methods",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Gentler Methods", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Stirring Simultaneous Debates",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Stirring Simultaneous Debates", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Kale-Based Soft Drinks",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Kale-Based Soft Drinks", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Snooty Glasses",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Snooty Glasses", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Spin Department",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Spin Department", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Bold Health Claims",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Bold Health Claims", 9)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Paper Mache Packs",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Paper Mache Packs", 9)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Catchy Background Music",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Catchy Background Music", 9)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Pizza Singularity",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Pizza Singularity", 9)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "One Stop Shops",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "One Stop Shops", 9)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Bacon/Shrimp Synthesis",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Bacon/Shrimp Synthesis", 9)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "More Jackets For Dawn",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "More Jackets For Dawn", 9)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "DDL vs RDJ: The Movie",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "DDL vs RDJ: The Movie", 9)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Mood Lighting",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Mood Lighting", 9)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Slide-N-Slip Parks",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Slide-N-Slip Parks", 9)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Actual Fortune Cookies",
	            Affect = BusinessProfitMultiplier(BusinessTypes.All, "Actual Fortune Cookies", 2)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Spray-Based Delivery",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Spray-Based Delivery", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Ultra Thin Editions",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Ultra Thin Editions", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Nonjudgemental Scrubbers",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Nonjudgemental Scrubbers", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "9th Dimensional Crusts",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "9th Dimensional Crusts", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Chicken Rings",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Chicken Rings", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Anti-Iceberg Artilery",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Anti-Iceberg Artilery", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Cavier Popcorn",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Cavier Popcorn", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Hilarious Advertisements",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Hilarious Advertisements", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Laser Defense Systems",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Laser Defense Systems", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Cray-Cray Crates",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Cray-Cray Crates", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Lemon Implants",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Lemon Implants", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Reprinting Classic Editions",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Reprinting Classic Editions", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Limited Edition Buckets",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Limited Edition Buckets", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Pizza-Based Drone Tech",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Pizza-Based Drone Tech", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Really Big Sandwiches",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Really Big Sandwiches", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Sea Shanty Record Album",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Sea Shanty Record Album", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Hocky-Talkies",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Hocky-Talkies", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Isotope-Free Butter",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Isotope-Free Butter", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Potted Flowers",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Potted Flowers", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Anti-Residue Everything",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Anti-Residue Everything", 3)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Deregulation",
	            Affect = BusinessProfitMultiplier(BusinessTypes.All, "Deregulation", 5)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Squeeze Out Competition",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Lemon, "Squeeze Out Competition", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Copyright 'News'",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Copyright 'News'", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Patent 'Washing'",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Patent 'Washing'", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Brand 'Pizza'",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Brand 'Pizza'", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Monopolize Sugar",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Monopolize Sugar", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Impose Sanctions",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Impose Sanctions", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Secure Broadcasting Rights",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Secure Broadcasting Rights", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Condemn Pirates",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Condemn Pirates", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Print All Currency",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Print All Currency", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Trademark Oil",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Trademark Oil", 7)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Write News Personally",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Newspaper, "Write News Personally", 13)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Wash Cars Personally",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Car, "Wash Cars Personally", 13)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Deliver Pizza Personally",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Pizza, "Deliver Pizza Personally", 13)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Makes Donuts Personally",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Donut, "Makes Donuts Personally", 13)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Catch Shrimp Personally",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Shrimp, "Catch Shrimp Personally", 13)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Play Hockey Personally",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Hockey, "Play Hockey Personally", 13)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Direct Movies Personally",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Movie, "Direct Movies Personally", 13)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Count Money Personally",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Bank, "Count Money Personally", 13)
            },
            new CashUpgrade<IAdVentureObject>()
            {
	            Name = "Drill Oil Personally",
	            Affect = BusinessProfitMultiplier(BusinessTypes.Oil, "Drill Oil Personally", 13)
            }
        });

        #endregion Cash Upgrades

        #endregion Initializer

        private static Func<UpgradeObject<IAdVentureObject>, IAdVentureObject, IAdVentureObject> AngelInvestorEffectiveness(double effectivenessIncrease)
        {
            return new Func<UpgradeObject<IAdVentureObject>, IAdVentureObject, IAdVentureObject>((uo, o) =>
            {
                AngelInvestor ai = o as AngelInvestor;

                if (ai == null)
                    return o;

                if (uo.IsActive)
                    ai.Effectiveness += effectivenessIncrease;
                else
                    ai.Effectiveness -= effectivenessIncrease;

                return ai;
            });
        }

        private static Func<UpgradeObject<IAdVentureObject>, IAdVentureObject, IAdVentureObject> BusinessFreeLevel(BusinessTypes businessType, string affectName, int freeLevelUpgrade)
        {
            return new Func<UpgradeObject<IAdVentureObject>, IAdVentureObject, IAdVentureObject>((uo, o) =>
            {
                Business b = o as Business;

                if (b == null)
                    return o;

                if (b.Type == businessType || businessType == BusinessTypes.All)
                    if (uo.IsActive)
                        b.AddFreeLevel(affectName, (i) => i + freeLevelUpgrade);
                    else
                        b.RemoveFreeLevel(affectName);

                return b;
            });
        }

        private static Func<UpgradeObject<IAdVentureObject>, IAdVentureObject, IAdVentureObject> BusinessProfitMultiplier(BusinessTypes businessType, string affectName, double profitMultiplier)
        {
            return new Func<UpgradeObject<IAdVentureObject>, IAdVentureObject, IAdVentureObject>((uo, o) =>
            {
                Business b = o as Business;

                if (b == null)
                    return o;

                if (b.Type == businessType || businessType == BusinessTypes.All)
                    if (uo.IsActive)
                        b.Profit.Add(affectName, (i) => i * profitMultiplier);
                    else
                        b.Profit.Remove(affectName);

                return b;
            });
        }
    }
}