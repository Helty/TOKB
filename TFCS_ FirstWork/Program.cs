using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFCS__FirstWork
{
    static class Program
    {
        [STAThread] // Для WinForm ипользуется однопоточность, так как многопоточность данная технология не поддерживает
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            Application.Run(new AuthorizationForm());
        }
    }
}
