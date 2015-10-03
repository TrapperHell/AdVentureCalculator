using System;
using System.Collections.Generic;
using AdVentureCalculator.Model;

namespace AdVentureCalculator.Controller
{
    public static class ManagerController
    {
        public const double ACCOUNTANT_MANAGER_DISCOUNT = 10, DISCOUNT_MANAGER_DISCOUNT = 99.999;

        #region Initializer

        public static List<Manager> Managers = new List<Manager>(new Manager[]
        {
            /*
             *          ACCOUNTANT MANAGERS
            */

            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Oil, ACCOUNTANT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Oil), ACCOUNTANT_MANAGER_DISCOUNT),
                Name = "Ebenezer Rockfeller",
                Type = Manager.Types.Accountant
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Bank, ACCOUNTANT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Bank), ACCOUNTANT_MANAGER_DISCOUNT),
                Name = "Darky McGrumpface",
                Type = Manager.Types.Accountant
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Movie, ACCOUNTANT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Movie), ACCOUNTANT_MANAGER_DISCOUNT),
                Name = "Jenn Catsburger",
                Type = Manager.Types.Accountant
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Hockey, ACCOUNTANT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Hockey), ACCOUNTANT_MANAGER_DISCOUNT),
                Name = "Dwayne GreatSky",
                Type = Manager.Types.Accountant
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Shrimp, ACCOUNTANT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Shrimp), ACCOUNTANT_MANAGER_DISCOUNT),
                Name = "Cpt Janeway Krunch",
                Type = Manager.Types.Accountant
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Donut, ACCOUNTANT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Donut), ACCOUNTANT_MANAGER_DISCOUNT),
                Name = "Homer Sprinkles",
                Type = Manager.Types.Accountant
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Pizza, ACCOUNTANT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Pizza), ACCOUNTANT_MANAGER_DISCOUNT),
                Name = "P.J. Fries",
                Type = Manager.Types.Accountant
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Car, ACCOUNTANT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Car), ACCOUNTANT_MANAGER_DISCOUNT),
                Name = "Gus Pollos",
                Type = Manager.Types.Accountant
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Newspaper, ACCOUNTANT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Newspaper), ACCOUNTANT_MANAGER_DISCOUNT),
                Name = "Milly Bayes",
                Type = Manager.Types.Accountant
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Lemon, ACCOUNTANT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Lemon), ACCOUNTANT_MANAGER_DISCOUNT),
                Name = "Gladys Caroline",
                Type = Manager.Types.Accountant
            },

            /*
             *          DISCOUNT MANAGERS
            */

            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Newspaper, DISCOUNT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Newspaper), DISCOUNT_MANAGER_DISCOUNT),
                Name = "May O'Neil",
                Type = Manager.Types.Discount
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Hockey, DISCOUNT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Hockey), DISCOUNT_MANAGER_DISCOUNT),
                Name = "Gordie Palmbay",
                Type = Manager.Types.Discount
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Movie, DISCOUNT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Movie), DISCOUNT_MANAGER_DISCOUNT),
                Name = "Alfredo Hitchpost",
                Type = Manager.Types.Discount
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Pizza, DISCOUNT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Pizza), DISCOUNT_MANAGER_DISCOUNT),
                Name = "Jordan Ram C.",
                Type = Manager.Types.Discount
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Bank, DISCOUNT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Bank), DISCOUNT_MANAGER_DISCOUNT),
                Name = "Raygun P. Zuzu",
                Type = Manager.Types.Discount
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Donut, DISCOUNT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Donut), DISCOUNT_MANAGER_DISCOUNT),
                Name = "Duncan Eclair",
                Type = Manager.Types.Discount
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Shrimp, DISCOUNT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Shrimp), DISCOUNT_MANAGER_DISCOUNT),
                Name = "Admiral Snackbar",
                Type = Manager.Types.Discount
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Car, DISCOUNT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Car), DISCOUNT_MANAGER_DISCOUNT),
                Name = "Jessie",
                Type = Manager.Types.Discount
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Oil, DISCOUNT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Oil), DISCOUNT_MANAGER_DISCOUNT),
                Name = "Richard Ruthless",
                Type = Manager.Types.Discount
            },
            new Manager()
            {
                Affect = CostDiscountPercentage(BusinessTypes.Lemon, DISCOUNT_MANAGER_DISCOUNT),
                Description = String.Format("{0} - {1}% discount.", EnumHelper.GetEnumDescription(BusinessTypes.Lemon), DISCOUNT_MANAGER_DISCOUNT),
                Name = "Chill",
                Type = Manager.Types.Discount
            }
        });

        #endregion Initializer

        public static Func<Manager, Business, Business> CostDiscountPercentage(BusinessTypes businessType, double discountPercentage)
        {
            return new Func<Manager, Business, Business>((m, b) =>
            {
                if (b.Type == businessType)
                    if (m.IsActive)
                        b.Cost.Add(m.Name, (i) => i - (i * discountPercentage) / 100);
                    else
                        b.Cost.Remove(m.Name);

                return b;
            });
        }
    }
}