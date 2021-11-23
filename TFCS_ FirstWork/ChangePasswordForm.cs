using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
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
            DataBase dataBase = new DataBase();
            SqlCommand commandIsFirstLogin = new SqlCommand("SELECT is_first_login FROM TOKB.dbo.Users WHERE login = @userLogin", dataBase.GetConnection());
            commandIsFirstLogin.Parameters.AddWithValue("@userLogin", login);

            dataBase.OpenConnection();

            SqlDataReader reader = commandIsFirstLogin.ExecuteReader();
            reader.Read();

            if ((bool)reader.GetValue(0) == true)
            {
                this.Hide();
                AuthorizationForm authorizationForm = new AuthorizationForm();
                dataBase.CloseConnection();
                authorizationForm.Show();
            }
            else
            {
                if (login.ToLower() == "admin")
                {
                    this.Hide();
                    AdminForm adminForm = new AdminForm(login);
                    dataBase.CloseConnection();
                    adminForm.Show();
                }
                else
                {
                    this.Hide();
                    UserForm UserForm = new UserForm(login);
                    dataBase.CloseConnection();
                    UserForm.Show();
                }
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
            Logging logging = new Logging();
            DataBase dataBase = new DataBase();
            SqlCommand command = new SqlCommand("SELECT password FROM TOKB.dbo.Users WHERE login = @userLogin", dataBase.GetConnection());
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

                SqlCommand commandHardPassword = new SqlCommand("SELECT * FROM TOKB.dbo.Users WHERE login = @userLogin AND is_hard_password = 1", dataBase.GetConnection());
                commandHardPassword.Parameters.AddWithValue("@userLogin", login);

                SqlCommand commandLongPassword = new SqlCommand("SELECT size_password FROM TOKB.dbo.Users WHERE login = @userLogin", dataBase.GetConnection());
                commandLongPassword.Parameters.AddWithValue("@userLogin", login);

                string pattern = "(?=[!@#$%])";
                Match m = Regex.Match(NewUserPassword.Text, pattern, RegexOptions.IgnoreCase);

                if ((commandHardPassword.ExecuteScalar() != null) && !(m.Success))
                {
                    MessageBox.Show("Не удалось обновить пароль, убедитесь что в вашем пароле присутствуют символы: @, !, #, $, %", "Ошибка", MessageBoxButtons.OK);
                    return;
                }

                SqlDataReader readerSizePassword = commandLongPassword.ExecuteReader();

                if (readerSizePassword.HasRows)
                {
                    readerSizePassword.Read();
                    object sizePassword = readerSizePassword.GetValue(0);
                    if(NewUserPassword.Text.Length < (int)sizePassword)
                    {
                        readerSizePassword.Close();
                        MessageBox.Show("Не удалось обновить пароль, убедитесь что вы ввели пароль длинной " + sizePassword.ToString(), "Ошибка", MessageBoxButtons.OK);
                        return;
                    }
                }
                readerSizePassword.Close();

                SqlCommand commandTwo = new SqlCommand("UPDATE TOKB.dbo.Users SET password = @newUserPassword WHERE login = @userLogin", dataBase.GetConnection());
                commandTwo.Parameters.AddWithValue("@newUserPassword", NewUserPassword.Text);
                commandTwo.Parameters.AddWithValue("@userLogin", login);

                if (commandTwo.ExecuteNonQuery() == 1)
                {                    
                    if (is_admin_account)
                    {
                        this.Hide();
                        AdminForm adminForm = new AdminForm(login);
                        adminForm.Show();
                    }
                    else
                    {
                        SqlCommand commandThree = new SqlCommand("UPDATE TOKB.dbo.Users SET is_first_login = 0 WHERE login = @userLogin", dataBase.GetConnection());
                        commandThree.Parameters.AddWithValue("@userLogin", login);

                        if (commandThree.ExecuteNonQuery() == 1)
                        {
                            logging.UserChangePasswordInAccount(login);
                            dataBase.CloseConnection();
                            this.Hide();
                            UserForm UserForm = new UserForm(login);
                            UserForm.Show();
                        }
                        else
                        {
                            dataBase.CloseConnection();
                            MessageBox.Show("Ошибка обновления переменной is_first_login", "Ошибка", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    dataBase.CloseConnection();
                    MessageBox.Show("Ошибка обновления пароля", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else
            {
                dataBase.CloseConnection();
                MessageBox.Show("Ошибка обновления пароля", "Ошибка", MessageBoxButtons.OK);
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
