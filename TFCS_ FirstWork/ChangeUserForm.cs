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
        string loginGlobal;
        public ChangeUserForm(string UserLogIn)
        {
            InitializeComponent();
            CloseButton.BackColor = Color.Transparent;
            AboutProgramButton.BackColor = Color.Transparent;
            UnFreezAccountCheckBox.BackColor = Color.Transparent;
            FreezAccountCheckBox.BackColor = Color.Transparent;
            loginGlobal = UserLogIn;
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
            SelectUserForm selectUserForm = new SelectUserForm();
            selectUserForm.Show();
        }
        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
        private void SetRestrictionsButton_Click(object sender, EventArgs e)
        {
            ChoiceRestrictionsForm choiceRestrictionsForm = new ChoiceRestrictionsForm(loginGlobal);
            choiceRestrictionsForm.Show();
        }
        private void UserActionButton_Click(object sender, EventArgs e)
        {
            UserActionsForm userActionsForm = new UserActionsForm(loginGlobal);
            userActionsForm.Show();
        }
        private void SaveChangesAndCloseButton_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            Logging logging = new Logging();
            SqlCommand commandFrozen = new SqlCommand("UPDATE TOKB.dbo.Users SET is_frozen = 1 WHERE login = @userLogin", dataBase.GetConnection());
            commandFrozen.Parameters.AddWithValue("@userLogin", loginGlobal);

            SqlCommand commandUnFrozen = new SqlCommand("UPDATE TOKB.dbo.Users SET is_frozen = 0 WHERE login = @userLogin", dataBase.GetConnection());
            commandUnFrozen.Parameters.AddWithValue("@userLogin", loginGlobal);

            dataBase.OpenConnection();

            if (FreezAccountCheckBox.Checked && !UnFreezAccountCheckBox.Checked)
            {
                try
                {
                    commandFrozen.ExecuteNonQuery();
                    logging.AdminFrozenUser(loginGlobal);
                    MessageBox.Show("Пользователь успешно заморожен", "Уведомление", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Пользователя не удалось заморозить", "Ошибка", MessageBoxButtons.OK);
                }   
            }
            else if (!FreezAccountCheckBox.Checked && UnFreezAccountCheckBox.Checked)
            {
                try
                {
                    commandUnFrozen.ExecuteNonQuery();
                    logging.AdminUnFrozenUser(loginGlobal);
                    MessageBox.Show("Пользователь успешно разморожен", "Уведомление", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Пользователя не удалось разморозить", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else if (FreezAccountCheckBox.Checked && UnFreezAccountCheckBox.Checked)
            {
                MessageBox.Show("Нельзя пользователя заблокировать и разблокировать одновременно", "Ошибка", MessageBoxButtons.OK);
            }

            dataBase.CloseConnection();

            this.Hide();
            SelectUserForm selectUserForm = new SelectUserForm();
            selectUserForm.Show();
        }
        private void DeleteUserAndCansleButton_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            SqlCommand commandDelete = new SqlCommand("DELETE TOKB.dbo.Users WHERE login = @userLogin", dataBase.GetConnection());
            commandDelete.Parameters.AddWithValue("@userLogin", loginGlobal);

            dataBase.OpenConnection();

            if(commandDelete.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Все данные о пользователе успешно удалены", "Уведомление", MessageBoxButtons.OK);
            }
            dataBase.CloseConnection();

            this.Hide();
            SelectUserForm selectUserForm = new SelectUserForm();
            selectUserForm.Show();
        }
    }
}
