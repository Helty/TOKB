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
using Color = System.Drawing.Color;

namespace CourseWork.Tests
{
    public partial class MonotonicityCheckWindow : Window, IGraphicsTest
    {
        private string sequenceNumber = string.Empty;
        private List<double> values;

        public MonotonicityCheckWindow(string sequenceNumber)
        {
            InitializeComponent();
            this.sequenceNumber = sequenceNumber;
            values = new List<double>();
            Draw();
        }

        public void СomputeDataToDisplay()
        {
            double counter = 0;
            bool increasing = false;

            if (Convert.ToInt32(sequenceNumber[0]) < Convert.ToInt32(sequenceNumber[1])) increasing = true;

            for (int position = 0; position < sequenceNumber.Length; position++)
            {
                if ((position+1) == sequenceNumber.Length)
                {
                    values.Add(counter);
                    break;
                }

                if ((Convert.ToInt32(sequenceNumber[position]) < Convert.ToInt32(sequenceNumber[position+1]) && !increasing) ||
                    (Convert.ToInt32(sequenceNumber[position]) > Convert.ToInt32(sequenceNumber[position+1]) && increasing))
                {
                    increasing = !increasing;
                    values.Add(counter);
                    counter = 1;
                }
                else counter++;                
            }
        }

        public void Draw()
        {
            СomputeDataToDisplay();

            CreateBarOnPlot(/*start*/0, /*step*/2, Color.Red);
            CreateBarOnPlot(/*start*/1, /*step*/2, Color.Blue);

            List<double> allPositions = new List<double>();
            List<string> labels = new List<string>();
            for (int i = 0; i < values.Count; i++)
            {
                allPositions.Add(i);
                labels.Add(i.ToString());
            }

            MonotonicityCheckWpfPlot.Plot.XTicks(allPositions.ToArray(), labels.ToArray());
            MonotonicityCheckWpfPlot.Plot.SetAxisLimits(yMin: 0);
            MonotonicityCheckWpfPlot.Refresh();
        }

        private void CreateBarOnPlot(int startPosition, int step, Color colorBar)
        {
            List<double> barValues = new List<double>();
            List<double> positions = new List<double>();

            for (int i = startPosition; i < values.Count; i += step)
            {
                barValues.Add(values[i]);
                positions.Add(i);
            }

            MonotonicityCheckWpfPlot.Plot.AddBar(barValues.ToArray(), positions.ToArray()).FillColor = colorBar;
        }
    }
}
