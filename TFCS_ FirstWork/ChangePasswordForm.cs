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
    public partial class ChangePasswordForm : Form
    {
        string login;
        public ChangePasswordForm(string Login)
        {
            InitializeComponent();
            CloseButton.BackColor = Color.Transparent;
            AboutProgramButton.BackColor = Color.Transparent;
            login = Login;   
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (login.ToLower() == "admin")
            {
                this.Hide();
                AdminForm adminForm = new AdminForm(login);
                adminForm.Show();
            }
            else
            {
                this.Hide();
                UserForm UserForm = new UserForm(login);
                UserForm.Show();
            }
        }

        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
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
        private void ChangePasswordForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ChangePasswordForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ChangePassword(bool is_admin_account)
        {
            DataBase dataBase = new DataBase();
            SqlCommand command = new SqlCommand("SELECT Password FROM TOKB.dbo.Users WHERE Login = @userLogin", dataBase.GetConnection());
            command.Parameters.AddWithValue("@userLogin", login);

            dataBase.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
            }
            if ((reader.GetString(0) == UserPasswordOld.Text) && (NewUserPassword.Text != UserPasswordOld.Text) && (NewUserPassword.Text == NewUserPasswordAgain.Text))
            {
                reader.Close();

                SqlCommand commandTwo = new SqlCommand("UPDATE TOKB.dbo.Users SET Password = @newUserPassword WHERE Login = @userLogin", dataBase.GetConnection());
                commandTwo.Parameters.AddWithValue("@newUserPassword", NewUserPassword.Text);
                commandTwo.Parameters.AddWithValue("@userLogin", login);

                if (commandTwo.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Успешное обновление пароля", "Уведомление", MessageBoxButtons.OK);
                    dataBase.CloseConnection();
                    if(is_admin_account)
                    {
                        this.Hide();
                        AdminForm adminForm = new AdminForm(login);
                        adminForm.Show();
                    }
                    else
                    {
                        this.Hide();
                        UserForm UserForm = new UserForm(login);
                        UserForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка обновления пароля", "Ошибка", MessageBoxButtons.OK);
                }
            }
        }

        private void SaveNewPasswordAndContinueButton_Click(object sender, EventArgs e)
        {
            if (login.ToLower() == "admin")
            {
                ChangePassword(true);
            }
            else
            {
                ChangePassword(false);
            }
        }
    }
}
