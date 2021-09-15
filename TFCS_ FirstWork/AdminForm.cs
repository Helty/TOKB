using System;
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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            CloseButton.BackColor = Color.Transparent;
            AboutProgramButton.BackColor = Color.Transparent;
            BackToAuthorizationButton.BackColor = Color.Transparent;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackToAuthorizationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
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

        private void BackToAuthorizationButton_MouseEnter(object sender, EventArgs e)
        {
            BackToAuthorizationButton.ForeColor = Color.Black;
        }

        private void BackToAuthorizationButton_MouseLeave(object sender, EventArgs e)
        {
            BackToAuthorizationButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void AdminForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void AdminForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        
    }
}
