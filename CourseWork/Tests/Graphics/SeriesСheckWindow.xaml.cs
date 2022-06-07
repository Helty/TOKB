using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class SeriesСheckWindow : Window, IGraphicsTest
    {
        private string sequenceNumber;
        private int countSeries;
        private Dictionary<string, double> valuesToDraw;

        public SeriesСheckWindow(string sequenceNumber, int countSeries)
        {
            InitializeComponent();
            this.sequenceNumber = sequenceNumber;
            this.countSeries = countSeries;
            valuesToDraw = new Dictionary<string, double>();
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
            if (TestTools.IsBinarySequence(sequenceNumber)) SeriesByOneSymbols();
            else SeriesSymbols();
        }

        private void SeriesByOneSymbols()
        {
            valuesToDraw.Add("1", sequenceNumber.Count(sym => (sym == '1')));
            valuesToDraw.Add("0", sequenceNumber.Count(sym => (sym == '0')));
        }

        private void SeriesSymbols()
        {
            string bitSequence = TestTools.DecimalToBinaryBySymbol(sequenceNumber);
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
