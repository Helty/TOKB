using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TFCS__FirstWork
{
    public partial class SelectUserForm : Form
    {
        public SelectUserForm()
        {
            InitializeComponent();
            CloseButton.BackColor = Color.Transparent;
            AboutProgramButton.BackColor = Color.Transparent;
            LoadDate();
        }

        private void LoadDate()
        {
            DataBase DataBase = new DataBase();

            DataBase.OpenConnection();

            SqlCommand Command = new SqlCommand("SELECT login FROM TOKB.dbo.Users ORDER BY id", DataBase.GetConnection());

            SqlDataReader Reader = Command.ExecuteReader();

            List<string[]> Data = new List<string[]>();

            while (Reader.Read())
            {
                Data.Add(new string[1]);
                Data[Data.Count - 1][0] = Reader[0].ToString();
            }
            Reader.Close();

            DataBase.CloseConnection();

            foreach (string[] login in Data)
            {
                if (login != Data[0])
                {
                    TableUserLoginFromDB.Rows.Add(login);
                }
            }
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
            AdminForm adminForm = new AdminForm("Admin");
            adminForm.Show();
        }

        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void SelectUserButton_Click(object sender, EventArgs e)
        {
            string login;

            Int32 selectedCellCount = TableUserLoginFromDB.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount == 1)
            {
                login = TableUserLoginFromDB.SelectedCells[0].Value.ToString();
                this.Hide();
                ChangeUserForm changeUserForm = new ChangeUserForm(login);
                changeUserForm.Show();
            }
            else
            {
                MessageBox.Show("Ошибка выбора, попробуйте заново",
                                "Сообщение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly
                                );
            }
        }
    }
}
