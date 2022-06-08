using CourseWork.Tests.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows;
using Color = System.Drawing.Color;

namespace CourseWork.Tests
{
    struct Points
    {
        public List<double> X;
        public List<double> Y;
    }

    public partial class FlatDistributionWindow : Window, IGraphicsTest
    {
        private Points points;
        private string sequenceNumber = String.Empty;

        public FlatDistributionWindow(string sequenceNumber)
        {
            InitializeComponent();

            this.sequenceNumber = sequenceNumber;
            points.X = new List<double>();
            points.Y = new List<double>();

            Draw();
        }

        public void СomputeDataToDisplay()
        {
            for (int i = 0; i < sequenceNumber.Length; i++)
            {
                try
                {
                    string pair = sequenceNumber.Substring(i, 2);
                    points.X.Add(int.Parse(pair[0].ToString()));
                    points.Y.Add(int.Parse(pair[1].ToString()));
                }
                catch { break; }
            }
        }

        public void Draw()
        {
            СomputeDataToDisplay();
            DistributionHistogramWpfPlot.Plot.AddScatterPoints(points.X.ToArray(), points.Y.ToArray(), Color.DarkRed, 10);
            DistributionHistogramWpfPlot.Plot.Grid(false);
            DistributionHistogramWpfPlot.Refresh();
        }
    }
}
