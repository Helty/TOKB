
namespace TFCS__FirstWork
{
    partial class SelectUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectUserForm));
            this.TableUserLoginFromDB = new System.Windows.Forms.DataGridView();
            this.UserLoginFromDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseButton = new System.Windows.Forms.Label();
            this.AboutProgramButton = new System.Windows.Forms.Label();
            this.SelectUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableUserLoginFromDB)).BeginInit();
            this.SuspendLayout();
            // 
            // TableUserLoginFromDB
            // 
            this.TableUserLoginFromDB.AllowUserToAddRows = false;
            this.TableUserLoginFromDB.AllowUserToDeleteRows = false;
            this.TableUserLoginFromDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableUserLoginFromDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserLoginFromDB});
            this.TableUserLoginFromDB.Location = new System.Drawing.Point(71, 77);
            this.TableUserLoginFromDB.Name = "TableUserLoginFromDB";
            this.TableUserLoginFromDB.ReadOnly = true;
            this.TableUserLoginFromDB.RowHeadersWidth = 51;
            this.TableUserLoginFromDB.RowTemplate.Height = 24;
            this.TableUserLoginFromDB.Size = new System.Drawing.Size(229, 143);
            this.TableUserLoginFromDB.TabIndex = 0;
            // 
            // UserLoginFromDB
            // 
            this.UserLoginFromDB.HeaderText = "Логин ";
            this.UserLoginFromDB.MinimumWidth = 6;
            this.UserLoginFromDB.Name = "UserLoginFromDB";
            this.UserLoginFromDB.ReadOnly = true;
            this.UserLoginFromDB.Width = 175;
            // 
            // CloseButton
            // 
            this.CloseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(271, 10);
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
            this.AboutProgramButton.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutProgramButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AboutProgramButton.Location = new System.Drawing.Point(12, 10);
            this.AboutProgramButton.Name = "AboutProgramButton";
            this.AboutProgramButton.Size = new System.Drawing.Size(180, 29);
            this.AboutProgramButton.TabIndex = 7;
            this.AboutProgramButton.Text = "О программе";
            this.AboutProgramButton.Click += new System.EventHandler(this.AboutProgramButton_Click);
            this.AboutProgramButton.MouseEnter += new System.EventHandler(this.AboutProgramButton_MouseEnter);
            this.AboutProgramButton.MouseLeave += new System.EventHandler(this.AboutProgramButton_MouseLeave);
            // 
            // SelectUserButton
            // 
            this.SelectUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectUserButton.Location = new System.Drawing.Point(134, 226);
            this.SelectUserButton.Name = "SelectUserButton";
            this.SelectUserButton.Size = new System.Drawing.Size(106, 37);
            this.SelectUserButton.TabIndex = 8;
            this.SelectUserButton.Text = "Выбрать";
            this.SelectUserButton.UseVisualStyleBackColor = true;
            this.SelectUserButton.Click += new System.EventHandler(this.SelectUserButton_Click);
            // 
            // SelectUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(361, 288);
            this.Controls.Add(this.SelectUserButton);
            this.Controls.Add(this.AboutProgramButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TableUserLoginFromDB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeUser";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChangeUserForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeUserForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.TableUserLoginFromDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableUserLoginFromDB;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label AboutProgramButton;
        private System.Windows.Forms.Button SelectUserButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLoginFromDB;
    }
}