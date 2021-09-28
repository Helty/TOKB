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
    public partial class ChoiceRestrictionsForm : Form
    {
        static string loginGglobal;
        static int sizePassword = 6;
        static int dataToExpired;
        public ChoiceRestrictionsForm(string login)
        {
            InitializeComponent();
            CloseButton.BackColor = Color.Transparent;
            AboutProgramButton.BackColor = Color.Transparent;
            MinimalPasswordLable.BackColor = Color.Transparent;
            DifferentСharactersPasswordCheckBox.BackColor = Color.Transparent;
            passwordExpired.BackColor = Color.Transparent;
            daysLabel.BackColor = Color.Transparent;
            loginGglobal = login;
        }

        private void AboutProgramButton_MouseEnter(object sender, EventArgs e)
        {
            AboutProgramButton.ForeColor = Color.White;
        }

        private void AboutProgramButton_MouseLeave(object sender, EventArgs e)
        {
            AboutProgramButton.ForeColor = Color.Black;
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }

        Point lastPoint;
        private void ChoiceRestrictionsForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ChoiceRestrictionsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void NumericUpDownPassword_ValueChanged(object sender, EventArgs e)
        {
            while (numericUpDownPassword.Value < 6)
            {
                numericUpDownPassword.Value = 6;
            }

            sizePassword = (int)numericUpDownPassword.Value;
        }

        private void daysToExpired_ValueChanged(object sender, EventArgs e)
        {
            while (daysToExpired.Value < 1)
            {
                daysToExpired.Value = 1;
            }
            dataToExpired = (int)daysToExpired.Value;
        }

        private void SaveAndCloseButton_Click(object sender, EventArgs e)
        {
            DateTime sqlFormattedDateToExpired = DateTime.Now.AddDays(dataToExpired);

            DataBase dataBase = new DataBase();

            SqlCommand commandData = new SqlCommand("UPDATE TOKB.dbo.Users SET password_expires = @sqlFormattedDateToExpired WHERE Login = @userLogin", dataBase.GetConnection());
            commandData.Parameters.AddWithValue("@sqlFormattedDateToExpired", sqlFormattedDateToExpired);
            commandData.Parameters.AddWithValue("@userLogin", loginGglobal);

            SqlCommand commandSizePassword = new SqlCommand("UPDATE TOKB.dbo.Users SET size_password = @sizePassword WHERE Login = @userLogin", dataBase.GetConnection());
            commandSizePassword.Parameters.AddWithValue("@sizePassword", sizePassword);
            commandSizePassword.Parameters.AddWithValue("@userLogin", loginGglobal);
            
            dataBase.OpenConnection();

            if (DifferentСharactersPasswordCheckBox.Checked)
            {
                SqlCommand commandUpgradePassword = new SqlCommand("UPDATE TOKB.dbo.Users SET is_hard_password = 1 WHERE Login = @userLogin", dataBase.GetConnection());
                commandUpgradePassword.Parameters.AddWithValue("@userLogin", loginGglobal);
                if ((commandData.ExecuteNonQuery() == 1) && (commandSizePassword.ExecuteNonQuery() == 1) && (commandUpgradePassword.ExecuteNonQuery() == 1))
                {
                    MessageBox.Show("Все данные успешно изменены", "Уведомление", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка обновления данных", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else
            {
                if ((commandData.ExecuteNonQuery() == 1) && (commandSizePassword.ExecuteNonQuery() == 1))
                {
                    MessageBox.Show("Все данные успешно изменены", "Уведомление", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка обновления данных", "Ошибка", MessageBoxButtons.OK);
                }
            }
            dataBase.CloseConnection();
        }
    }
}
