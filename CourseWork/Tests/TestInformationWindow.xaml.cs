﻿using System;
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

namespace CourseWork
{
    /// <summary>
    /// Логика взаимодействия для TestInformationWindow.xaml
    /// </summary>
    public partial class TestInformationWindow : Window
    {
        public TestInformationWindow(string sequenceNumber)
        {
            InitializeComponent();
            this.sequenceNumber = sequenceNumber;

            this.СomputationStatisticTest();
        }

        private string sequenceNumber = string.Empty;

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void СomputationStatisticTest()
        {
            
        }
    }
}
