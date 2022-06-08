using System;
using System.Linq;
using System.Numerics;

namespace CourseWork.Tests
{
    static internal class TestTools
    {
        private static string error = string.Empty;

        public static string DecimalToBinary(string data)
        {
            string result = string.Empty;
            BigInteger rem = 0;
            try
            {
                if (!data.All(char.IsDigit))
                {
                    error = "Invalid Value - This is not a numeric value";
                }
                else
                {
                    BigInteger num = BigInteger.Parse(data);
                    while (num > 0)
                    {
                        rem = num % 2;
                        num /= 2;
                        result = rem.ToString() + result;
                    }
                }
            }
            catch (Exception ex) { error = ex.Message; }

            return result;
        }

        public static bool IsBinarySequence(string numberSequence)
        {
            return numberSequence.All(symbol => (symbol == '1' || symbol == '0'));
        }

        public static bool IsOnlyNumberSequence(string numberSequence)
        {
            return numberSequence.All(symbol => (
                symbol == '0' || symbol == '1' ||
                symbol == '2' || symbol == '3' ||
                symbol == '4' || symbol == '5' ||
                symbol == '6' || symbol == '7' ||
                symbol == '8' || symbol == '9'
            ));
        }

        public static string DecimalToBinaryBySymbol(string numberSequence)
        {
            string bitSequence = string.Empty;

            foreach (char symbol in numberSequence)
            {
                bitSequence += DecimalToBinary(symbol.ToString());
            }

            return bitSequence;
        }

        public static AutocorrelationMode AutocorrelationModeParse(string value)
        {
            return value == "биты" ? AutocorrelationMode.BIT
                : AutocorrelationMode.SYMBOL;
        }
    }
}
