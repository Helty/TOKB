﻿using System;
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
    public partial class ChangeUserForm : Form
    {
        public ChangeUserForm()
        {
            InitializeComponent();
            CloseButton.BackColor = Color.Transparent;
            AboutProgramButton.BackColor = Color.Transparent;
            FreezAccountCheckBox.BackColor = Color.Transparent;
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
            CloseButton.ForeColor = Color.Black;
        }

        private void AboutProgramButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
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

        private void SetRestrictionsButton_Click(object sender, EventArgs e)
        {
            return;
        }
        private void SaveChangesAndCloseButton_Click(object sender, EventArgs e)
        {
            return;
        }
        private void DeleteUserAndCansleButton_Click(object sender, EventArgs e)
        {
            return;
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            return;
        }
        private void AboutProgramButton_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
