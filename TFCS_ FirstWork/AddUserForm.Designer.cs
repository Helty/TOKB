
namespace TFCS__FirstWork
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.NewUserLogin = new System.Windows.Forms.TextBox();
            this.NewUserPassword = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Label();
            this.AboutProgramButton = new System.Windows.Forms.Label();
            this.AddNewUserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EstablishingRestrictions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewUserLogin
            // 
            this.NewUserLogin.BackColor = System.Drawing.Color.Linen;
            this.NewUserLogin.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewUserLogin.Location = new System.Drawing.Point(106, 236);
            this.NewUserLogin.Name = "NewUserLogin";
            this.NewUserLogin.Size = new System.Drawing.Size(208, 53);
            this.NewUserLogin.TabIndex = 1;
            // 
            // NewUserPassword
            // 
            this.NewUserPassword.BackColor = System.Drawing.Color.Linen;
            this.NewUserPassword.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewUserPassword.Location = new System.Drawing.Point(106, 295);
            this.NewUserPassword.Name = "NewUserPassword";
            this.NewUserPassword.Size = new System.Drawing.Size(208, 53);
            this.NewUserPassword.TabIndex = 5;
            this.NewUserPassword.UseSystemPasswordChar = true;
            // 
            // CloseButton
            // 
            this.CloseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(311, 11);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(73, 25);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Назад";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // AboutProgramButton
            // 
            this.AboutProgramButton.AutoSize = true;
            this.AboutProgramButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutProgramButton.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutProgramButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AboutProgramButton.Location = new System.Drawing.Point(12, 11);
            this.AboutProgramButton.Name = "AboutProgramButton";
            this.AboutProgramButton.Size = new System.Drawing.Size(133, 24);
            this.AboutProgramButton.TabIndex = 7;
            this.AboutProgramButton.Text = "О программе";
            this.AboutProgramButton.Click += new System.EventHandler(this.AboutProgramButton_Click);
            this.AboutProgramButton.MouseEnter += new System.EventHandler(this.AboutProgramButton_MouseEnter);
            this.AboutProgramButton.MouseLeave += new System.EventHandler(this.AboutProgramButton_MouseLeave);
            // 
            // AddNewUserButton
            // 
            this.AddNewUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewUserButton.Font = new System.Drawing.Font("Bauhaus 93", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewUserButton.Location = new System.Drawing.Point(160, 417);
            this.AddNewUserButton.Name = "AddNewUserButton";
            this.AddNewUserButton.Size = new System.Drawing.Size(105, 36);
            this.AddNewUserButton.TabIndex = 8;
            this.AddNewUserButton.Text = "Добавить";
            this.AddNewUserButton.UseVisualStyleBackColor = true;
            this.AddNewUserButton.Click += new System.EventHandler(this.AddNewUserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(138, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 12;
            // 
            // EstablishingRestrictions
            // 
            this.EstablishingRestrictions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EstablishingRestrictions.Location = new System.Drawing.Point(106, 354);
            this.EstablishingRestrictions.Name = "EstablishingRestrictions";
            this.EstablishingRestrictions.Size = new System.Drawing.Size(208, 57);
            this.EstablishingRestrictions.TabIndex = 13;
            this.EstablishingRestrictions.TabStop = false;
            this.EstablishingRestrictions.Text = "Установление ограничений";
            this.EstablishingRestrictions.UseVisualStyleBackColor = true;
            this.EstablishingRestrictions.Click += new System.EventHandler(this.EstablishingRestrictions_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(412, 548);
            this.Controls.Add(this.EstablishingRestrictions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddNewUserButton);
            this.Controls.Add(this.AboutProgramButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.NewUserPassword);
            this.Controls.Add(this.NewUserLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUserForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddUserForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddUserForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewUserLogin;
        private System.Windows.Forms.TextBox NewUserPassword;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label AboutProgramButton;
        private System.Windows.Forms.Button AddNewUserButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EstablishingRestrictions;
    }
}