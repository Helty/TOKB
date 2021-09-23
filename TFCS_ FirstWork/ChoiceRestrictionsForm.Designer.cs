
namespace TFCS__FirstWork
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
            this.NumericUpDownPassword = new System.Windows.Forms.NumericUpDown();
            this.MinimalPasswordLable = new System.Windows.Forms.Label();
            this.DifferentСharactersPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.TimeLifePasswordLable = new System.Windows.Forms.Label();
            this.SaveAndCloseButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.AboutProgramButton = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericUpDownPassword
            // 
            this.NumericUpDownPassword.Location = new System.Drawing.Point(348, 65);
            this.NumericUpDownPassword.Name = "NumericUpDownPassword";
            this.NumericUpDownPassword.Size = new System.Drawing.Size(58, 22);
            this.NumericUpDownPassword.TabIndex = 0;
            this.NumericUpDownPassword.ValueChanged += new System.EventHandler(this.NumericUpDownPassword_ValueChanged);
            // 
            // MinimalPasswordLable
            // 
            this.MinimalPasswordLable.AutoSize = true;
            this.MinimalPasswordLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimalPasswordLable.Location = new System.Drawing.Point(24, 64);
            this.MinimalPasswordLable.Name = "MinimalPasswordLable";
            this.MinimalPasswordLable.Size = new System.Drawing.Size(312, 20);
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
            // TimeLifePasswordLable
            // 
            this.TimeLifePasswordLable.AutoSize = true;
            this.TimeLifePasswordLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLifePasswordLable.Location = new System.Drawing.Point(24, 106);
            this.TimeLifePasswordLable.Name = "TimeLifePasswordLable";
            this.TimeLifePasswordLable.Size = new System.Drawing.Size(323, 20);
            this.TimeLifePasswordLable.TabIndex = 4;
            this.TimeLifePasswordLable.Text = "Действие пароля истекает через";
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveAndCloseButton.Location = new System.Drawing.Point(146, 191);
            this.SaveAndCloseButton.Name = "SaveAndCloseButton";
            this.SaveAndCloseButton.Size = new System.Drawing.Size(213, 33);
            this.SaveAndCloseButton.TabIndex = 5;
            this.SaveAndCloseButton.Text = "Сохранить и выйти";
            this.SaveAndCloseButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(464, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 25);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // AboutProgramButton
            // 
            this.AboutProgramButton.AutoSize = true;
            this.AboutProgramButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutProgramButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AboutProgramButton.Location = new System.Drawing.Point(24, 9);
            this.AboutProgramButton.Name = "AboutProgramButton";
            this.AboutProgramButton.Size = new System.Drawing.Size(150, 25);
            this.AboutProgramButton.TabIndex = 8;
            this.AboutProgramButton.Text = "О программе";
            this.AboutProgramButton.Click += new System.EventHandler(this.AboutProgramButton_Click);
            this.AboutProgramButton.MouseEnter += new System.EventHandler(this.AboutProgramButton_MouseEnter);
            this.AboutProgramButton.MouseLeave += new System.EventHandler(this.AboutProgramButton_MouseLeave);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(353, 104);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 22);
            this.numericUpDown1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(423, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "дней";
            // 
            // ChoiceRestrictionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.AboutProgramButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveAndCloseButton);
            this.Controls.Add(this.TimeLifePasswordLable);
            this.Controls.Add(this.DifferentСharactersPasswordCheckBox);
            this.Controls.Add(this.MinimalPasswordLable);
            this.Controls.Add(this.NumericUpDownPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoiceRestrictionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoiceRestrictions";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChoiceRestrictionsForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChoiceRestrictionsForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericUpDownPassword;
        private System.Windows.Forms.Label MinimalPasswordLable;
        private System.Windows.Forms.CheckBox DifferentСharactersPasswordCheckBox;
        private System.Windows.Forms.Label TimeLifePasswordLable;
        private System.Windows.Forms.Button SaveAndCloseButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label AboutProgramButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}