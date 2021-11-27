using System;
using System.Drawing;
using System.Windows.Forms;

namespace TFCS__FirstWork
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            CloseButton.BackColor = Color.Transparent;
            NameSurnameText.BackColor = Color.Transparent;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        Point lastPoint;
        private void AboutForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void AboutForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }
    }
}
