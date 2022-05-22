
namespace TOKB
{
    partial class ChoiceRestrictionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceRestrictionsForm));
            this.numericUpDownPassword = new System.Windows.Forms.NumericUpDown();
            this.MinimalPasswordLable = new System.Windows.Forms.Label();
            this.DifferentСharactersPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveAndCloseButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.AboutProgramButton = new System.Windows.Forms.Label();
            this.daysToExpired = new System.Windows.Forms.NumericUpDown();
            this.daysLabel = new System.Windows.Forms.Label();
            this.passwordExpired = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysToExpired)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPassword
            // 
            this.numericUpDownPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownPassword.Location = new System.Drawing.Point(335, 63);
            this.numericUpDownPassword.Name = "numericUpDownPassword";
            this.numericUpDownPassword.Size = new System.Drawing.Size(58, 24);
            this.numericUpDownPassword.TabIndex = 0;
            this.numericUpDownPassword.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownPassword.ValueChanged += new System.EventHandler(this.NumericUpDownPassword_ValueChanged);
            // 
            // MinimalPasswordLable
            // 
            this.MinimalPasswordLable.AutoSize = true;
            this.MinimalPasswordLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimalPasswordLable.Location = new System.Drawing.Point(28, 69);
            this.MinimalPasswordLable.Name = "MinimalPasswordLable";
            this.MinimalPasswordLable.Size = new System.Drawing.Size(263, 18);
            this.MinimalPasswordLable.TabIndex = 1;
            this.MinimalPasswordLable.Text = "Минимальная длина для пароля";
            // 
            // DifferentСharactersPasswordCheckBox
            // 
            this.DifferentСharactersPasswordCheckBox.AutoSize = true;
            this.DifferentСharactersPasswordCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DifferentСharactersPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifferentСharactersPasswordCheckBox.Location = new System.Drawing.Point(28, 151);
            this.DifferentСharactersPasswordCheckBox.Name = "DifferentСharactersPasswordCheckBox";
            this.DifferentСharactersPasswordCheckBox.Size = new System.Drawing.Size(450, 22);
            this.DifferentСharactersPasswordCheckBox.TabIndex = 2;
            this.DifferentСharactersPasswordCheckBox.Text = "Использовать в пароле различные группы символов";
            this.DifferentСharactersPasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveAndCloseButton.Location = new System.Drawing.Point(180, 199);
            this.SaveAndCloseButton.Name = "SaveAndCloseButton";
            this.SaveAndCloseButton.Size = new System.Drawing.Size(213, 33);
            this.SaveAndCloseButton.TabIndex = 5;
            this.SaveAndCloseButton.Text = "Сохранить и выйти";
            this.SaveAndCloseButton.UseVisualStyleBackColor = true;
            this.SaveAndCloseButton.Click += new System.EventHandler(this.SaveAndCloseButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(490, 9);
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
            this.AboutProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutProgramButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AboutProgramButton.Location = new System.Drawing.Point(24, 9);
            this.AboutProgramButton.Name = "AboutProgramButton";
            this.AboutProgramButton.Size = new System.Drawing.Size(150, 25);
            this.AboutProgramButton.TabIndex = 8;
            this.AboutProgramButton.Text = "О программе";
            this.AboutProgramButton.Click += new System.EventHandler(this.AboutProgramButton_Click);
            this.AboutProgramButton.MouseEnter += new System.EventHandler(this.AboutProgramButton_MouseEnter);
            this.AboutProgramButton.MouseLeave += new System.EventHandler(this.AboutProgramButton_MouseLeave);
            // 
            // daysToExpired
            // 
            this.daysToExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daysToExpired.Location = new System.Drawing.Point(335, 106);
            this.daysToExpired.Name = "daysToExpired";
            this.daysToExpired.Size = new System.Drawing.Size(58, 24);
            this.daysToExpired.TabIndex = 9;
            this.daysToExpired.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daysToExpired.ValueChanged += new System.EventHandler(this.daysToExpired_ValueChanged);
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daysLabel.Location = new System.Drawing.Point(423, 106);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(55, 20);
            this.daysLabel.TabIndex = 10;
            this.daysLabel.Text = "дней";
            // 
            // passwordExpired
            // 
            this.passwordExpired.AutoSize = true;
            this.passwordExpired.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordExpired.Location = new System.Drawing.Point(28, 111);
            this.passwordExpired.Name = "passwordExpired";
            this.passwordExpired.Size = new System.Drawing.Size(269, 18);
            this.passwordExpired.TabIndex = 11;
            this.passwordExpired.Text = "Действие пароля истекает через";
            // 
            // ChoiceRestrictionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 269);
            this.Controls.Add(this.passwordExpired);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.daysToExpired);
            this.Controls.Add(this.AboutProgramButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveAndCloseButton);
            this.Controls.Add(this.DifferentСharactersPasswordCheckBox);
            this.Controls.Add(this.MinimalPasswordLable);
            this.Controls.Add(this.numericUpDownPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoiceRestrictionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoiceRestrictions";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChoiceRestrictionsForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoiceRestrictionsForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysToExpired)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownPassword;
        private System.Windows.Forms.Label MinimalPasswordLable;
        private System.Windows.Forms.CheckBox DifferentСharactersPasswordCheckBox;
        private System.Windows.Forms.Button SaveAndCloseButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label AboutProgramButton;
        private System.Windows.Forms.NumericUpDown daysToExpired;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label passwordExpired;
    }
}