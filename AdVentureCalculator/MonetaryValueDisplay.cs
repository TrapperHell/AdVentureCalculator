using System;
using System.ComponentModel;

namespace AdVentureCalculator
{
    public class MonetaryValueDisplay
    {
        public enum MonetaryTypes
        {
            [Description("")]
            Base = 0,
            //Ten = 1,
            //Hundred = 2,
            Thousand = 3,
            Million = 6,
            Billion = 9,
            Trillion = 12,
            Quadrillion = 15,
            Quintillion = 18,
            Sextillion = 21,
            Septillion = 24,
            Octillion = 27,
            Nonillion = 30,
            Decillion = 33,
            Undecillion = 36,
            Duodecillion = 39,
            Tredecillion = 42,
            Quattuordecillion = 45,
            Quindecillion = 48,
            Sexdecillion = 51,
            Septendecillion = 54,
            Octodecillion = 57,
            Novemdecillion = 60,
            Vigintillion = 63,
            Unvigintillion = 66,
            Duovigintillion = 69,
            Trevigintillion = 72,
            Quattuorvigintillion = 75,
            Quinvigintillion = 78,
            Sexvigintillion = 81,
            Septenvigintillion = 84,
            Octovigintillion = 87,
            Novemvigintillion = 90,
            Trigintillion = 93,
            Untrigintillion = 96,
            Duotrigintillion = 99,
            Tretrigintillion = 102,
            Quattuortrigintillion = 105,
            Quintrigintillion = 108,
            Sextrigintillion = 111,
            Septentrigintillion = 114,
            Octotrigintillion = 117,
            Novemtrigintillion = 120,
            Quadragintillion = 123,
            Unquadragintillion = 126,
            Duoquadragintillion = 129,
            Trequadragintillion = 132,
            Quattuorquadragintillion = 135,
            Quinquadragintillion = 138,
            Sexquadragintillion = 141,
            Septenquadragintillion = 144,
            Octoquadragintillion = 147,
            Novemquadragintillion = 150,
            Quinquagintillion = 153,
            Unquinquagintillion = 156,
            Duoquinquagintillion = 159,
            Trequinquagintillion = 162,
            Quattuorquinquagintillion = 165,
            Quinquinquagintillion = 168,
            Sexquinquagintillion = 171,
            Septenquinquagintillion = 174,
            Octoquinquagintillion = 177,
            Novemquinquagintillion = 180,
            Sexagintillion = 183,
            Unsexagintillion = 186,
            Duosexagintillion = 189,
            Tresexagintillion = 192,
            Quattuorsexagintillion = 195,
            Quinsexagintillion = 198,
            Sexsexagintillion = 201,
            Septensexagintillion = 204,
            Octosexagintillion = 207,
            Novemsexagintillion = 210,
            Septuagintillion = 213,
            Unseptuagintillion = 216,
            Duoseptuagintillion = 219,
            Treseptuagintillion = 222,
            Quattuorseptuagintillion = 225,
            Quinseptuagintillion = 228,
            Sexseptuagintillion = 231,
            Septseptuagintillion = 234,
            Octseptuagintillion = 237,
            Novemseptuagintillion = 240,
            Octogintillion = 243,
            Unoctogintillion = 246,
            Duooctogintillion = 249,
            Treoctogintillion = 252,
            Quattuoroctogintillion = 255,
            Quinoctogintillion = 258,
            Sexoctogintillion = 261,
            Septoctogintillion = 264,
            Octooctogintillion = 267,
            Novemoctogintillion = 270,
            Nonagintillion = 273,
            Unnonagintillion = 276,
            Duonagintillion = 279,
            Trenagintillion = 282,
            Quattuornagintillion = 285
        }



        double value;

        public double Value { get { return this.value; } }

        public MonetaryValueDisplay(double value, MonetaryTypes monetaryType)
        {
            this.value = (value * Math.Pow(10, (int)monetaryType));
        }

        public double GetMonetaryValue(MonetaryTypes monetaryType)
        {
            return GetMonetaryValue(Value, MonetaryTypes.Base, monetaryType);
        }

        public double GetMonetaryValue(out MonetaryTypes monetaryType)
        {
            return GetMonetaryValue(Value, MonetaryTypes.Base, out monetaryType);
        }

        public static double GetMonetaryValue(double originalValue, MonetaryTypes originalMonetaryType, MonetaryTypes desiredMonetaryType)
        {
            double actualValue = GetBaseValue(originalValue, originalMonetaryType);

            return actualValue / Math.Pow(10, (int)desiredMonetaryType);
        }

        public static double GetMonetaryValue(double originalValue, MonetaryTypes originalMonetaryType, out MonetaryTypes idealMonetaryType)
        {
            double currentValue = 0;

            MonetaryTypes[] monetaryTypes = (MonetaryTypes[])Enum.GetValues(typeof(MonetaryTypes));

            idealMonetaryType = monetaryTypes[monetaryTypes.Length - 1];
            double actualValue = GetBaseValue(originalValue, originalMonetaryType);

            for (int i = 0; i < monetaryTypes.Length; i++)
            {
                currentValue = GetMonetaryValue(actualValue, MonetaryTypes.Base, monetaryTypes[i]);

                if (!double.IsInfinity(currentValue) /*&& currentValue >= 1d*/ && currentValue < 1000)
                {
                    idealMonetaryType = monetaryTypes[i];
                    break;
                }
            }

            return currentValue;
        }

        private static double GetBaseValue(double value, MonetaryTypes monetaryType)
        {
            if (monetaryType == MonetaryTypes.Base)
                return value;
            else
                return (value * Math.Pow(10, (int)monetaryType));
        }
    }
}