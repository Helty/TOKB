using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Tests.Statistical
{
    enum Result
    {
        Badly,
        Good,
        Great
    }

    internal interface IStatisticalTest
    {
        void Сomputation();

        double GetValueResultTest();

        Result GetEnumResultTest();
    }
}
