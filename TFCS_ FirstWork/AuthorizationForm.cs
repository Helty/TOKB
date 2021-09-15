using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFCS__FirstWork
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            CloseButton.BackColor = Color.Transparent;
            AboutProgram.BackColor = Color.Transparent;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void AuthorizationForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void AuthorizationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AboutProgram_MouseEnter(object sender, EventArgs e)
        {
            AboutProgram.ForeColor = Color.Black;
        }

        private void AboutProgram_MouseLeave(object sender, EventArgs e)
        {
            AboutProgram.ForeColor = Color.White;
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            string LoginUser = UserLogin.Text;
            string PasswordUser = UserPassword.Text;

            DataBase DataBase = new DataBase();

            DataTable Table = new DataTable();

            SqlDataAdapter Adapter = new SqlDataAdapter();

            SqlCommand Command= new SqlCommand("SELECT * FROM UsersData WHERE UserLogin = @uL AND UserPassword = @uP", DataBase.GetConnection());

            Command.Parameters.Add("@uL", SqlDbType.VarChar).Value = LoginUser;
            Command.Parameters.Add("@uP", SqlDbType.VarChar).Value = PasswordUser;

            Adapter.SelectCommand = Command;
            Adapter.Fill(Table);

            if (Table.Rows.Count > 0)
            {
                if (LoginUser.ToLower() == "admin")
                {
                    this.Hide();
                    AdminForm AdminForm = new AdminForm();
                    AdminForm.Show();
                }
                else
                {
                    MessageBox.Show("Не верные данные!");
                }
            }
            else
            {
                MessageBox.Show("Не верные данные!");
            }
        }

        private void AboutProgram_Click(object sender, EventArgs e)
        {

        }
    }
}
