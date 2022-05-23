using System;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TOKB
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

            foreach (DriveInfo disk in DriveInfo.GetDrives())
            {
                DriverComboboxCheck.Items.Add(disk.ToString());
            }

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

            string diskForUserAvalible = "";
            foreach (string distName in DriverComboboxCheck.CheckedItems) diskForUserAvalible += (distName + " ");

            DataBase dataBase = new DataBase();
            Logging logging = new Logging();

            SqlCommand commandData = new SqlCommand("UPDATE TOKB.dbo.Users SET password_expires = @sqlFormattedDateToExpired WHERE login = @userLogin", dataBase.GetConnection());
            commandData.Parameters.AddWithValue("@sqlFormattedDateToExpired", sqlFormattedDateToExpired);
            commandData.Parameters.AddWithValue("@userLogin", loginGglobal);

            SqlCommand commandSizePassword = new SqlCommand("UPDATE TOKB.dbo.Users SET size_password = @sizePassword WHERE login = @userLogin", dataBase.GetConnection());
            commandSizePassword.Parameters.AddWithValue("@sizePassword", sizePassword);
            commandSizePassword.Parameters.AddWithValue("@userLogin", loginGglobal);

            SqlCommand commandDriveChoises = new SqlCommand("UPDATE TOKB.dbo.Users SET available_discs = @diskForUserAvalible WHERE login = @userLogin", dataBase.GetConnection());
            commandDriveChoises.Parameters.AddWithValue("@diskForUserAvalible", diskForUserAvalible);
            commandDriveChoises.Parameters.AddWithValue("@userLogin", loginGglobal);

            dataBase.OpenConnection();

            if (DifferentСharactersPasswordCheckBox.Checked)
            {
                SqlCommand commandUpgradePassword = new SqlCommand("UPDATE TOKB.dbo.Users SET is_hard_password = 1 WHERE login = @userLogin", dataBase.GetConnection());
                commandUpgradePassword.Parameters.AddWithValue("@userLogin", loginGglobal);
                if ((commandData.ExecuteNonQuery() == 1) && (commandSizePassword.ExecuteNonQuery() == 1) && (commandUpgradePassword.ExecuteNonQuery() == 1))
                {
                    logging.AdminUpdateDateTimeExpiredAndSizePasswordAndHardestPassword(loginGglobal);
                    MessageBox.Show("Все данные успешно изменены", "Уведомление", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка обновления данных", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else
            {
                if ((commandData.ExecuteNonQuery() == 1) &&
                    (commandSizePassword.ExecuteNonQuery() == 1) &&
                    (commandDriveChoises.ExecuteNonQuery() == 1))
                {
                    logging.AdminUpdateDateTimeExpiredAndSizePasswordAndDriveChoises(loginGglobal);
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
