
namespace TFCS__FirstWork
{
    partial class ChangeUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUserForm));
            this.FreezAccountCheckBox = new System.Windows.Forms.CheckBox();
            this.SetRestrictionsButton = new System.Windows.Forms.Button();
            this.DeleteUserAndCansleButton = new System.Windows.Forms.Button();
            this.SaveChangesAndCloseButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.AboutProgramButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FreezAccountCheckBox
            // 
            this.FreezAccountCheckBox.AutoSize = true;
            this.FreezAccountCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FreezAccountCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreezAccountCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.FreezAccountCheckBox.Location = new System.Drawing.Point(158, 53);
            this.FreezAccountCheckBox.Name = "FreezAccountCheckBox";
            this.FreezAccountCheckBox.Size = new System.Drawing.Size(157, 21);
            this.FreezAccountCheckBox.TabIndex = 0;
            this.FreezAccountCheckBox.Text = "Заморозить вход";
            this.FreezAccountCheckBox.UseVisualStyleBackColor = true;
            // 
            // SetRestrictionsButton
            // 
            this.SetRestrictionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SetRestrictionsButton.Location = new System.Drawing.Point(127, 80);
            this.SetRestrictionsButton.Name = "SetRestrictionsButton";
            this.SetRestrictionsButton.Size = new System.Drawing.Size(215, 39);
            this.SetRestrictionsButton.TabIndex = 1;
            this.SetRestrictionsButton.Text = "Установить ограничения";
            this.SetRestrictionsButton.UseVisualStyleBackColor = true;
            this.SetRestrictionsButton.Click += new System.EventHandler(this.SetRestrictionsButton_Click);
            // 
            // DeleteUserAndCansleButton
            // 
            this.DeleteUserAndCansleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteUserAndCansleButton.Location = new System.Drawing.Point(237, 178);
            this.DeleteUserAndCansleButton.Name = "DeleteUserAndCansleButton";
            this.DeleteUserAndCansleButton.Size = new System.Drawing.Size(215, 46);
            this.DeleteUserAndCansleButton.TabIndex = 2;
            this.DeleteUserAndCansleButton.Text = "Удалить пользователя и вернуться назад";
            this.DeleteUserAndCansleButton.UseVisualStyleBackColor = true;
            this.DeleteUserAndCansleButton.Click += new System.EventHandler(this.DeleteUserAndCansleButton_Click);
            // 
            // SaveChangesAndCloseButton
            // 
            this.SaveChangesAndCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChangesAndCloseButton.Location = new System.Drawing.Point(16, 178);
            this.SaveChangesAndCloseButton.Name = "SaveChangesAndCloseButton";
            this.SaveChangesAndCloseButton.Size = new System.Drawing.Size(215, 46);
            this.SaveChangesAndCloseButton.TabIndex = 3;
            this.SaveChangesAndCloseButton.Text = "Сохранить изменения и вернуться назад";
            this.SaveChangesAndCloseButton.UseVisualStyleBackColor = true;
            this.SaveChangesAndCloseButton.Click += new System.EventHandler(this.SaveChangesAndCloseButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(379, 11);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(73, 25);
            this.CloseButton.TabIndex = 5;
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
            // ChangeUserForm
            // 
            this.AccessibleName = " ";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(465, 236);
            this.Controls.Add(this.AboutProgramButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveChangesAndCloseButton);
            this.Controls.Add(this.DeleteUserAndCansleButton);
            this.Controls.Add(this.SetRestrictionsButton);
            this.Controls.Add(this.FreezAccountCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "ChangeUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeUser";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeUserForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeUserForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox FreezAccountCheckBox;
        private System.Windows.Forms.Button SetRestrictionsButton;
        private System.Windows.Forms.Button DeleteUserAndCansleButton;
        private System.Windows.Forms.Button SaveChangesAndCloseButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label AboutProgramButton;
    }
}