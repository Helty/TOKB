using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFCS__FirstWork
{
    public partial class ChangeUserForm : Form
    {
        public ChangeUserForm()
        {
            InitializeComponent();
            CloseButton.BackColor = Color.Transparent;
            AboutProgramButton.BackColor = Color.Transparent;
            LoadDate();
        }

        private void LoadDate()
        {
            DataBase DataBase = new DataBase();

            DataBase.OpenConnection();

            SqlCommand Command = new SqlCommand("SELECT UserLogin FROM UsersData ORDER BY ID", DataBase.GetConnection());

            SqlDataReader Reader = Command.ExecuteReader();

            List<string[]> Data = new List<string[]>();

            while(Reader.Read())
            {
                Data.Add(new string[1]);

                Data[Data.Count-1][0] = Reader[0].ToString();
            }
            Reader.Close();

            DataBase.CloseConnection();

            foreach (string[] login in Data)
            {
                if(login != Data[0])
                {
                    TableUserLoginFromDB.Rows.Add(login);
                }
            }
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void AboutProgramButton_MouseEnter(object sender, EventArgs e)
        {
            AboutProgramButton.ForeColor = Color.Black;
        }

        private void AboutProgramButton_MouseLeave(object sender, EventArgs e)
        {
            AboutProgramButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void ChangeUserForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ChangeUserForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm("Admin");
            adminForm.Show();
        }

        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
