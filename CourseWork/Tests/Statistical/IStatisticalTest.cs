using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Tests.Statistical
{
    enum Result
    {
        None = 0,
        Badly = 1,
        Good = 2,
        Great = 3
    }

    internal interface IStatisticalTest
    {
        void Сomputation(string sequenceNumber);

        double GetValueResultTest();

        Result GetEnumResultTest();
    }
}
