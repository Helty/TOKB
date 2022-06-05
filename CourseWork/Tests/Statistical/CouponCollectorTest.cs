using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Tests.Statistical
{
    internal class CouponCollectorTest : IStatisticalTest
    {
        private double resultTest;

        public CouponCollectorTest(string sequenceNumber)
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
            UInt16 t = 5;
            string bitSequence = TestTools.DecimalToBinary(sequenceNumber);
            List<string> subSequence = GetSubSequences(bitSequence);
            Dictionary<UInt16, UInt16> vMap = GetLengthOfSubSequence(subSequence, t);
            double vSum = GetVSum(vMap);
            List<double> pVector = GetPVector(t);
            return alglib.chisquarecdistribution(t - 2 + 1, ChiSquareGathererCoupon(t, vMap, vSum, pVector));
        }

		private List<string> GetSubSequences(string bitSequence)
		{
			List<string> result = new List<string>();

			string sub = string.Empty;
			bool flagZero = false, flagOne = false;

			for (int i = 0; i != bitSequence.Length; i += 1)
			{
				sub += bitSequence[i];
				if (bitSequence[i] == '0') flagOne = true;
				else flagZero = true;

				if (flagOne && flagZero)
				{
					result.Add(sub);

					sub = string.Empty;
					flagZero = false;
					flagOne = false;
				}
			}
			return result;
		}

		private Dictionary<UInt16, UInt16> GetLengthOfSubSequence(List<string> subSequence, UInt16 t)
		{
			Dictionary<UInt16, UInt16> result = new Dictionary<UInt16, UInt16>();
			for (UInt16 i = 2; i <= t; i++) result[i] = 0;
			foreach (var sub in subSequence)
			{
				if (sub.Length > t) continue;
				result[(UInt16)sub.Length]++;
			}
			return result;
		}

		private double ChiSquareGathererCoupon(UInt16 t, Dictionary<UInt16, UInt16> lengthOfSubSequence, double vSum, List<double> pVector)
		{
			double result = 0;
			for (UInt16 i = 1; i <= t; i++)
			{
				double first = vSum * pVector[i - 1];
				if (first != 0) result += Math.Pow(lengthOfSubSequence[i] - first, 2) / first;
			}
			return result;
		}

		private double GetVSum(Dictionary<UInt16, UInt16> vMap)
		{
			double vSum = 0;
			foreach (var pair in vMap) vSum += pair.Value;
			vMap[1] = 1;
			return vSum;
		}

		private List<double> GetPVector(UInt16 t)
		{
			List<double> pVector = new List<double>();
			for (int i = 1; i < t; i++) pVector.Add(1.0);
			pVector.Add(0.0);
			return pVector;
		}
    }
}
