using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Tests.Statistical
{
    internal class UnlinkedTest : IStatisticalTest
    {
        private readonly double resultTest;

        public UnlinkedTest(string sequenceNumber)
        {
            this.resultTest = Сomputation(sequenceNumber);
        }

        public Result GetEnumResultTest()
        {
            if (resultTest <= 0.2) return Result.Badly;
            if (resultTest > 0.2 && resultTest <= 0.7) return Result.Good;
            if (resultTest > 0.7) return Result.Great;
            return Result.None;
        }

        public double GetValueResultTest()
        {
            return resultTest;
        }

        public double Сomputation(string sequenceNumber)
        {
            string bitSequence = TestTools.DecimalToBinary(sequenceNumber);
            Dictionary<string, UInt64> seriesCounter = GetSeriesCounter(bitSequence);
            return alglib.chisquarecdistribution(7, ChiSquareUnlinkedSeries(seriesCounter, bitSequence));
        }

        private Dictionary<string, UInt64> GetSeriesCounter(string bitSequence)
        {
            Dictionary<string, UInt64> result = SetAllСombinationsOfSerial3();

            for (int i = 0; i < bitSequence.Length; i += 3)
            {
                try 
                {
                    string sub = bitSequence.Substring(i, 3);
                    result[sub] += 1;
                }
                catch { break; }
            }

            return result;
        }

        private Dictionary<string, UInt64> SetAllСombinationsOfSerial3()
        {
            Dictionary<string, UInt64> result = new Dictionary<string, UInt64>
            {
                ["000"] = 0,
                ["001"] = 0,
                ["010"] = 0,
                ["011"] = 0,
                ["100"] = 0,
                ["101"] = 0,
                ["110"] = 0,
                ["111"] = 0
            };

            return result;
        }

        private double ChiSquareUnlinkedSeries(Dictionary<string, UInt64> seriesCounter, string bitSequence)
        {
            List<UInt64> valueFromMap = new List<UInt64>();

            foreach (var pair in seriesCounter) valueFromMap.Add(pair.Value);

            double divider = (bitSequence.Length / 3.0) * (1.0 / 8.0);
            double b = 1 / divider;
            double sum = 0;

            for (int i = 0; i != valueFromMap.Count; i++)
            {
                sum += Math.Pow(valueFromMap[i] - divider, 2);
            }

            return b * sum;
        }
    }
}
