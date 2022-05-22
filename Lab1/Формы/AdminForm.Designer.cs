
namespace TOKB
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.AddUserButton = new System.Windows.Forms.Button();
            this.ChangePasswordAdmin = new System.Windows.Forms.Button();
            this.CheckListUsers = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.AboutProgramButton = new System.Windows.Forms.Label();
            this.BackToAuthorizationButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddUserButton
            // 
            this.AddUserButton.Font = new System.Drawing.Font("Montserrat Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUserButton.Location = new System.Drawing.Point(46, 460);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(154, 54);
            this.AddUserButton.TabIndex = 0;
            this.AddUserButton.Text = "Добавить пользователя";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // ChangePasswordAdmin
            // 
            this.ChangePasswordAdmin.Font = new System.Drawing.Font("Montserrat Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePasswordAdmin.Location = new System.Drawing.Point(438, 460);
            this.ChangePasswordAdmin.Name = "ChangePasswordAdmin";
            this.ChangePasswordAdmin.Size = new System.Drawing.Size(154, 54);
            this.ChangePasswordAdmin.TabIndex = 1;
            this.ChangePasswordAdmin.Text = "Сменить пароль";
            this.ChangePasswordAdmin.UseVisualStyleBackColor = true;
            this.ChangePasswordAdmin.Click += new System.EventHandler(this.ChangePasswordAdmin_Click);
            // 
            // CheckListUsers
            // 
            this.CheckListUsers.Font = new System.Drawing.Font("Montserrat Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckListUsers.Location = new System.Drawing.Point(247, 460);
            this.CheckListUsers.Name = "CheckListUsers";
            this.CheckListUsers.Size = new System.Drawing.Size(150, 54);
            this.CheckListUsers.TabIndex = 2;
            this.CheckListUsers.Text = "Изменить пользователя";
            this.CheckListUsers.UseVisualStyleBackColor = true;
            this.CheckListUsers.Click += new System.EventHandler(this.CheckListUsers_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(585, 26);
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
            this.AboutProgramButton.Font = new System.Drawing.Font("Raleway Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutProgramButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AboutProgramButton.Location = new System.Drawing.Point(33, 28);
            this.AboutProgramButton.Name = "AboutProgramButton";
            this.AboutProgramButton.Size = new System.Drawing.Size(143, 24);
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
            this.BackToAuthorizationButton.Location = new System.Drawing.Point(367, 26);
            this.BackToAuthorizationButton.Name = "BackToAuthorizationButton";
            this.BackToAuthorizationButton.Size = new System.Drawing.Size(192, 25);
            this.BackToAuthorizationButton.TabIndex = 7;
            this.BackToAuthorizationButton.Text = "Зайти за другого ";
            this.BackToAuthorizationButton.Click += new System.EventHandler(this.BackToAuthorizationButton_Click);
            this.BackToAuthorizationButton.MouseEnter += new System.EventHandler(this.BackToAuthorizationButton_MouseEnter);
            this.BackToAuthorizationButton.MouseLeave += new System.EventHandler(this.BackToAuthorizationButton_MouseLeave);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 566);
            this.Controls.Add(this.BackToAuthorizationButton);
            this.Controls.Add(this.AboutProgramButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CheckListUsers);
            this.Controls.Add(this.ChangePasswordAdmin);
            this.Controls.Add(this.AddUserButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button ChangePasswordAdmin;
        private System.Windows.Forms.Button CheckListUsers;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label AboutProgramButton;
        private System.Windows.Forms.Label BackToAuthorizationButton;
    }
}