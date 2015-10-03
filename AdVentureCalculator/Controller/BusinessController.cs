using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using AdVentureCalculator.Model;

namespace AdVentureCalculator.Controller
{
    public static class BusinessController
    {
        #region Initializer

        public static List<Business> Businesses = new List<Business>(new Business[]
        {
	        new Business()
	        {
		        Type = BusinessTypes.Lemon,
                Planet = Planets.Earth,
		        Cooldown = new FunctionChainer<double>(0.6, new Dictionary<string,Func<double,double>>()
		        {
			        {"Easy Squeezy", SingleBusinessCooldownUnlock(BusinessTypes.Lemon, 25)},
			        {"Thirst Quencher", SingleBusinessCooldownUnlock(BusinessTypes.Lemon, 50)},
			        {"Lemon Lord", SingleBusinessCooldownUnlock(BusinessTypes.Lemon, 100)},
			        {"Citrus Emperor", SingleBusinessCooldownUnlock(BusinessTypes.Lemon, 200)},
			        {"The Zestiest", SingleBusinessCooldownUnlock(BusinessTypes.Lemon, 300)},
			        {"Lemontopia", SingleBusinessCooldownUnlock(BusinessTypes.Lemon, 400)}
		        }),
		        Cost = 4,
		        Profit = new FunctionChainer<double>(1, new Dictionary<string,Func<double,double>>()
                {
                    {"BaseProfitMultiplier", BaseProfitMultiplier(BusinessTypes.Lemon)},
                    {"AngelInvestorEffectiveness", AngelInvestorProfitMultiplier(BusinessTypes.Lemon)},

                    {"Acceptable", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 500, 4)},
                    {"Lemon Based Economy", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 600, 4)},
                    {"Lemon Religion", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 700, 4)},
                    {"Lemondammerung", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 800, 4)},
                    {"LemoNirvana", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 900, 4)},
                    {"Operating Lemon VIII", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 1000, 5)},
                    {"Lemogeddon", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 1100, 4)},
                    {"Lemonarok", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 1200, 4)},
                    {"Citrus Of The 7 Suns", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 1300, 4)},
                    {"Lemonokereti", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 1400, 4)},
                    {"The 2nd Squeezing", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 1500, 4)},
                    {"Lemonlightenment", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 1600, 4)},
                    {"The Lemonhead", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 1700, 4)},
                    {"Lemons All The Way", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 1800, 4)},
                    {"End Of Thirst", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 1900, 4)},
                    {"IMPOSSIBREW", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 2000, 5)},
                    {"Aromatherapy", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 2250, 2)},
                    {"iLemon Launch", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 2500, 2)},
                    {"Vitamin Sea", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 2750, 2)},
                    {"Green Lemons", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 3000, 5)},
                    {"Rind-alot", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 3250, 2)},
                    {"Seed Money", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 3500, 2)},
                    {"Case Of The Lemondays", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 3750, 2)},
                    {"Scurvy Savior", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 4000, 5)},
                    {"Lemon Batteries", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 4250, 2)},
                    {"Free Tequila", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 4500, 2)},
                    {"Beverage Of Champions", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 4750, 2)},
                    {"Drink Up", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 5000, 5)},
                    {"Not A Problem", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 5250, 3)},
                    {"Deficitrus", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 5500, 3)},
                    {"Long Live The Lemonarch", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 5750, 3)},
                    {"Shining Emblemon", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 6000, 5)},
                    {"The Lemonolith", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 6250, 3)},
                    {"Lemonocle", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 6500, 3)},
                    {"Very A-peeling", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 6750, 3)},
                    {"King SoLemon", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 7000, 5)},
                    {"Seedless Wonder", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 7000, 3)},
					{"Lifts Stains", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 7250, 3)},
					{"Lemonopoly", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 7500, 3)},
					{"Lucky Lemons", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 7777, 3)},
					{"Lemonstrous Heights", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 8000, 3)},
					{"You're Lemongst Friends", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 8200, 3)},
					{"Lemonotony", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 8400, 3)},
					{"Metaxylemonic Research", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 8600, 3)},
					{"Parabolemon Equations", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 8800, 3)},
					{"Precious...", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 9000, 3)},
					{"Once More To The Juicer", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 9100, 3)},
					{"Main Squeeze", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 9200, 3)},
					{"Endless Demand", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 9300, 3)},
					{"Luck Be A Lemon", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 9400, 3)},
					{"The Lemoning", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 9500, 3)},
					{"Lemonlemonlemonlemonlemon", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 9600, 3)},
					{"Lemonocolor Reality", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 9700, 3)},
					{"Lemoney", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 9800, 3)},
					{"The Penultimate Moment", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 9999, 1.9999)},
					{"Life's Manager", BusinessProfitMultiplierUnlock(BusinessTypes.Lemon, 10000, 5)},



                    // Newspaper Affect
                    {"Lemonade Ads", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 125, 2)},
                    {"Lemonade Coupons", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 250, 3)},
                    {"Lemon Scented", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 375, 4)},
                    {"Lemonade Samples", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 525, 5)},
                    {"Lemon Sudoku", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 650, 6)},
                    {"Lemon Propaganda", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 775, 3)},
                    {"Lemon Bribes", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1350, 9)},
                    {"Pulitzer Lemon Article", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 2900, 15)},
					{"...So Long Ago...", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 4100, 30)}

                }),
		        FreeLevel = 1,
                MaxLevel = 10000,
		        Modifier = 1.07
	        },
	        new Business()
	        {
		        Type = BusinessTypes.Newspaper,
                Planet = Planets.Earth,
		        Cooldown = new FunctionChainer<double>(3, new Dictionary<string,Func<double,double>>()
		        {
			        {"Extra Extra!", SingleBusinessCooldownUnlock(BusinessTypes.Newspaper, 25)},
			        {"Read All About It", SingleBusinessCooldownUnlock(BusinessTypes.Newspaper, 50)},
			        {"Daily Deliveries", SingleBusinessCooldownUnlock(BusinessTypes.Newspaper, 100)},
			        {"Digital Digest", SingleBusinessCooldownUnlock(BusinessTypes.Newspaper, 200)},
			        {"Telepathic News", SingleBusinessCooldownUnlock(BusinessTypes.Newspaper, 300)},
			        {"News FROM THE FUTURE", SingleBusinessCooldownUnlock(BusinessTypes.Newspaper, 400)}
		        }),
		        Cost = 60,
                Profit = new FunctionChainer<double>(60, new Dictionary<string,Func<double,double>>()
                {
                    {"BaseProfitMultiplier", BaseProfitMultiplier(BusinessTypes.Newspaper)},
                    {"AngelInvestorEffectiveness", AngelInvestorProfitMultiplier(BusinessTypes.Newspaper)},

                    // Newspaper Affect
                    {"Hire 1000 Newspaper Delivery", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1000, 7777777)},
                    {"Internet Integration", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1300, 7777)},
                    {"Printer Ink Discount", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 2000, 7777)},
                    {"New Gnu Knews News", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 2500, 777)},
                    {"Recursion", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 3000, 777)},
                    {"That Old Chestnut", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 3500, 777)},
                    {"Do You Remember...", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 4000, 30)},
					{"x50", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 5000, 50)},
					{"x50 Again", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 5100, 50)},
					{"x50 Yet Again", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 5200, 50)},
					{"x50 For Good Measure", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 5300, 50)},
					{"The Rest Is Silence", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 5400, 50)}

                }),
                MaxLevel = 5400,
		        Modifier = 1.15
	        },
	        new Business()
	        {
		        Type = BusinessTypes.Car,
                Planet = Planets.Earth,
		        Cooldown = new FunctionChainer<double>(6, new Dictionary<string,Func<double,double>>()
		        {
			        {"Working At The Carwash", SingleBusinessCooldownUnlock(BusinessTypes.Car, 25)},
			        {"Wash And Wax", SingleBusinessCooldownUnlock(BusinessTypes.Car, 50)},
			        {"Supreme Service", SingleBusinessCooldownUnlock(BusinessTypes.Car, 100)},
			        {"Diamond Sealed", SingleBusinessCooldownUnlock(BusinessTypes.Car, 200)},
			        {"Infinite Clean", SingleBusinessCooldownUnlock(BusinessTypes.Car, 300)},
			        {"Artificially Intelligent Suds", SingleBusinessCooldownUnlock(BusinessTypes.Car, 400)}
		        }),
		        Cost = 720,
                Profit = new FunctionChainer<double>(540, new Dictionary<string,Func<double,double>>()
                {
                    {"BaseProfitMultiplier", BaseProfitMultiplier(BusinessTypes.Car)},
                    {"AngelInvestorEffectiveness", AngelInvestorProfitMultiplier(BusinessTypes.Car)},

                    {"Grey Goo Detergent", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 500, 2)},
                    {"Downloadable Wash", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 600, 2)},
                    {"Stronger Than Dirt", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 700, 2)},
                    {"Free Car With Purchase", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 800, 2)},
                    {"When You Wash Upon A Star", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 900, 2)},
                    {"On Every Corner", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 1000, 3)},
                    {"Planet Saturation", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 1100, 2)},
                    {"Horses Too", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 1200, 2)},
                    {"Home Installations", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 1300, 2)},
                    {"Car Mounted Washers", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 1400, 2)},
                    {"Bubbles!", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 1500, 2)},
                    {"Are You Reading These?", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 1600, 2)},
                    {"Self Washing Cars", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 1700, 2)},
                    {"Temporal Pre-Wash", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 1800, 2)},
                    {"Wax On Wax Off", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 1900, 2)},
                    {"Everything Is Clean", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 2000, 5)},
                    {"Free Gold Plating", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 2100, 3)},
                    {"Rim Shiners", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 2200, 3)},
                    {"Cash Launder-ing", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 2300, 3)},
                    {"Hamster Powered", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 2400, 3)},
                    {"Self Service", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 2500, 3)},
                    {"The Bogdan Effect", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 2600, 3)},
                    {"Malamine Foam!", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 2700, 3)},
                    {"No Bug Guts", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 2800, 3)},
                    {"Garden Hose Discount", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 2900, 3)},
                    {"Probably Too Many", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 3000, 3)},
                    {"The Car-tel", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 3100, 3)},
                    {"SCRUB", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 3200, 3)},
                    {"Supplies!", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 3300, 3)},
                    {"George Wash-ington Sale", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 3400, 3)},
                    {"Nearly Done", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 3500, 3)},
                    {"Car Wash Washers", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 3600, 3)},
                    {"Car Wash Washer Washers", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 3700, 3)},
                    {"Dance Parties", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 3800, 3)},
                    {"Carpool Discounts", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 3900, 3)},
                    {"Convertible Friendly", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 4000, 5)},
                    {"Scrub Harder", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 4100, 3)},
					{"Shares Are Up", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 4200, 3)},
					{"Clean Capitalism", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 4300, 3)},
					{"Demand Continues", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 4400, 3)},
					{"The Freshest", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 4500, 3)},
					{"Lean, Mean, Clean", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 4600, 3)},
					{"7 Second Suds", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 4700, 3)},
					{"But Wait There's More", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 4800, 3)},
					{"Really? More?", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 4900, 3)},
					{"All The Suds", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 5000, 5)},
					{"Probably Overkill", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 5250, 3)},
					{"Pristine", BusinessProfitMultiplierUnlock(BusinessTypes.Car, 5500, 3)},

                    // Newspaper Affect
                    {"Car Wash Ads", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 150, 2)},
                    {"Car Wash Coupons", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 275, 3)},
                    {"New Car Scented", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 425, 4)},
                    {"Soap Samples", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 550, 5)},
                    {"Car Word Search", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 675, 6)},
                    {"Car Wash Propaganda", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 825, 7)},
                    {"Page 3 Ads", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1075, 8)},
                    {"Car Wash Bribes", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1400, 9)},
                    {"Car Wash Applications", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 2100, 15)},
                    {"24 Hour Car News", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 3100, 20)},
					{"...When Newspapers...", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 4200, 30)}
                }),
                MaxLevel = 5500,
		        Modifier = 1.14
	        },
	        new Business()
	        {
		        Type = BusinessTypes.Pizza,
                Planet = Planets.Earth,
		        Cooldown = new FunctionChainer<double>(12, new Dictionary<string,Func<double,double>>()
		        {
			        {"30 Min or Less", SingleBusinessCooldownUnlock(BusinessTypes.Pizza, 25)},
			        {"Fancy Toppings", SingleBusinessCooldownUnlock(BusinessTypes.Pizza, 50)},
			        {"Gourmet Crust", SingleBusinessCooldownUnlock(BusinessTypes.Pizza, 100)},
			        {"Free Cheese Bread", SingleBusinessCooldownUnlock(BusinessTypes.Pizza, 200)},
			        {"Home Rehydrator", SingleBusinessCooldownUnlock(BusinessTypes.Pizza, 300)},
			        {"Intravenous Cheese", SingleBusinessCooldownUnlock(BusinessTypes.Pizza, 400)}
		        }),
		        Cost = 8640,
                Profit = new FunctionChainer<double>(4320, new Dictionary<string,Func<double,double>>()
                {
                    {"BaseProfitMultiplier", BaseProfitMultiplier(BusinessTypes.Pizza)},
                    {"AngelInvestorEffectiveness", AngelInvestorProfitMultiplier(BusinessTypes.Pizza)},

                    {"Everlasting Pepperoni", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 500, 2)},
                    {"Pizza Stuffed Pizza", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 600, 2)},
                    {"Calzone Breakthrough", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 700, 2)},
                    {"Self Microwaving", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 800, 2)},
                    {"One With Everything", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 900, 2)},
                    {"It Smells Like Pizza", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 1000, 3)},
                    {"That’s Amore", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 1100, 2)},
                    {"Over 1 Decillion Served", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 1200, 2)},
                    {"Wibbly Wobbly Deliveries", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 1300, 2)},
                    {"Deep Dish Discovery", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 1400, 2)},
                    {"Pizza Cluster Bombs", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 1500, 2)},
                    {"Pizza Putt!", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 1600, 2)},
                    {"New Cheese Sources", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 1700, 2)},
                    {"Pizza Roll Call Centers", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 1800, 2)},
                    {"Unobtanium Crust", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 1900, 2)},
                    {"The Pie In The Sky", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 2000, 5)},
                    {"Pizza Saline Dip", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 2100, 3)},
                    {"Pizza Squared", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 2200, 3)},
                    {"Chow-abunga", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 2300, 3)},
                    {"Counts As Vegetable", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 2400, 3)},
                    {"More Like Pizza-What", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 2500, 3)},
                    {"Cold Pizza", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 2600, 3)},
                    {"Chain of Chains", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 2700, 3)},
                    {"Pizza Holiday Declared", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 2800, 3)},
                    {"Pizza Planescape", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 2900, 3)},
                    {"I Am Pizza", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 3000, 3)},
                    {"Entangled Two For 1", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 3100, 3)},
                    {"Hand Tossed Employees", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 3200, 3)},
                    {"Romantic Dinner", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 3300, 3)},
                    {"Vegan Options", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 3400, 3)},
                    {"Cake Flavored Pizza", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 3500, 3)},
                    {"Pizza Flavored Cake", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 3600, 3)},
                    {"Witty Achievement Text", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 3700, 3)},
                    {"Deliver Us", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 3800, 5)},
                    {"Free Wings", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 3900, 3)},
                    {"Unlimited Toppings", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 4000, 5)},
                    {"Causality Crust", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 4100, 3)},
                    {"Stand And Deliver", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 4200, 3)},
					{"It IS Delivery", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 4300, 3)},
					{"Pizzanity", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 4400, 3)},
					{"By The Slice", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 4500, 3)},
					{"Large Hadron Crust-ollider", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 4600, 3)},
					{"Cold", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 4700, 3)},
					{"Origami Boxes", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 4800, 3)},
					{"Free Croutons", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 4900, 3)},
					{"Fancy Napkins", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 5000, 5)},
					{"Always Room", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 5250, 3)},
					{"Hamburgers, Anyone?", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 5500, 3)},
					{"Thus Spoke Pizzarathustra", BusinessProfitMultiplierUnlock(BusinessTypes.Pizza, 5750, 3)},

                    // Newspaper Affect
                    {"Pizza Ads", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 175, 2)},
                    {"Pizza Coupons", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 325, 3)},
                    {"Pizza Scented", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 450, 4)},
                    {"Pizza Samples", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 575, 5)},
                    {"Pizza Crossword", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 725, 6)},
                    {"Pizza Propaganda", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 850, 7)},
                    {"Edible Ads", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1100, 8)},
                    {"Pizza Bribes", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1450, 9)},
                    {"Pizza Poetry", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 2200, 15)},
					{"...Were Worthless?", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 4300, 30)}
                }),
                MaxLevel = 5750,
		        Modifier = 1.13
	        },
	        new Business()
	        {
		        Type = BusinessTypes.Donut,
                Planet = Planets.Earth,
		        Cooldown = new FunctionChainer<double>(24, new Dictionary<string,Func<double,double>>()
		        {
			        {"Lots of Dough", SingleBusinessCooldownUnlock(BusinessTypes.Donut, 25)},
			        {"Extra Sprinkles", SingleBusinessCooldownUnlock(BusinessTypes.Donut, 50)},
			        {"Deep Fried", SingleBusinessCooldownUnlock(BusinessTypes.Donut, 100)},
			        {"Donut Filled Donuts", SingleBusinessCooldownUnlock(BusinessTypes.Donut, 200)},
			        {"Doughnut Shaped Universe", SingleBusinessCooldownUnlock(BusinessTypes.Donut, 300)},
			        {"Unified Donut Theory", SingleBusinessCooldownUnlock(BusinessTypes.Donut, 400)}
		        }),
		        Cost = 103680,
                Profit = new FunctionChainer<double>(51840, new Dictionary<string,Func<double,double>>()
                {
                    {"BaseProfitMultiplier", BaseProfitMultiplier(BusinessTypes.Donut)},
                    {"AngelInvestorEffectiveness", AngelInvestorProfitMultiplier(BusinessTypes.Donut)},

                    {"Final Donut", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 500, 2)},
					{"Donut Flavored Coffee", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 600, 2)},
					{"Golden Glaze", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 700, 2)},
					{"Guaranteed Minimal Donuts", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 800, 2)},
					{"Roll Up The Outer Rim", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 900, 2)},
					{"Wireless Donuts", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 1000, 3)},
					{"Got Donuts?", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 1100, 2)},
					{"Long John Long Johns", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 1200, 2)},
					{"Reality DonuTV", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 1300, 2)},
					{"Donut Addiction Hotlines", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 1400, 2)},
					{"Donuts Safe Houses", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 1500, 2)},
					{"Regenerating Donuts", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 1600, 2)},
					{"Heat Seaking Pastries", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 1700, 2)},
					{"Submit", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 1800, 2)},
					{"The Donutrix", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 1900, 2)},
					{"Then Who Was Donut?", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 2000, 5)},
					{"Pumpkin Flavored", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 2100, 3)},
					{"Strangely Popular", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 2200, 3)},
					{"Self Dunking", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 2300, 3)},
					{"Double Rainbow Sprinkles!", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 2400, 3)},
					{"Edible Receipts", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 2500, 3)},
					{"Dough-Cubes", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 2600, 3)},
					{"Fifth Dimension Frosting", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 2700, 3)},
					{"The Adar Standard", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 2800, 3)},
					{"Donut Don’t it?", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 2900, 3)},
					{"Temperance Solvent", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 3000, 3)},
					{"Build Your Own", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 3100, 3)},
					{"Cream Cheese Based", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 3200, 3)},
					{"Gone Viral?", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 3300, 3)},
					{"Chicken Options", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 3400, 3)},
					{"0 Calories", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 3500, 3)},
					{"Donut Booths", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 3600, 3)},
					{"Liquid Donuts", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 3700, 3)},
					{"Sassy Chefs", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 3800, 3)},
					{"Everyone Knows Your Name", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 3900, 3)},
					{"Cookies Too", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 4000, 3)},
					{"Gold Leaf Sprinkles", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 4100, 3)},
					{"The Only Food Group", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 4200, 3)},
					{"Innuendonut", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 4300, 3)},
					{"Tae Kwon Donut", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 4400, 3)},
                    {"5th Dimension Donuts", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 4500, 3)},
					{"Creme Filled Filled", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 4750, 3)},
					{"Basically Sugar", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 5000, 3)},
					{"Gluten Free Water", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 5250, 3)},
					{"Vacuum Sealed", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 5500, 3)},
					{"Hasty Pastry", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 5750, 3)},
					{"6000 Is A Lot", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 6000, 3)},
					{"Philosophiae Donutus Principia", BusinessProfitMultiplierUnlock(BusinessTypes.Donut, 6250, 3)},

                    // Newspaper Affect
                    {"Donut Ads", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 225, 2)},
                    {"Donut Coupons", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 350, 3)},
                    {"Donut Scented", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 475, 4)},
                    {"Donut Samples", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 625, 5)},
                    {"Donut Horoscope", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 750, 6)},
                    {"Donut Propaganda", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 875, 7)},
                    {"Honey Glazed Ads", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1125, 8)},
                    {"Donut Bribes", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1500, 9)},
                    {"Donutopia", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 2300, 15)},
					{"Those Days Are Long Past...", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 4400, 30)}
                }),
                MaxLevel = 6250,
		        Modifier = 1.12
	        },
	        new Business()
	        {
		        Type = BusinessTypes.Shrimp,
                Planet = Planets.Earth,
		        Cooldown = new FunctionChainer<double>(96, new Dictionary<string,Func<double,double>>()
		        {
			        {"Wanna Buy A Shrimp Boat?", SingleBusinessCooldownUnlock(BusinessTypes.Shrimp, 25)},
			        {"Surf and Turf", SingleBusinessCooldownUnlock(BusinessTypes.Shrimp, 50)},
			        {"Gumbo King", SingleBusinessCooldownUnlock(BusinessTypes.Shrimp, 100)},
			        {"Gigantic Shrimp", SingleBusinessCooldownUnlock(BusinessTypes.Shrimp, 200)},
			        {"Galactic Fleet", SingleBusinessCooldownUnlock(BusinessTypes.Shrimp, 300)},
			        {"Celestial Shrimp", SingleBusinessCooldownUnlock(BusinessTypes.Shrimp, 400)}
		        }),
		        Cost = 1244160,
                Profit = new FunctionChainer<double>(622080, new Dictionary<string,Func<double,double>>()
                {
                    {"BaseProfitMultiplier", BaseProfitMultiplier(BusinessTypes.Shrimp)},
                    {"AngelInvestorEffectiveness", AngelInvestorProfitMultiplier(BusinessTypes.Shrimp)},

                    {"Cosmic Grill", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 500, 2)},
					{"Black Hole Trolling", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 600, 2)},
					{"The Shrimpularity", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 700, 2)},
					{"All You Can Eat (Achievement)", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 800, 2)},
					{"Shrimpocalypse", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 900, 2)},
					{"Shellfish Selfish", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 1000, 3)},
					{"Prawns Are Good Too", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 1100, 2)},
					{"Begun The Shrimp Wars Have", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 1200, 2)},
					{"Gumbo’s Rebellion", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 1300, 2)},
					{"King in The North Sea", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 1400, 2)},
					{"Crustacean Uprising", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 1500, 2)},
					{"Nuclear Shish Kabobs", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 1600, 2)},
					{"The Blackwater BBQ", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 1700, 2)},
					{"Battle of The Bilge", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 1800, 2)},
					{"Lobster Betrayal!", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 1900, 2)},
					{"The Red Wetting", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 2000, 5)},
					{"Butter", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 2100, 3)},
					{"The Spice Flows", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 2200, 3)},
					{"Mermaid-Safe Nets", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 2300, 3)},
					{"Room On The Barbie", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 2400, 3)},
					{"All In The De-tails", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 2500, 3)},
					{"Miniature Jumbo Shrimp", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 2600, 3)},
					{"Darling It’s Better", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 2700, 3)},
					{"A Nice Chianti", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 2800, 3)},
					{"Shrimpulse", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 2900, 3)},
					{"Hungry?", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 3000, 3)},
					{"Shrimp-Based Fashions", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 3250, 5)},
					{"Shrimpshrimpshrimpshrimp", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 3500, 5)},
					{"Never Gets Old", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 3750, 3)},
					{"A Complete Breakfast", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 4000, 5)},
					{"What Is Even Happening", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 4250, 3)},
					{"No", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 4500, 5)},
                    {"Stroke!", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 4750, 3)},
					{"Off The Port Bow", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 5000, 5)},
					{"Just Keep Shrimping", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 5250, 3)},
					{"Snap To It", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 5500, 3)},
					{"Butter Prices Soar", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 5750, 3)},
					{"The Meaning Of Garlic", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 6000, 5)},
					{"From Heck's Heart...", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 6250, 3)},
					{"...I Skewer Thee!", BusinessProfitMultiplierUnlock(BusinessTypes.Shrimp, 6500, 5)},

                    // Newspaper Affect
                    {"Subliminal Shrimp", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 500,11)},
                    {"Shrimp Reminder", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 925, 7)},
                    {"Cocktail Sauced Ads", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1150, 8)},
                    {"Shrimp Bribes", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1550, 9)},
                    {"Eat Shrimp Or Else", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1800, 10)},
                    {"Paper Pirate Hats", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 2400, 15)},
					{"...And Though It Is Strange...", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 4500, 30)}
                }),
                MaxLevel = 6500,
		        Modifier = 1.11
	        },
	        new Business()
	        {
		        Type = BusinessTypes.Hockey,
                Planet = Planets.Earth,
		        Cooldown = new FunctionChainer<double>(384, new Dictionary<string,Func<double,double>>()
		        {
			        {"Underdogs", SingleBusinessCooldownUnlock(BusinessTypes.Hockey, 25)},
			        {"Division Champs", SingleBusinessCooldownUnlock(BusinessTypes.Hockey, 50)},
			        {"All Stars", SingleBusinessCooldownUnlock(BusinessTypes.Hockey, 100)},
			        {"Hall of Fame", SingleBusinessCooldownUnlock(BusinessTypes.Hockey, 200)},
			        {"The Great ones", SingleBusinessCooldownUnlock(BusinessTypes.Hockey, 300)},
			        {"Dream Team", SingleBusinessCooldownUnlock(BusinessTypes.Hockey, 400)},
			        {"Competent Refs", SingleBusinessCooldownUnlock(BusinessTypes.Hockey, 2100)},
			        {"Either Orr", SingleBusinessCooldownUnlock(BusinessTypes.Hockey, 2300)},
			        {"Puck Injections", SingleBusinessCooldownUnlock(BusinessTypes.Hockey, 2500)},
			        {"Knucklepuck", SingleBusinessCooldownUnlock(BusinessTypes.Hockey, 2700)}
		        }),
		        Cost = 14929920,
                Profit = new FunctionChainer<double>(7464960, new Dictionary<string,Func<double,double>>()
                {
                    {"BaseProfitMultiplier", BaseProfitMultiplier(BusinessTypes.Hockey)},
                    {"AngelInvestorEffectiveness", AngelInvestorProfitMultiplier(BusinessTypes.Hockey)},

                    {"Perfect Puck", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 500, 2)},
					{"Robot Players", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 600, 2)},
					{"Intergalactic League", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 700, 2)},
					{"Yeah. More Hockey.", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 800, 2)},
					{"Sudden Death", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 900, 2)},
					{"Leagues Of Leagues", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 1000, 3)},
					{"Daily Game 7", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 1100, 2)},
					{"Player Cloning Factories", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 1200, 2)},
					{"Explosive Pucks", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 1300, 2)},
					{"The Refs ARE Blind", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 1400, 2)},
					{"Rocket Skates", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 1500, 2)},
					{"Release The Lions!", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 1600, 2)},
					{"Release The Robo-Lions!!", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 1700, 2)},
					{"Play For Food", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 1800, 2)},
					{"The Hungry Games", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 1900, 2)},
					{"Almost As Big As Football", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 2000, 5)},
					{"Extra Loud Sirens", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 2200, 3)},
					{"Super Bash Bros.", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 2400, 3)},
					{"Artificial Ice", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 2600, 3)},
					{"Cutting Edge Effect", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 2800, 3)},
					{"Flying W", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 2900, 3)},
					{"Everyone’s Crosby", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 3000, 3)},
					{"Miracle On Ice", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 3250, 3)},
					{"Honorary Canadian", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 3500, 3)},
					{"Helmet Shortages", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 3750, 3)},
					{"Puck Is A 4 Letter Word", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 4000, 5)},
					{"Face On Face Off", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 4250, 3)},
					{"Game On!", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 4500, 3)},
					{"Double Decker Rinks", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 4750, 3)},
                    {"Game On And On And On", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 5000, 7)},
					{"Boom Boom Clap", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 5250, 3)},
					{"Fight Night", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 5500, 3)},
					{"Icing On The Cake", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 5750, 3)},
					{"Do The Wave", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 6000, 7)},
					{"Slap Shotgun", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 6250, 3)},
					{"Be The Puck", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 6500, 3)},
					{"A Sea Of Jerseys", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 6750, 3)},
					{"Hockey Is Pretty Cool", BusinessProfitMultiplierUnlock(BusinessTypes.Hockey, 7000, 7)},

                    // Newspaper Affect
                    {"Such Hockey", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 600, 11)},
                    {"Origami Puck", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 950, 7)},
                    {"Beer Soaked Ads", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1175, 8)},
                    {"Hockey Bribes", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1600, 9)},
                    {"Watch Hockey Or Pay", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1850, 10)},
                    {"Insightful Commentary", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 3200, 20)},
                    {"Puck Scandal", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 3600, 25)},
					{"...I'm Sure You'd Agree...", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 4600, 30)}
                }),
                MaxLevel = 7000,
		        Modifier = 1.1
	        },
	        new Business()
	        {
		        Type = BusinessTypes.Movie,
                Planet = Planets.Earth,
		        Cooldown = new FunctionChainer<double>(1536, new Dictionary<string,Func<double,double>>()
		        {
			        {"Lights!", SingleBusinessCooldownUnlock(BusinessTypes.Movie, 25)},
			        {"Camera!", SingleBusinessCooldownUnlock(BusinessTypes.Movie, 50)},
			        {"Action!", SingleBusinessCooldownUnlock(BusinessTypes.Movie, 100)},
			        {"Blockbuster!", SingleBusinessCooldownUnlock(BusinessTypes.Movie, 200)},
			        {"Statuette Sweeper!", SingleBusinessCooldownUnlock(BusinessTypes.Movie, 300)},
			        {"Library Of Congress", SingleBusinessCooldownUnlock(BusinessTypes.Movie, 400)},
			        {"Eye-Max", SingleBusinessCooldownUnlock(BusinessTypes.Movie, 2100)},
			        {"98 Hour Award Show", SingleBusinessCooldownUnlock(BusinessTypes.Movie, 2300)},
			        {"Privacy Domes", SingleBusinessCooldownUnlock(BusinessTypes.Movie, 2500)},
			        {"Bad Movie Executions", SingleBusinessCooldownUnlock(BusinessTypes.Movie, 2700)},
			        {"Physical Props", SingleBusinessCooldownUnlock(BusinessTypes.Movie, 3250)}
		        }),
		        Cost = 179159040,
                Profit = new FunctionChainer<double>(89579520, new Dictionary<string,Func<double,double>>()
                {
                    {"BaseProfitMultiplier", BaseProfitMultiplier(BusinessTypes.Movie)},
                    {"AngelInvestorEffectiveness", AngelInvestorProfitMultiplier(BusinessTypes.Movie)},

                    {"Cultural Masterpiece", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 500, 2)},
					{"Cult Following", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 600, 2)},
					{"Holodeck Tech", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 700, 2)},
					{"Dream-To-Screen Implants", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 800, 2)},
					{"Rosebud...", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 900, 2)},
					{"Wizard Vampire Decalogy", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 1000, 3)},
					{"The Cinema Constant", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 1100, 2)},
					{"$0.99 Admission", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 1200, 2)},
					{"Crossover Cornucopia", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 1300, 2)},
					{"Inconsiderate Patron Muted", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 1400, 2)},
					{"Wake Up...", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 1500, 2)},
					{"This Game Has You...", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 1600, 2)},
					{"But It’s No Game...", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 1700, 2)},
					{"It’s A SPACE STATION!", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 1800, 2)},
					{"Free Popcorn!", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 1900, 2)},
					{"Pax Hollywooda", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 2000, 5)},
					{"Glasses Free 4D", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 2200, 2)},
					{"Feature Length Trailer", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 2400, 2)},
					{"Director’s Cutlass", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 2600, 2)},
					{"Critical Hit!", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 2800, 2)},
					{"Choose Your Own Ending", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 2900, 2)},
					{"Nothing Sucks", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 3000, 2)},
					{"Kibrick Clones", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 3500, 2)},
					{"Make-A-Movie Booths", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 3750, 2)},
					{"Under Budget", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 4000, 2)},
					{"Film Renaissance", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 4250, 3)},
					{"Here’s Looking At You", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 4500, 3)},
					{"It Was The Sled", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 4750, 3)},
					{"Show Me The Money", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 5000, 5)},
					{"Daisy... Daisy...", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 5250, 3)},
                    {"Greenlit", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 5500, 3)},
					{"104% Rating", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 5750, 3)},
					{"Skyward Thumbs", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 6000, 9)},
					{"Triple Triple Triple Threat", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 6250, 3)},
					{"Max-I-Max-Ium", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 6500, 3)},
					{"Toast", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 6750, 3)},
					{"Tinsel Megapolis", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 7000, 9)},
					{"Industry Jargon", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 7250, 3)},
					{"Alan Smithee Award", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 7500, 3)},
					{"That's Show Biz", BusinessProfitMultiplierUnlock(BusinessTypes.Movie, 7750, 3)},

                    // Newspaper Affect
                    {"Mandatory Viewing", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 700, 11)},
                    {"Spoiler Free World", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 975, 7)},
                    {"Talkie Ads", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1200, 8)},
                    {"Movie Bribes", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1650, 9)},
                    {"Go To Movies or Perish", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1900, 10)},
                    {"Embedded Movies", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 2600, 15)},
                    {"Adorable Newsies", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 3700, 25)},
					{"...Newspapers Proved Themselves...", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 4700, 30)}
                }),
                MaxLevel = 7750,
		        Modifier = 1.09
	        },
	        new Business()
	        {
		        Type = BusinessTypes.Bank,
                Planet = Planets.Earth,
		        Cooldown = new FunctionChainer<double>(6144, new Dictionary<string,Func<double,double>>()
		        {
			        {"A Capital Idea", SingleBusinessCooldownUnlock(BusinessTypes.Bank, 25)},
			        {"Not-So-Petty Cash", SingleBusinessCooldownUnlock(BusinessTypes.Bank, 50)},
			        {"Too Big To Fail", SingleBusinessCooldownUnlock(BusinessTypes.Bank, 100)},
			        {"Galactic Reserve", SingleBusinessCooldownUnlock(BusinessTypes.Bank, 200)},
			        {"All The Moneys", SingleBusinessCooldownUnlock(BusinessTypes.Bank, 300)},
			        {"Bourgeois Banks", SingleBusinessCooldownUnlock(BusinessTypes.Bank, 400)},
			        {"Indestructible Bank Bills", SingleBusinessCooldownUnlock(BusinessTypes.Bank, 2250)},
			        {"Fat Cat Scratch Post", SingleBusinessCooldownUnlock(BusinessTypes.Bank, 2500)},
			        {"Hack Proof Accounts", SingleBusinessCooldownUnlock(BusinessTypes.Bank, 2750)},
			        {"1st National Piggy Bank", SingleBusinessCooldownUnlock(BusinessTypes.Bank, 3000)},
			        {"Recuse Rescue", SingleBusinessCooldownUnlock(BusinessTypes.Bank, 3250)},
			        {"Conflict of Win-terest", SingleBusinessCooldownUnlock(BusinessTypes.Bank, 3500)},
			        {"Now Accepting Blood", SingleBusinessCooldownUnlock(BusinessTypes.Bank, 3750)},
			        {"Truly The Bank Of Banks", SingleBusinessCooldownUnlock(BusinessTypes.Bank, 4000)}
		        }),
		        Cost = 2149908480,
                Profit = new FunctionChainer<double>(1074954240, new Dictionary<string,Func<double,double>>()
                {
                    {"BaseProfitMultiplier", BaseProfitMultiplier(BusinessTypes.Bank)},
                    {"AngelInvestorEffectiveness", AngelInvestorProfitMultiplier(BusinessTypes.Bank)},

                    {"It Prints Money", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 500, 2)},
					{"Ritual Residuals", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 600, 2)},
					{"Money Trees", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 700, 2)},
					{"Recession Proof", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 800, 2)},
					{"Open On Weekends", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 900, 2)},
					{"Monetary Overlord", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 1000, 3)},
					{"Your Face On Money", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 1100, 2)},
					{"No Interest Loans", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 1200, 2)},
					{"Taxes Make Sense", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 1300, 2)},
					{"Bank Teller House Calls", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 1400, 2)},
					{"Loveably Snarky ATMs", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 1500, 2)},
					{"Unlimited Overdraft", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 1600, 2)},
					{"More Like FAIR Miles", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 1700, 2)},
					{"Please Sign Here", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 1800, 2)},
					{"Mega Buck Research", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 1900, 2)},
					{"Multiverse Bank Est.", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 2000, 5)},
					{"Mo' Money", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 4250, 3)},
					{"Mad Money", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 4500, 3)},
					{"Cash-ual Fridays", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 4750, 3)},
					{"Rothschild", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 5000, 5)},
					{"#1 Banker Mug", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 5250, 5)},
					{"Smooth Operator", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 5500, 3)},
					{"Gold Backed", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 5750, 3)},
                    {"Cash. Must. Flow.", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 6000, 5)},
					{"Branches In Branches", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 6250, 3)},
					{"Vest Investments", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 6500, 3)},
					{"More Roman Columns", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 6750, 3)},
					{"Money Is Valuable", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 7000, 5)},
					{"Legal Tender Embrace", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 7250, 3)},
					{"Crash-Proof", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 7500, 3)},
					{"Magnificence", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 7750, 3)},
					{"Bank Right", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 8000, 5)},
					{"Ascend The Ivory Tower", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 8250, 3)},
					{"The Offest Shore", BusinessProfitMultiplierUnlock(BusinessTypes.Bank, 8500, 3)},

                    // Newspaper Affect
                    {"Newspeak Stocks", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 800, 11)},
                    {"Pre-Approved Applications", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1025, 7)},
                    {"Ads On Money", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1225, 8)},
                    {"Money Bribes", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1700, 9)},
                    {"Bank With Us Forever", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1950, 10)},
                    {"Top 10 Bank List", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 2700, 15)},
                    {"Bank Shaped Pages", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 3300, 20)},
                    {"Panic Driven Headlines", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 3800, 25)},
					{"...And It Was Shrimp Boats...", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 4800, 30)}
                }),
                MaxLevel = 8500,
		        Modifier = 1.08
	        },
	        new Business()
	        {
		        Type = BusinessTypes.Oil,
                Planet = Planets.Earth,
		        Cooldown = new FunctionChainer<double>(36864, new Dictionary<string,Func<double,double>>()
		        {
			        {"Slick Enterprise", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 25)},
			        {"Black Gold", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 50)},
			        {"There Will Be Oil", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 100)},
			        {"Crude Empire", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 200)},
			        {"Oil Nebula", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 300)},
			        {"Carbon Universe", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 400)},
			        {"Crudementary", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 2250)},
			        {"Win Or Diesel", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 2500)},
			        {"LFM WD40 ASAP", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 2750)},
			        {"Mole Friendly Derricks", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 3000)},
			        {"Gas Diesel Hybrids", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 3250)},
			        {"Lay Pipe", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 3500)},
			        {"Catchy - Slogan", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 3750)},
			        {"Peaked?", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 4000)},
			        {"That Constant T-oil", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 4250)},
			        {"Hey, Why Not?", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 4500)},
			        {"Thrill Drilling", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 4750)},
			        {"Oil", SingleBusinessCooldownUnlock(BusinessTypes.Oil, 5000)}
		        }),
		        Cost = 25798901760,
                Profit = new FunctionChainer<double>(29668737024, new Dictionary<string,Func<double,double>>()
                {
                    {"BaseProfitMultiplier", BaseProfitMultiplier(BusinessTypes.Oil)},
                    {"AngelInvestorEffectiveness", AngelInvestorProfitMultiplier(BusinessTypes.Oil)},

                    {"Planck Petrol", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 500, 2)},
					{"5th Dimension-Oil", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 600, 2)},
					{"Oil String Theory", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 700, 2)},
					{"Dark Matter Derricks", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 800, 2)},
					{"Observable Oiliverse", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 900, 2)},
					{"Excessive", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 1000, 3)},
					{"Total Carbon Mastery", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 1100, 2)},
					{"Reverse Engineered Dinos", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 1200, 2)},
					{"Drill, Baby, Drill!", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 1300, 2)},
					{"Renewable Oil Wells", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 1400, 2)},
					{"Derricks With Googly Eyes", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 1500, 2)},
					{"Robotic Barrels", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 1600, 2)},
					{"Reasonable Gas Prices", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 1700, 2)},
					{"Free Oil-Based Education", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 1800, 2)},
					{"Crude Is Still King", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 1900, 2)},
					{"It’s Oily...", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 2000, 5)},
					{"Obsessed Much?", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 5250, 3)},
					{"Get ALL The Oil!", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 5500, 3)},
					{"Derrick Every 5 Feet", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 5750, 3)},
					{"That's Oil Folks!", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 6000, 5)},
					{"Oil Is Love", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 6250, 3)},
					{"The P-Oil-ice", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 6500, 3)},
					{"Move To Beverly", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 6750, 3)},
                    {"Black", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 7000, 7)},
					{"New Deposits", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 7250, 3)},
					{"Hot And Fresh", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 7500, 3)},
					{"Carbonous", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 7750, 3)},
					{"Oi Yoi yOil!", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 8000, 3)},
					{"Frack!", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 8250, 3)},
					{"Apolitical Market", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 8500, 3)},
					{"Fries With That?", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 8750, 3)},
					{"Terra Infirma", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 9000, 7)},
					{"Licence To Drill", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 9250, 3)},
					{"It Never Ends", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 9500, 3)},
					{"Pipe Dream", BusinessProfitMultiplierUnlock(BusinessTypes.Oil, 9750, 3)},

                    // Newspaper Affect
                    {"READ BUY GAS OBEY", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 900, 11)},
                    {"Oil Coup-on", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1050, 7)},
                    {"Oily Ads", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1250, 8)},
                    {"Gas Bribes", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 1750, 9)},
                    {"Hilarious Oil Ads", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 2800, 15)},
                    {"Click Baits", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 3400, 20)},
                    {"Laminated Ads", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 3900, 25)},
					{"...That Sucked All Along.", BusinessProfitMultiplierUnlock(BusinessTypes.Newspaper, 4900, 30)}
                }),
                MaxLevel = 9750,
		        Modifier = 1.07
	        }
        });

        #endregion Initializer

        static BusinessController()
        {
            // Apply Global Business Cooldown Unlocks
            Businesses.ForEach(b => b.Cooldown.AddRange(new Dictionary<string, Func<double, double>>()
            {
                {"Mogul", AllBusinessCooldownUnlock(Planets.Earth, 25)},
                {"Oligarch", AllBusinessCooldownUnlock(Planets.Earth, 50)},
                {"Tycoon", AllBusinessCooldownUnlock(Planets.Earth, 100)},
                {"Adam Smith Award", AllBusinessCooldownUnlock(Planets.Earth, 200)},
                {"Universal Capitalist", AllBusinessCooldownUnlock(Planets.Earth, 300)},
                {"Theoretical Economist", AllBusinessCooldownUnlock(Planets.Earth, 400)}
            }));

            // Apply Global Business Profit Unlocks
            Businesses.ForEach(b => b.Profit.AddRange(new Dictionary<string, Func<double, double>>()
            {
                {"The One True Investor", AllBusinessProfitMultiplierUnlock(Planets.Earth, 500, 2)},
				{"Game Of Loans", AllBusinessProfitMultiplierUnlock(Planets.Earth, 600, 2)},
				{"That Can’t Be Good", AllBusinessProfitMultiplierUnlock(Planets.Earth, 666, 2)},
				{"Black Ink Inc", AllBusinessProfitMultiplierUnlock(Planets.Earth, 700, 2)},
				{"Lucky 777s", AllBusinessProfitMultiplierUnlock(Planets.Earth, 777, 2)},
				{"Lord Of Lobbyists", AllBusinessProfitMultiplierUnlock(Planets.Earth, 800, 2)},
				{"Midas", AllBusinessProfitMultiplierUnlock(Planets.Earth, 900, 2)},
				{"Literally Can’t Even", AllBusinessProfitMultiplierUnlock(Planets.Earth, 1000, 2)},
				{"Psyche!", AllBusinessProfitMultiplierUnlock(Planets.Earth, 1100, 2)},
				{"There Can Only Be Ones", AllBusinessProfitMultiplierUnlock(Planets.Earth, 1111, 2)},
				{"The Hang Of It", AllBusinessProfitMultiplierUnlock(Planets.Earth, 1200, 2)},
				{"Invisible Hand High Five", AllBusinessProfitMultiplierUnlock(Planets.Earth, 1300, 2)},
				{"Captain Capitalism", AllBusinessProfitMultiplierUnlock(Planets.Earth, 1400, 2)},
				{"$ Shaped Pool", AllBusinessProfitMultiplierUnlock(Planets.Earth, 1500, 2)},
				{"You’re The Boss", AllBusinessProfitMultiplierUnlock(Planets.Earth, 1600, 2)},
				{"Perspective Annihilation", AllBusinessProfitMultiplierUnlock(Planets.Earth, 1700, 2)},
				{"New Frontier Capitalism", AllBusinessProfitMultiplierUnlock(Planets.Earth, 1800, 2)},
				{"It’s Never Enough", AllBusinessProfitMultiplierUnlock(Planets.Earth, 1900, 2)},
				{"Nice Round Numbers", AllBusinessProfitMultiplierUnlock(Planets.Earth, 2000, 2)},
				{"Frequent Updates", AllBusinessProfitMultiplierUnlock(Planets.Earth, 2100, 2)},
				{"Punctual Launches", AllBusinessProfitMultiplierUnlock(Planets.Earth, 2200, 2)},
				{"2222", AllBusinessProfitMultiplierUnlock(Planets.Earth, 2222, 2)},
				{"Audience Rapport", AllBusinessProfitMultiplierUnlock(Planets.Earth, 2300, 2)},
				{"A Top Hat Is You", AllBusinessProfitMultiplierUnlock(Planets.Earth, 2400, 2)},
				{"A True AdVenture Capitalist", AllBusinessProfitMultiplierUnlock(Planets.Earth, 2500, 2)},
				{"Good Gracious", AllBusinessProfitMultiplierUnlock(Planets.Earth, 2600, 2)},
				{"Gold Pressed Latinum", AllBusinessProfitMultiplierUnlock(Planets.Earth, 2700, 2)},
				{"FASTER!", AllBusinessProfitMultiplierUnlock(Planets.Earth, 2800, 2)},
				{"A Noteworthy Day", AllBusinessProfitMultiplierUnlock(Planets.Earth, 2900, 2)},
				{"Adam Smith Is Proud", AllBusinessProfitMultiplierUnlock(Planets.Earth, 3000, 2)},
				{"Keep Climbing", AllBusinessProfitMultiplierUnlock(Planets.Earth, 3100, 2)},
				{"Upward Trend", AllBusinessProfitMultiplierUnlock(Planets.Earth, 3200, 2)},
				{"Boom", AllBusinessProfitMultiplierUnlock(Planets.Earth, 3300, 2)},
				{"3333", AllBusinessProfitMultiplierUnlock(Planets.Earth, 3333, 2)},
				{"Magical Pixels", AllBusinessProfitMultiplierUnlock(Planets.Earth, 3400, 2)},
				{"The Roaring 3500s", AllBusinessProfitMultiplierUnlock(Planets.Earth, 3500, 2)},
				{"Take What You Can", AllBusinessProfitMultiplierUnlock(Planets.Earth, 3600, 2)},
				{"Where's The Roof On This?", AllBusinessProfitMultiplierUnlock(Planets.Earth, 3700, 2)},
				{"Symphon-Economics", AllBusinessProfitMultiplierUnlock(Planets.Earth, 3800, 2)},
				{"Pecunia Vincit Omnia", AllBusinessProfitMultiplierUnlock(Planets.Earth, 3900, 2)},
                {"The Legend Continues", AllBusinessProfitMultiplierUnlock(Planets.Earth, 4000, 3)},
				{"Who Writes These Things?", AllBusinessProfitMultiplierUnlock(Planets.Earth, 4100, 4)},
				{"Humongous Numbers", AllBusinessProfitMultiplierUnlock(Planets.Earth, 4200, 5)},
				{"Penny Pincher", AllBusinessProfitMultiplierUnlock(Planets.Earth, 4300, 6)},
				{"Glorious", AllBusinessProfitMultiplierUnlock(Planets.Earth, 4400, 7)},
				{"Always I Will Believe In You", AllBusinessProfitMultiplierUnlock(Planets.Earth, 4500, 8)},
				{"And Make Believe In You", AllBusinessProfitMultiplierUnlock(Planets.Earth, 4600, 9)},
				{"And Live In Harmony", AllBusinessProfitMultiplierUnlock(Planets.Earth, 4700, 10)},
				{"Battery Eater", AllBusinessProfitMultiplierUnlock(Planets.Earth, 4800, 11)},
				{"Never Give Up", AllBusinessProfitMultiplierUnlock(Planets.Earth, 4900, 12)},
				{"Achievement", AllBusinessProfitMultiplierUnlock(Planets.Earth, 5000, 13)}
            }));
        }

        public static void RefreshBusinessInfo()
        {
            Businesses.ForEach(b => b.InvokePropertyChanged(new PropertyChangedEventArgs("InfoString")));
        }



        #region Business Affect Functions

        private static Func<double, double> AngelInvestorProfitMultiplier(BusinessTypes businessType)
        {
            return (i) =>
                {
                    Business business = Businesses.Find(b => b.Type == businessType);

                    if (business != null && AngelInvestorController.AngelInvestors.Total > 0)
                        i = ((i * AngelInvestorController.AngelInvestors.Effectiveness) / 100) * AngelInvestorController.AngelInvestors.Total;

                    return i;
                };
        }

        private static Func<double, double> BaseProfitMultiplier(BusinessTypes businessType)
        {
            return (i) =>
                {
                    Business business = Businesses.Find(b => b.Type == businessType);

                    if (business != null)
                        i = i * business.TotalLevel;

                    return i;
                };
        }

        private static Func<double, double> SingleBusinessCooldownUnlock(BusinessTypes businessType, int applicableLevel)
        {
            return (i) =>
                {
                    Business business = Businesses.Find(b => b.Type == businessType);

                    if (business != null && business.TotalLevel >= applicableLevel)
                        i = i / 2;

                    return i;
                };
        }

        private static Func<double, double> AllBusinessCooldownUnlock(Planets applicablePlanet, int applicableLevel)
        {
            return (i) =>
                {
                    if (Businesses.Where(b => b.Planet == applicablePlanet).All(b => b.TotalLevel >= applicableLevel))
                        i = i / 2;

                    return i;
                };
        }

        private static Func<double, double> BusinessProfitMultiplierUnlock(BusinessTypes businessType, int applicableLevel, double profitMultiplier)
        {
            return (i) =>
            {
                Business business = Businesses.Find(b => b.Type == businessType);

                if (business != null && business.TotalLevel >= applicableLevel)
                    i = i * profitMultiplier;

                return i;
            };
        }

        private static Func<double, double> AllBusinessProfitMultiplierUnlock(Planets applicablePlanet, int applicableLevel, double profitMultiplier)
        {
            return (i) =>
            {
                if (Businesses.Where(b => b.Planet == applicablePlanet).All(b => b.TotalLevel >= applicableLevel))
                    i = i * profitMultiplier;

                return i;
            };
        }

        #endregion Business Affect Functions
    }
}