﻿
namespace TOKB
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.NameSurnameText = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.InformationTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameSurnameText
            // 
            this.NameSurnameText.AutoSize = true;
            this.NameSurnameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameSurnameText.Location = new System.Drawing.Point(319, 338);
            this.NameSurnameText.Name = "NameSurnameText";
            this.NameSurnameText.Size = new System.Drawing.Size(320, 29);
            this.NameSurnameText.TabIndex = 0;
            this.NameSurnameText.Text = "Шестаков Андрей БИ-31";
            // 
            // CloseButton
            // 
            this.CloseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(612, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 25);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // InformationTextBox
            // 
            this.InformationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformationTextBox.Location = new System.Drawing.Point(54, 64);
            this.InformationTextBox.Multiline = true;
            this.InformationTextBox.Name = "InformationTextBox";
            this.InformationTextBox.ReadOnly = true;
            this.InformationTextBox.Size = new System.Drawing.Size(238, 233);
            this.InformationTextBox.TabIndex = 6;
            this.InformationTextBox.TabStop = false;
            this.InformationTextBox.Text = resources.GetString("InformationTextBox.Text");
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(666, 376);
            this.Controls.Add(this.InformationTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.NameSurnameText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AboutForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AboutForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameSurnameText;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.TextBox InformationTextBox;
    }
}