using CourseWork.Tests.Statistical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CourseWork.Tests.Interfaces;

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
