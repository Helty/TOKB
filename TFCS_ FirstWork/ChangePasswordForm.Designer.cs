
namespace TFCS__FirstWork
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.CloseButton = new System.Windows.Forms.Label();
            this.AboutProgramButton = new System.Windows.Forms.Label();
            this.UserPasswordOld = new System.Windows.Forms.TextBox();
            this.NewUserPassword = new System.Windows.Forms.TextBox();
            this.NewUserPasswordAgain = new System.Windows.Forms.TextBox();
            this.SaveNewPasswordAndContinueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(450, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(73, 25);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Назад";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // AboutProgramButton
            // 
            this.AboutProgramButton.AutoSize = true;
            this.AboutProgramButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutProgramButton.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutProgramButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AboutProgramButton.Location = new System.Drawing.Point(12, 9);
            this.AboutProgramButton.Name = "AboutProgramButton";
            this.AboutProgramButton.Size = new System.Drawing.Size(180, 29);
            this.AboutProgramButton.TabIndex = 6;
            this.AboutProgramButton.Text = "О программе";
            this.AboutProgramButton.Click += new System.EventHandler(this.AboutProgramButton_Click);
            this.AboutProgramButton.MouseEnter += new System.EventHandler(this.AboutProgramButton_MouseEnter);
            this.AboutProgramButton.MouseLeave += new System.EventHandler(this.AboutProgramButton_MouseLeave);
            // 
            // UserPasswordOld
            // 
            this.UserPasswordOld.BackColor = System.Drawing.Color.Linen;
            this.UserPasswordOld.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserPasswordOld.Location = new System.Drawing.Point(292, 51);
            this.UserPasswordOld.Name = "UserPasswordOld";
            this.UserPasswordOld.Size = new System.Drawing.Size(208, 53);
            this.UserPasswordOld.TabIndex = 7;
            this.UserPasswordOld.UseSystemPasswordChar = true;
            // 
            // NewUserPassword
            // 
            this.NewUserPassword.BackColor = System.Drawing.Color.Linen;
            this.NewUserPassword.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewUserPassword.Location = new System.Drawing.Point(292, 133);
            this.NewUserPassword.Name = "NewUserPassword";
            this.NewUserPassword.Size = new System.Drawing.Size(208, 53);
            this.NewUserPassword.TabIndex = 8;
            this.NewUserPassword.UseSystemPasswordChar = true;
            // 
            // NewUserPasswordAgain
            // 
            this.NewUserPasswordAgain.BackColor = System.Drawing.Color.Linen;
            this.NewUserPasswordAgain.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewUserPasswordAgain.Location = new System.Drawing.Point(292, 192);
            this.NewUserPasswordAgain.Name = "NewUserPasswordAgain";
            this.NewUserPasswordAgain.Size = new System.Drawing.Size(208, 53);
            this.NewUserPasswordAgain.TabIndex = 9;
            this.NewUserPasswordAgain.UseSystemPasswordChar = true;
            // 
            // SaveNewPasswordAndContinueButton
            // 
            this.SaveNewPasswordAndContinueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveNewPasswordAndContinueButton.Location = new System.Drawing.Point(292, 251);
            this.SaveNewPasswordAndContinueButton.Name = "SaveNewPasswordAndContinueButton";
            this.SaveNewPasswordAndContinueButton.Size = new System.Drawing.Size(208, 53);
            this.SaveNewPasswordAndContinueButton.TabIndex = 10;
            this.SaveNewPasswordAndContinueButton.Text = "Вохранить и продолжить";
            this.SaveNewPasswordAndContinueButton.UseVisualStyleBackColor = true;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 316);
            this.Controls.Add(this.SaveNewPasswordAndContinueButton);
            this.Controls.Add(this.NewUserPasswordAgain);
            this.Controls.Add(this.NewUserPassword);
            this.Controls.Add(this.UserPasswordOld);
            this.Controls.Add(this.AboutProgramButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangePasswordForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangePasswordForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label AboutProgramButton;
        private System.Windows.Forms.TextBox UserPasswordOld;
        private System.Windows.Forms.TextBox NewUserPassword;
        private System.Windows.Forms.TextBox NewUserPasswordAgain;
        private System.Windows.Forms.Button SaveNewPasswordAndContinueButton;
    }
}