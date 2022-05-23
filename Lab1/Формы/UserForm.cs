using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace TOKB
{
    public partial class UserForm : Form
    {
        string login;
        public UserForm(string Login)
        {
            InitializeComponent();

            CloseButton.BackColor = Color.Transparent;
            AboutProgramButton.BackColor = Color.Transparent;
            BackToAuthorizationButton.BackColor = Color.Transparent;
            login = Login;

            DataBase dataBase = new DataBase();
            dataBase.OpenConnection();

            SqlCommand discUserCommand = new SqlCommand("SELECT TOKB.dbo.Users.available_discs FROM TOKB.dbo.Users WHERE login = @UserLogin", dataBase.GetConnection());
            discUserCommand.Parameters.AddWithValue("UserLogin", Login);

            try
            {
                SqlDataReader discUserReader = discUserCommand.ExecuteReader();
                discUserReader.Read();
                DisksComboBox.Items.AddRange(discUserReader[0].ToString().Split(' '));
                discUserReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }

            dataBase.CloseConnection();
        }

        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void BackToAuthorizationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }

        Point lastPoint;
        private void UserForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void UserForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Logging logging = new Logging();
            logging.UserLogoutFromAccount(login);
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }

        private void AboutProgramButton_MouseEnter(object sender, EventArgs e)
        {
            AboutProgramButton.ForeColor = Color.White;
        }

        private void AboutProgramButton_MouseLeave(object sender, EventArgs e)
        {
            AboutProgramButton.ForeColor = Color.Black;
        }

        private void BackToAuthorizationButton_MouseEnter(object sender, EventArgs e)
        {
            BackToAuthorizationButton.ForeColor = Color.Black;
        }

        private void BackToAuthorizationButton_MouseLeave(object sender, EventArgs e)
        {
            BackToAuthorizationButton.ForeColor = Color.White;
        }

        private void ChangePasswordUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(login);
            changePasswordForm.Show();
        }

        private void OpenDiskButton_Click(object sender, EventArgs e)
        {
            string diskPath = DisksComboBox.SelectedItem.ToString();

            if (Directory.Exists(diskPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = diskPath,
                    FileName = "explorer.exe"
                };
                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", diskPath));
            }
        }
    }
}
