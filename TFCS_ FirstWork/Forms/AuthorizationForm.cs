using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            Logging logging = new Logging();

            DataTable Table = new DataTable();

            SqlDataAdapter Adapter = new SqlDataAdapter();

            SqlCommand Command = new SqlCommand("SELECT * FROM TOKB.dbo.Users WHERE login = @uL AND password = @uP", DataBase.GetConnection());

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
                    SqlCommand commandFrozen = new SqlCommand("SELECT * FROM TOKB.dbo.Users WHERE login = @uL AND is_frozen = 1", DataBase.GetConnection());
                    commandFrozen.Parameters.Add("@uL", SqlDbType.VarChar).Value = LoginUser;

                    DataBase.OpenConnection();

                    if (commandFrozen.ExecuteScalar() != null)
                    {
                        logging.UserTryLoginInFrozenAccount(LoginUser);
                        DataBase.CloseConnection();
                        MessageBox.Show("Ваш аккаунт заморожен", "Уведомление", MessageBoxButtons.OK);
                    }
                    else
                    {
                        SqlCommand commandPasswordExpired = new SqlCommand("SELECT password_expires FROM TOKB.dbo.Users WHERE login = @uL", DataBase.GetConnection());
                        commandPasswordExpired.Parameters.Add("@uL", SqlDbType.VarChar).Value = LoginUser;

                        SqlCommand commandIsFirstLogin = new SqlCommand("SELECT is_first_login FROM TOKB.dbo.Users WHERE login = @uL", DataBase.GetConnection());
                        commandIsFirstLogin.Parameters.Add("@uL", SqlDbType.VarChar).Value = LoginUser;

                        SqlDataReader readerPasswordExpired = commandPasswordExpired.ExecuteReader();

                        readerPasswordExpired.Read();
                        if (readerPasswordExpired.IsDBNull(0))
                        {
                            readerPasswordExpired.Close();
                            SqlDataReader readerIsFirstLogin = commandIsFirstLogin.ExecuteReader();
                            readerIsFirstLogin.Read();

                            var is_first_login = (bool)readerIsFirstLogin.GetValue(0);
                            readerIsFirstLogin.Close();


                            if (is_first_login)
                            {
                                logging.UserFirstlyLoginInAccount(LoginUser);
                                MessageBox.Show("Вы зашли впервые, смените пароль", "Уведомление", MessageBoxButtons.OK);
                                this.Hide();
                                ChangePasswordForm changePasswordForm = new ChangePasswordForm(LoginUser);
                                readerIsFirstLogin.Close();
                                changePasswordForm.Show();
                            }
                            else
                            {
                                logging.UserLoginInAccount(LoginUser);
                                this.Hide();
                                UserForm UserForm = new UserForm(LoginUser);
                                readerIsFirstLogin.Close();
                                UserForm.Show();
                            }
                        }
                        else
                        {
                            DateTime localDate = DateTime.Now;
                            DateTime dbTime = (DateTime)readerPasswordExpired.GetValue(0);
                            readerPasswordExpired.Close();

                            if (localDate < dbTime)
                            {
                                SqlDataReader readerIsFirstLogin = commandIsFirstLogin.ExecuteReader();
                                readerIsFirstLogin.Read();
                                if (commandIsFirstLogin.ExecuteScalar() != null)
                                {
                                    logging.UserFirstlyLoginInAccount(LoginUser);
                                    MessageBox.Show("Вы впервые зашли, смените пароль", "Уведомление", MessageBoxButtons.OK);
                                    this.Hide();
                                    ChangePasswordForm changePasswordForm = new ChangePasswordForm(LoginUser);
                                    readerIsFirstLogin.Close();
                                    changePasswordForm.Show();
                                }
                                else
                                {
                                    this.Hide();
                                    logging.UserLoginInAccount(LoginUser);
                                    UserForm UserForm = new UserForm(LoginUser);
                                    readerIsFirstLogin.Close();
                                    UserForm.Show();
                                }
                            }
                            else
                            {
                                logging.UserTryLoginWithOldPassword(LoginUser);
                                MessageBox.Show("Пароль больше не действительный, смените его", "Уведомление", MessageBoxButtons.OK);
                                this.Hide();
                                ChangePasswordForm changePasswordForm = new ChangePasswordForm(LoginUser);
                                changePasswordForm.Show();
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
