using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Tests.Statistical
{
    internal class PermutationalTest : IStatisticalTest
    {
        private double resultTest;

        public PermutationalTest(string sequenceNumber)
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
            string bitSequence = TestTools.DecimalToBinary(sequenceNumber);
            List<string> subSequences = GetSubsequencesPermutations3(bitSequence);
            Dictionary<string, UInt16> vMap = GetVMapPermutations(subSequences);
            return alglib.chisquarecdistribution(5, ChiSquarePermutations(vMap, subSequences));
        }

		private List<string> GetSubsequencesPermutations3(string bitSequence)
		{
			List<string> result = new List<string>();
			for (int i = 0; i != bitSequence.Length; i += 3)
			{
				try
				{
					string sub = bitSequence.Substring(i, 3);
					result.Add(sub);
				}
				catch { break; }
			}
			return result;
		}

		private Dictionary<string, UInt16> GetVMapPermutations(List<string> subSequences)
		{
			Dictionary<string, UInt16> result = new Dictionary<string, UInt16>();
			if (subSequences.Count < 2)
			{
				return result;
			}
			for (int i = 0; i < 3; i++)
			{
				if (i == subSequences.Count) break;
				result[subSequences[i]] = 0;
				for (int j = 0; j != subSequences.Count; j++)
				{
					if (subSequences[i] == subSequences[j]) result[subSequences[i]]++;
				}
			}
			return result;
		}

		private double ChiSquarePermutations(Dictionary<string, UInt16> vMap, List<string> subSequences)
		{
			double result = 0;
			double length = subSequences.Count;
			double first = ((length / 3.0) * (1.0 / 6.0));
			for (int i = 0; i < 3.0; i++)
			{
				if (first != 0)
				{
					result += Math.Pow(vMap[subSequences[i]] - first, 2);
				}
			}
			return result / first;
		}

    }
}
