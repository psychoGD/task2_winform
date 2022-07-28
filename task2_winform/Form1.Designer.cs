namespace task2_winform
{
    partial class RegisterForm
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
            this.borderpnl = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.exitlbl = new System.Windows.Forms.Label();
            this.componentsPnl = new System.Windows.Forms.Panel();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTBLbl = new System.Windows.Forms.Label();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.infoButton = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.borderpnl.SuspendLayout();
            this.componentsPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderpnl
            // 
            this.borderpnl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.borderpnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.borderpnl.Controls.Add(this.titleLbl);
            this.borderpnl.Controls.Add(this.exitlbl);
            this.borderpnl.Location = new System.Drawing.Point(-9, -2);
            this.borderpnl.Name = "borderpnl";
            this.borderpnl.Size = new System.Drawing.Size(1005, 37);
            this.borderpnl.TabIndex = 0;
            this.borderpnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderpnl_MouseDown);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(16, 2);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(197, 34);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "Register Form";
            // 
            // exitlbl
            // 
            this.exitlbl.AutoSize = true;
            this.exitlbl.BackColor = System.Drawing.Color.Transparent;
            this.exitlbl.ForeColor = System.Drawing.Color.White;
            this.exitlbl.Location = new System.Drawing.Point(963, 11);
            this.exitlbl.Name = "exitlbl";
            this.exitlbl.Size = new System.Drawing.Size(22, 23);
            this.exitlbl.TabIndex = 0;
            this.exitlbl.Text = "X";
            this.exitlbl.Click += new System.EventHandler(this.exitlbl_Click);
            // 
            // componentsPnl
            // 
            this.componentsPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.componentsPnl.Controls.Add(this.errorLbl);
            this.componentsPnl.Controls.Add(this.infoButton);
            this.componentsPnl.Controls.Add(this.InfoLbl);
            this.componentsPnl.Controls.Add(this.passwordLbl);
            this.componentsPnl.Controls.Add(this.passwordbox);
            this.componentsPnl.Controls.Add(this.usernameLbl);
            this.componentsPnl.Controls.Add(this.usernameBox);
            this.componentsPnl.Controls.Add(this.saveButton);
            this.componentsPnl.Location = new System.Drawing.Point(-5, 30);
            this.componentsPnl.Name = "componentsPnl";
            this.componentsPnl.Size = new System.Drawing.Size(250, 491);
            this.componentsPnl.TabIndex = 2;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordLbl.Location = new System.Drawing.Point(3, 139);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(100, 23);
            this.passwordLbl.TabIndex = 5;
            this.passwordLbl.Text = "Password";
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(117, 136);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.PasswordChar = '*';
            this.passwordbox.Size = new System.Drawing.Size(121, 32);
            this.passwordbox.TabIndex = 4;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.usernameLbl.Location = new System.Drawing.Point(3, 68);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(108, 23);
            this.usernameLbl.TabIndex = 3;
            this.usernameLbl.Text = "Username";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(117, 65);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(121, 32);
            this.usernameBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(17, 212);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 34);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "SignUp";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.richTextBox1.Location = new System.Drawing.Point(352, 98);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(553, 379);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // richTBLbl
            // 
            this.richTBLbl.AutoSize = true;
            this.richTBLbl.Location = new System.Drawing.Point(352, 61);
            this.richTBLbl.Name = "richTBLbl";
            this.richTBLbl.Size = new System.Drawing.Size(69, 23);
            this.richTBLbl.TabIndex = 4;
            this.richTBLbl.Text = "Note: ";
            // 
            // InfoLbl
            // 
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.BackColor = System.Drawing.Color.Transparent;
            this.InfoLbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLbl.ForeColor = System.Drawing.Color.White;
            this.InfoLbl.Location = new System.Drawing.Point(3, 312);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(213, 76);
            this.InfoLbl.TabIndex = 6;
            this.InfoLbl.Text = "enter your username\r\nenter your password \r\nwrite any note, Thats All\r\nYour Accoun" +
    "t Is Ready :)";
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(19, 252);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(132, 34);
            this.infoButton.TabIndex = 7;
            this.infoButton.Text = "Show Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(7, 430);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 18);
            this.errorLbl.TabIndex = 8;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(988, 519);
            this.Controls.Add(this.richTBLbl);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.componentsPnl);
            this.Controls.Add(this.borderpnl);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.Text = "Form1";
            this.borderpnl.ResumeLayout(false);
            this.borderpnl.PerformLayout();
            this.componentsPnl.ResumeLayout(false);
            this.componentsPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel borderpnl;
        private System.Windows.Forms.Label exitlbl;
        private System.Windows.Forms.Panel componentsPnl;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label richTBLbl;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Label errorLbl;
    }
}

