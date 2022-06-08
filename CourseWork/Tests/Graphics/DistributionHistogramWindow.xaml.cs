using CourseWork.Tests.Interfaces;
using System.Collections.Generic;
using System.Windows;

namespace CourseWork.Tests
{
    public partial class DistributionHistogramWindow : Window, IGraphicsTest
    {
        private List<double> values;
        private string sequenceNumber = string.Empty;

        public DistributionHistogramWindow(string sequenceNumber)
        {
            InitializeComponent();
            this.sequenceNumber = sequenceNumber;
            this.values = new List<double>();
            Draw();
        }

        public void СomputeDataToDisplay()
        {
            foreach (char number in sequenceNumber)
            {
                values[int.Parse(number.ToString())]++;
            }
        }

        public void Draw()
        {
            List<double> positions = new List<double>();
            List<string> labels = new List<string>();

            int countPositions = TestTools.IsBinarySequence(sequenceNumber) ? 2 : 10;

            for (int position = 0; position < countPositions; position++)
            {
                values.Add(0);
                positions.Add(position);
                labels.Add(position.ToString());
            }

            СomputeDataToDisplay();
            DistributionHistogramWpfPlot.Plot.AddBar(values.ToArray(), positions.ToArray());
            DistributionHistogramWpfPlot.Plot.XTicks(positions.ToArray(), labels.ToArray());
            DistributionHistogramWpfPlot.Plot.SetAxisLimits(yMin: 0);
            DistributionHistogramWpfPlot.Refresh();
        }
    }
}
