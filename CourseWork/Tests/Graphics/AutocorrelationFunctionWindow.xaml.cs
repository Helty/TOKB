using CourseWork.Tests.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows;
using Color = System.Drawing.Color;

namespace CourseWork.Tests
{
    enum AutocorrelationMode
    {
        BIT,
        SYMBOL
    }

    public partial class AutocorrelationFunctionWindow : Window, IGraphicsTest
    {
        private string sequenceNumber;
        private AutocorrelationMode modeAutocorrelation;
        private List<double> values;

        public AutocorrelationFunctionWindow(string sequenceNumber, string modeAutocorrelation)
        {
            InitializeComponent();
            this.sequenceNumber = sequenceNumber;
            this.modeAutocorrelation = TestTools.AutocorrelationModeParse(modeAutocorrelation);
            this.values = new List<double>();
            Draw();
        }

        public void СomputeDataToDisplay()
        {
            List<double> normalizedSequence;
            normalizedSequence = GetNormalizedSequence();
            CalculationBurstsCorrelation(normalizedSequence);
        }

        public void Draw()
        {
            СomputeDataToDisplay();

            List<double> positions = new List<double>();
            List<string> labels = new List<string>();

            for (int i = 0; i < values.Count; i++)
            {
                positions.Add(i);
                labels.Add(i.ToString());
            }

            var bar = AutocorrelationFunctionWpfPlot.Plot.AddBar(values.ToArray(), positions.ToArray());
            bar.FillColor = Color.Green;
            bar.FillColorNegative = Color.Red;

            AutocorrelationFunctionWpfPlot.Plot.XTicks(positions.ToArray(), labels.ToArray());
            AutocorrelationFunctionWpfPlot.Refresh();
        }

        private List<double> GetNormalizedSequence()
        {
            List<double> normalizedSequence = new List<double>();

            string bitSequence = TestTools.IsBinarySequence(sequenceNumber) ? sequenceNumber
                : TestTools.DecimalToBinaryBySymbol(sequenceNumber);

            if (modeAutocorrelation == AutocorrelationMode.BIT)
            {
                foreach (char sym in bitSequence)
                {
                    if (sym - '0' == 0) normalizedSequence.Add(-1);
                    else normalizedSequence.Add(1);
                }
            }
            else if (modeAutocorrelation == AutocorrelationMode.SYMBOL)
            {
                for (int i = 0; i < sequenceNumber.Length; i += 3)
                {
                    normalizedSequence.Add(
                        (Math.Pow((-1), i + 3) * Math.Pow(0, 2)) +
                        (Math.Pow((-1), i + 2) * Math.Pow(1, 2)) +
                        (Math.Pow((-1), i) * Math.Pow(2, 2))
                    );
                }
            }

            return normalizedSequence;
        }

        private void CalculationBurstsCorrelation(List<double> normalizedSequence)
        {
            for (int j = 0; j <= normalizedSequence.Count; j++)
            {
                double Numerator = 0, Denominator = 0;
                for (int i = 0; i < normalizedSequence.Count; i++) Numerator += (normalizedSequence[i] * normalizedSequence[(i + j) % normalizedSequence.Count]);
                for (int i = 0; i < normalizedSequence.Count; i++) Denominator += Math.Pow(normalizedSequence[i], 2);
                values.Add(Numerator / Denominator);
            }
        }
    }
}
