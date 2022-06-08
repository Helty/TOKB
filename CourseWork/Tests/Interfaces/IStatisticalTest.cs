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
        double Сomputation(string sequenceNumber);

        double GetValueResultTest();

        Result GetEnumResultTest();
    }
}
