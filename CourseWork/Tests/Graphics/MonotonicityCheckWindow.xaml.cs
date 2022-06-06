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
    public partial class MonotonicityCheckWindow : Window, IGraphicsTest
    {
        public MonotonicityCheckWindow(string sequenceNumber)
        {
            InitializeComponent();
        }

        public void СomputeDataToDisplay(string sequenceNumber)
        {
            throw new NotImplementedException();
        }
    }
}
