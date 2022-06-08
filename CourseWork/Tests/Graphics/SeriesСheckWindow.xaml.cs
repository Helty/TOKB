using CourseWork.Tests.Interfaces;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;

namespace CourseWork.Tests
{
    public partial class SeriesСheckWindow : Window, IGraphicsTest
    {
        private string sequenceNumber;
        private int countSeries;
        private SortedDictionary<string, double> valuesToDraw;

        public SeriesСheckWindow(string sequenceNumber, int countSeries)
        {
            InitializeComponent();
            this.sequenceNumber = sequenceNumber;
            this.countSeries = countSeries;
            valuesToDraw = new SortedDictionary<string, double>();
            Draw();
        }

        public void Draw()
        {
            СomputeDataToDisplay();

            List<double> values = new List<double>();
            List<string> labels = new List<string>();
            List<double> positions = new List<double>();

            foreach (var pair in valuesToDraw)
            {
                labels.Add(pair.Key);
                values.Add(pair.Value);
            }

            for (int position = 0; position < labels.Count; position++) positions.Add(position);

            SeriesCheckWpfPlot.Plot.AddBar(values.ToArray(), positions.ToArray());
            SeriesCheckWpfPlot.Plot.XTicks(positions.ToArray(), labels.ToArray());
            SeriesCheckWpfPlot.Plot.SetAxisLimits(yMin: 0);
            SeriesCheckWpfPlot.Refresh();
        }

        public void СomputeDataToDisplay()
        {
            string bitSequence = sequenceNumber;
            if (!TestTools.IsBinarySequence(sequenceNumber)) bitSequence = TestTools.DecimalToBinaryBySymbol(sequenceNumber);

            for (int i = 0; i < bitSequence.Length; i += countSeries)
            {
                try
                {
                    string series = bitSequence.Substring(i, countSeries);
                    if (!valuesToDraw.ContainsKey(series))
                    {
                        valuesToDraw.Add(series, Regex.Matches(bitSequence, series).Count);
                    }
                }
                catch { break; }
            }
        }
    }
}
