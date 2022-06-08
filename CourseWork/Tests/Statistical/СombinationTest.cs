using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Tests.Statistical
{
    internal class СombinationTest : IStatisticalTest
    {
        private double resultTest;

        public СombinationTest(string sequenceNumber)
        {
            resultTest = Сomputation(sequenceNumber);
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
            if (!TestTools.IsBinarySequence(sequenceNumber)) sequenceNumber = TestTools.DecimalToBinary(sequenceNumber);

            double n = sequenceNumber.Length;
            UInt16 t = 4;

            List<string> subSequences = GetSubsequencesCombinations(sequenceNumber, t);
            Dictionary<UInt16,UInt16> mapLengOfSubsequences = GetLengOfSubsequencesCombinations(subSequences);

            return alglib.chisquarecdistribution(subSequences.Count - 1.0, Math.Pow((mapLengOfSubsequences[1] - n / t), 2.0) / (n / t));
        }

        private List<string> GetSubsequencesCombinations(string bitSequence, UInt16 t)
        {
            List<string> result = new List<string>();

            for (int i = 0; i != bitSequence.Length; i += t)
            {
                try
                {
                    string sub = bitSequence.Substring(i, t);
                    result.Add(sub);
                }
                catch { break; }
            }
            return result;
        }

        private Dictionary<UInt16, UInt16> GetLengOfSubsequencesCombinations(List<string> subSequences)
        {
	        Dictionary<UInt16, UInt16> result = new Dictionary<UInt16, UInt16>();

	        for (UInt16 i = 1; i <= 2; i++) result[i] = 0;

            UInt16 counterOne = 0;
            UInt16 counterZero = 0;

	        foreach (var v in subSequences)
	        {
                foreach (var num in v)
		        {
			        if (num == '1') counterOne++;
			        if (num == '0') counterZero++;
		        }
		        if ((counterOne != 0) && (counterZero != 0)) result[2]++;
		        if ((counterOne == 0) || (counterZero == 0)) result[1]++;
                counterOne = 0;
                counterZero = 0;
	        }
	        return result;
        }
    }
}
