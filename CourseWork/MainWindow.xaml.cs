using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourseWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SequenceNumberTextBox.PreviewTextInput += new TextCompositionEventHandler(SequenceNumberTextBox_PreviewTextInput);
        }

        private void OpenTxtFileRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            this.SequenceNumberTextBox.IsEnabled = false;
            this.OpenTxtFileButton.IsEnabled = true;
        }

        private void UserInputRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            this.SequenceNumberTextBox.IsEnabled = true;
            this.OpenTxtFileButton.IsEnabled = false;
        }

        private void SequenceNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void OpenTxtFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false,
                Title = "Выберите файл"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string filename = openFileDialog.FileName;
                MessageBox.Show(filename);
            }
        }

        private void StartTestsButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
