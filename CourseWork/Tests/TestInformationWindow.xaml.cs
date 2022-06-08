using CourseWork.Tests;
using CourseWork.Tests.Statistical;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace CourseWork
{
    public partial class TestInformationWindow : Window
    {
        private string sequenceNumber = string.Empty;
        private int assessedTests = 10;
        private int totalTestEnumResult;

        public TestInformationWindow(string sequenceNumber)
        {
            InitializeComponent();
            this.sequenceNumber = sequenceNumber;
            totalTestEnumResult = 0;
            СomputationStatisticTest();
        }

        private void СomputationStatisticTest()
        {
            UnlinkedTest unlinkedTest = new UnlinkedTest(sequenceNumber);
            SetDataTestToLabels(unlinkedTest, UnlinkedSeriesCheckResultLabel, UnlinkedSeriesCheckEnumResultLabel);

            IntervalTest intervalTest = new IntervalTest(sequenceNumber);
            SetDataTestToLabels(intervalTest, IntervalsCheckResultLabel, IntervalsCheckEnumResultLabel);

            СombinationTest combinationTest = new СombinationTest(sequenceNumber);
            SetDataTestToLabels(combinationTest, CombinationsCheckResultLabel, CombinationsCheckEnumResultLabel);

            CouponCollectorTest collectorTest = new CouponCollectorTest(sequenceNumber);
            SetDataTestToLabels(collectorTest, CouponCollectorResultLabel, CouponCollectorEnumResultLabel);

            PermutationalTest permutationalTest = new PermutationalTest(sequenceNumber);
            SetDataTestToLabels(permutationalTest, PermutationsCheckResultLabel, PermutationsCheckEnumResultLabel);

            TotalEnumResultLabel.Content = GetTotalEnumResult().ToString();
        }
        private void SetDataTestToLabels(IStatisticalTest statisticalTest, Label result, Label resultEnum)
        {
            result.Content = statisticalTest.GetValueResultTest().ToString();
            resultEnum.Content = statisticalTest.GetEnumResultTest().ToString();

            totalTestEnumResult += (int)statisticalTest.GetEnumResultTest();
        }
        private Result GetTotalEnumResult()
        {
            return (Result)Math.Round((double)(totalTestEnumResult / assessedTests));
        }

        private void DistributionHistogramFunctionalButton_Click(object sender, RoutedEventArgs e)
        {
            DistributionHistogramWindow distributionHistogramWindow = new DistributionHistogramWindow(sequenceNumber);
            distributionHistogramWindow.ShowDialog();
        }
        private void FlatDistributionFunctionalButton_Click(object sender, RoutedEventArgs e)
        {
            FlatDistributionWindow flatDistributionWindow = new FlatDistributionWindow(sequenceNumber);
            flatDistributionWindow.ShowDialog();
        }
        private void SeriesCheckFunctionalButton_Click(object sender, RoutedEventArgs e)
        {
            SeriesСheckWindow seriesСheckWindow = new SeriesСheckWindow(
                sequenceNumber, 
                Convert.ToInt32(SeriesCheckChangeComboBox.SelectedItem)
            );

            seriesСheckWindow.ShowDialog();
        }
        private void MonotonicityCheckFunctionalButton_Click(object sender, RoutedEventArgs e)
        {
            MonotonicityCheckWindow monotonicityCheckWindow = new MonotonicityCheckWindow(sequenceNumber);
            monotonicityCheckWindow.ShowDialog();
        }
        private void AutocorrelationFunctionButton_Click(object sender, RoutedEventArgs e)
        {
            AutocorrelationFunctionWindow autocorrelationFunctionWindow = new AutocorrelationFunctionWindow(
                sequenceNumber,
                Convert.ToString(AutocorrelationFunctionChangeComboBox.SelectedItem)
            );
            autocorrelationFunctionWindow.ShowDialog();
        }

        private void DistributionHistogramResultComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTotalResult((ComboBox)sender);
        }
        private void FlatDistributionResultComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTotalResult((ComboBox)sender);
        }
        private void SeriesCheckResultComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTotalResult((ComboBox)sender);
        }
        private void MonotonicityCheckResultComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTotalResult((ComboBox)sender);
        }
        private void AutocorrelationFunctionResultComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTotalResult((ComboBox)sender);
        }

        private void UpdateTotalResult(ComboBox currentComboBox)
        {
            Enum.TryParse(currentComboBox.SelectedValue.ToString(), out Result currentResult);
            Enum.TryParse(currentComboBox.Text, out Result oldResult);

            if (currentResult == Result.None) assessedTests--;
            else if (oldResult == Result.None && currentResult != Result.None) assessedTests++;

            totalTestEnumResult += ((int)currentResult - (int)oldResult);
            TotalEnumResultLabel.Content = GetTotalEnumResult().ToString();
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}