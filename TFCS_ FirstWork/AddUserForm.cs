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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
            CloseButton.BackColor = Color.Transparent;
            AboutProgramButton.BackColor = Color.Transparent;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm("admin");
            adminForm.Show();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
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

        private void AddUserForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void AddUserForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }
        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            if (NewUserLogin.Text.Length == 0 || NewUserPassword.Text.Length == 0)
            {
                MessageBox.Show("Введите логин/пароль", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            DataBase dataBase = new DataBase();
            Logging logging = new Logging();

            SqlCommand command = new SqlCommand("SELECT * FROM TOKB.dbo.Users WHERE login = @username", dataBase.GetConnection());
            command.Parameters.AddWithValue("@username", NewUserLogin.Text);
            dataBase.OpenConnection();
            if (command.ExecuteScalar() == null)
            {
                SqlCommand commandTwo = new SqlCommand("INSERT INTO TOKB.dbo.Users (login, password, is_frozen, size_password, is_first_login, is_hard_password) VALUES (@UserLogin, @UserPassword, @is_frozen, @size_password, @is_first_login, @is_hard_password)", dataBase.GetConnection());
                
                commandTwo.Parameters.AddWithValue("UserLogin", NewUserLogin.Text);
                commandTwo.Parameters.AddWithValue("UserPassword", NewUserPassword.Text);
                commandTwo.Parameters.AddWithValue("is_frozen", 0);
                commandTwo.Parameters.AddWithValue("size_password", 6);
                commandTwo.Parameters.AddWithValue("is_first_login", 1);
                commandTwo.Parameters.AddWithValue("is_hard_password", 0);

                if (commandTwo.ExecuteNonQuery() == 1)
                {
                    logging.UserAddFromAdmin(NewUserLogin.Text);

                    MessageBox.Show("Пользователь успешно добавлен в базу данных", "Уведомление", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Не удалось добавить пользователя", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
