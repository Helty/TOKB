using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Tests.Statistical
{
    internal class CouponCollectorTest : IStatisticalTest
    {
        public CouponCollectorTest(string sequenceNumber)
        {
            Сomputation(sequenceNumber);
        }

        private double resultTest = double.NaN;

        public Result GetEnumResultTest()
        {
            return Result.None;
        }

        public double GetValueResultTest()
        {
            return 0.0;
        }

        public void Сomputation(string sequenceNumber)
        {
            if (resultTest == double.NaN)
            {

            }
        }
    }
}
