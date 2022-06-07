using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

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
                        num = num / 2;
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

        public static string DecimalToBinaryBySymbol(string numberSequence)
        {
            string bitSequence = string.Empty;

            foreach (char symbol in numberSequence)
            {
                bitSequence += Convert.ToString(Convert.ToInt32(symbol), 2);
            }

            return bitSequence;
        }
    }
}
