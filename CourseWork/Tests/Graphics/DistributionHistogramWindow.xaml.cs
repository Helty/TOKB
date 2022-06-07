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
        private double[] values;
        private string sequenceNumber = String.Empty;

        public DistributionHistogramWindow(string sequenceNumber)
        {
            InitializeComponent();

            this.sequenceNumber = sequenceNumber;

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
            double[] positions;
            string[] labels;

            if (sequenceNumber.All(symbol => (symbol == '1' || symbol == '0')))
            {
                values = new double[2];
                positions = new double[2] { 0, 1 };
                labels = new string[2] { "0", "1" };
            }
            else
            {
                values = new double[10];
                positions = new double[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                labels = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            }

            СomputeDataToDisplay();
            WpfPlot1.Plot.AddBar(values, positions);
            WpfPlot1.Plot.XTicks(positions, labels);
            WpfPlot1.Plot.SetAxisLimits(yMin: 0);
            WpfPlot1.Refresh();
        }
    }
}
