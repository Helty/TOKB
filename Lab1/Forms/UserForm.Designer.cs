
namespace TOKB
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.CloseButton = new System.Windows.Forms.Label();
            this.AboutProgramButton = new System.Windows.Forms.Label();
            this.BackToAuthorizationButton = new System.Windows.Forms.Label();
            this.ChangePasswordUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton.Location = new System.Drawing.Point(425, 11);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 25);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // AboutProgramButton
            // 
            this.AboutProgramButton.AutoSize = true;
            this.AboutProgramButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutProgramButton.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutProgramButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AboutProgramButton.Location = new System.Drawing.Point(12, 11);
            this.AboutProgramButton.Name = "AboutProgramButton";
            this.AboutProgramButton.Size = new System.Drawing.Size(133, 24);
            this.AboutProgramButton.TabIndex = 6;
            this.AboutProgramButton.Text = "О программе";
            this.AboutProgramButton.Click += new System.EventHandler(this.AboutProgramButton_Click);
            this.AboutProgramButton.MouseEnter += new System.EventHandler(this.AboutProgramButton_MouseEnter);
            this.AboutProgramButton.MouseLeave += new System.EventHandler(this.AboutProgramButton_MouseLeave);
            // 
            // BackToAuthorizationButton
            // 
            this.BackToAuthorizationButton.AutoSize = true;
            this.BackToAuthorizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToAuthorizationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToAuthorizationButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BackToAuthorizationButton.Location = new System.Drawing.Point(239, 213);
            this.BackToAuthorizationButton.Name = "BackToAuthorizationButton";
            this.BackToAuthorizationButton.Size = new System.Drawing.Size(192, 25);
            this.BackToAuthorizationButton.TabIndex = 8;
            this.BackToAuthorizationButton.Text = "Зайти за другого ";
            this.BackToAuthorizationButton.Click += new System.EventHandler(this.BackToAuthorizationButton_Click);
            this.BackToAuthorizationButton.MouseEnter += new System.EventHandler(this.BackToAuthorizationButton_MouseEnter);
            this.BackToAuthorizationButton.MouseLeave += new System.EventHandler(this.BackToAuthorizationButton_MouseLeave);
            // 
            // ChangePasswordUser
            // 
            this.ChangePasswordUser.Font = new System.Drawing.Font("Montserrat Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePasswordUser.Location = new System.Drawing.Point(12, 204);
            this.ChangePasswordUser.Name = "ChangePasswordUser";
            this.ChangePasswordUser.Size = new System.Drawing.Size(185, 34);
            this.ChangePasswordUser.TabIndex = 9;
            this.ChangePasswordUser.Text = "Сменить пароль";
            this.ChangePasswordUser.UseVisualStyleBackColor = true;
            this.ChangePasswordUser.Click += new System.EventHandler(this.ChangePasswordUser_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 250);
            this.Controls.Add(this.ChangePasswordUser);
            this.Controls.Add(this.BackToAuthorizationButton);
            this.Controls.Add(this.AboutProgramButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label AboutProgramButton;
        private System.Windows.Forms.Label BackToAuthorizationButton;
        private System.Windows.Forms.Button ChangePasswordUser;
    }
}