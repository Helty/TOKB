using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CourseWork.Tests.Interfaces;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CourseWork.Tests
{
    public partial class AutocorrelationFunctionWindow : Window, IGraphicsTest
    {
        public AutocorrelationFunctionWindow(string sequenceNumber)
        {
            InitializeComponent();
            СomputeDataToDisplay();
        }

        public void СomputeDataToDisplay()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
