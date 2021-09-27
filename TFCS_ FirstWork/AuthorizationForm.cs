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
            AboutProgramButton.BackColor = Color.Transparent;
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
            AboutProgramButton.ForeColor = Color.Black;
        }

        private void AboutProgram_MouseLeave(object sender, EventArgs e)
        {
            AboutProgramButton.ForeColor = Color.White;
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            string LoginUser = UserLogin.Text;
            string PasswordUser = UserPassword.Text;

            DataBase DataBase = new DataBase();

            DataTable Table = new DataTable();

            SqlDataAdapter Adapter = new SqlDataAdapter();

            SqlCommand Command = new SqlCommand("SELECT * FROM TOKB.dbo.Users WHERE Login = @uL AND Password = @uP", DataBase.GetConnection());

            Command.Parameters.Add("@uL", SqlDbType.VarChar).Value = LoginUser;
            Command.Parameters.Add("@uP", SqlDbType.VarChar).Value = PasswordUser;

            Adapter.SelectCommand = Command;
            Adapter.Fill(Table);

            if (Table.Rows.Count > 0)
            {
                if (LoginUser.ToLower() == "admin")
                {
                    this.Hide();
                    AdminForm AdminForm = new AdminForm(LoginUser);
                    AdminForm.Show();
                }
                else
                {
                    SqlCommand commandFrozen = new SqlCommand("SELECT * FROM TOKB.dbo.Users WHERE Login = @uL AND is_frozen = 1", DataBase.GetConnection());
                    commandFrozen.Parameters.Add("@uL", SqlDbType.VarChar).Value = LoginUser;

                    DataBase.OpenConnection();

                    if (commandFrozen.ExecuteScalar() != null)
                    {
                        DataBase.CloseConnection();
                        MessageBox.Show("Ваш аккаунт заморожен", "Уведомление", MessageBoxButtons.OK);
                    }
                    else
                    {
                        SqlCommand commandPasswordExpired = new SqlCommand("SELECT password_expires FROM TOKB.dbo.Users WHERE Login = @uL", DataBase.GetConnection());
                        commandPasswordExpired.Parameters.Add("@uL", SqlDbType.VarChar).Value = LoginUser;

                        DateTime localDate = DateTime.Now;

                        if (localDate >= (DateTime)commandPasswordExpired.ExecuteScalar())
                        {
                            MessageBox.Show("Пароль больше не действительный, смените его", "Уведомление", MessageBoxButtons.OK);
                            this.Hide();
                            ChangePasswordForm changePasswordForm = new ChangePasswordForm(LoginUser);
                            changePasswordForm.Show();
                        }
                        else
                        {
                            SqlCommand commandIsFirstLogin = new SqlCommand("SELECT * FROM TOKB.dbo.Users WHERE Login = @uL AND is_first_login = 1", DataBase.GetConnection());
                            commandIsFirstLogin.Parameters.Add("@uL", SqlDbType.VarChar).Value = LoginUser;

                            if (commandIsFirstLogin.ExecuteScalar() != null)
                            {
                                this.Hide();
                                ChangePasswordForm changePasswordForm = new ChangePasswordForm(LoginUser);
                                changePasswordForm.Show();
                            }
                            else
                            {
                                this.Hide();
                                UserForm UserForm = new UserForm(LoginUser);
                                UserForm.Show();
                            }
                        }
                    }                   
                }
            }
            else
            {
                DataBase.CloseConnection();
                MessageBox.Show("Не верные данные!");
            }
        }

        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
