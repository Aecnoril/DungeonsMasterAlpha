namespace DungeonMasterAlpha
{
    partial class DMForm
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.loginPnl = new System.Windows.Forms.Panel();
            this.registerBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.userNameTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuPnl = new System.Windows.Forms.Panel();
            this.dmLbl = new System.Windows.Forms.Label();
            this.loadBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.indexBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playerRb = new System.Windows.Forms.RadioButton();
            this.dmRb = new System.Windows.Forms.RadioButton();
            this.regCancelBtn = new System.Windows.Forms.Button();
            this.regAcceptBtn = new System.Windows.Forms.Button();
            this.registerDisplayNameTb = new System.Windows.Forms.TextBox();
            this.registerRepeatPwTb = new System.Windows.Forms.TextBox();
            this.registerPasswordTb = new System.Windows.Forms.TextBox();
            this.registerUserNameTb = new System.Windows.Forms.TextBox();
            this.registerLbl = new System.Windows.Forms.Label();
            this.loginPnl.SuspendLayout();
            this.menuPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(170)))), ((int)(((byte)(130)))));
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.exitBtn.Location = new System.Drawing.Point(633, 445);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // loginPnl
            // 
            this.loginPnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(170)))), ((int)(((byte)(130)))));
            this.loginPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPnl.Controls.Add(this.registerBtn);
            this.loginPnl.Controls.Add(this.loginBtn);
            this.loginPnl.Controls.Add(this.passwordLbl);
            this.loginPnl.Controls.Add(this.userNameLbl);
            this.loginPnl.Controls.Add(this.passwordTb);
            this.loginPnl.Controls.Add(this.userNameTb);
            this.loginPnl.Location = new System.Drawing.Point(296, 150);
            this.loginPnl.Name = "loginPnl";
            this.loginPnl.Size = new System.Drawing.Size(128, 120);
            this.loginPnl.TabIndex = 2;
            // 
            // registerBtn
            // 
            this.registerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            this.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(65, 91);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(58, 23);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(3, 91);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(58, 23);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.BackColor = System.Drawing.Color.Transparent;
            this.passwordLbl.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(3, 49);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(58, 16);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "Password:";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.userNameLbl.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(3, 5);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(61, 16);
            this.userNameLbl.TabIndex = 2;
            this.userNameLbl.Text = "Username:";
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(3, 65);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(120, 20);
            this.passwordTb.TabIndex = 1;
            this.passwordTb.UseSystemPasswordChar = true;
            // 
            // userNameTb
            // 
            this.userNameTb.Location = new System.Drawing.Point(3, 24);
            this.userNameTb.Name = "userNameTb";
            this.userNameTb.Size = new System.Drawing.Size(120, 20);
            this.userNameTb.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // menuPnl
            // 
            this.menuPnl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(170)))), ((int)(((byte)(130)))));
            this.menuPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPnl.Controls.Add(this.dmLbl);
            this.menuPnl.Controls.Add(this.loadBtn);
            this.menuPnl.Controls.Add(this.newBtn);
            this.menuPnl.Controls.Add(this.indexBtn);
            this.menuPnl.Enabled = false;
            this.menuPnl.Location = new System.Drawing.Point(296, 150);
            this.menuPnl.Name = "menuPnl";
            this.menuPnl.Size = new System.Drawing.Size(128, 120);
            this.menuPnl.TabIndex = 5;
            this.menuPnl.Visible = false;
            // 
            // dmLbl
            // 
            this.dmLbl.AutoSize = true;
            this.dmLbl.BackColor = System.Drawing.Color.Transparent;
            this.dmLbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dmLbl.Location = new System.Drawing.Point(14, 8);
            this.dmLbl.Name = "dmLbl";
            this.dmLbl.Size = new System.Drawing.Size(100, 13);
            this.dmLbl.TabIndex = 5;
            this.dmLbl.Text = "Dungeon Master";
            // 
            // loadBtn
            // 
            this.loadBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            this.loadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.loadBtn.Location = new System.Drawing.Point(3, 63);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(120, 23);
            this.loadBtn.TabIndex = 6;
            this.loadBtn.Text = "Load Story";
            this.loadBtn.UseVisualStyleBackColor = false;
            // 
            // newBtn
            // 
            this.newBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.newBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            this.newBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.newBtn.Location = new System.Drawing.Point(3, 34);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(120, 23);
            this.newBtn.TabIndex = 5;
            this.newBtn.Text = "New Story";
            this.newBtn.UseVisualStyleBackColor = false;
            // 
            // indexBtn
            // 
            this.indexBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.indexBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            this.indexBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.indexBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indexBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.indexBtn.Location = new System.Drawing.Point(3, 92);
            this.indexBtn.Name = "indexBtn";
            this.indexBtn.Size = new System.Drawing.Size(120, 23);
            this.indexBtn.TabIndex = 4;
            this.indexBtn.Text = "Index";
            this.indexBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(170)))), ((int)(((byte)(130)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.playerRb);
            this.panel1.Controls.Add(this.dmRb);
            this.panel1.Controls.Add(this.regCancelBtn);
            this.panel1.Controls.Add(this.regAcceptBtn);
            this.panel1.Controls.Add(this.registerDisplayNameTb);
            this.panel1.Controls.Add(this.registerRepeatPwTb);
            this.panel1.Controls.Add(this.registerPasswordTb);
            this.panel1.Controls.Add(this.registerUserNameTb);
            this.panel1.Controls.Add(this.registerLbl);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(430, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 181);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // playerRb
            // 
            this.playerRb.AutoSize = true;
            this.playerRb.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.playerRb.Checked = true;
            this.playerRb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerRb.Location = new System.Drawing.Point(83, 118);
            this.playerRb.Name = "playerRb";
            this.playerRb.Size = new System.Drawing.Size(40, 29);
            this.playerRb.TabIndex = 11;
            this.playerRb.TabStop = true;
            this.playerRb.Text = "Player";
            this.playerRb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.playerRb.UseVisualStyleBackColor = true;
            // 
            // dmRb
            // 
            this.dmRb.AutoSize = true;
            this.dmRb.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dmRb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dmRb.Location = new System.Drawing.Point(6, 118);
            this.dmRb.Name = "dmRb";
            this.dmRb.Size = new System.Drawing.Size(28, 29);
            this.dmRb.TabIndex = 10;
            this.dmRb.Text = "DM";
            this.dmRb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dmRb.UseVisualStyleBackColor = true;
            // 
            // regCancelBtn
            // 
            this.regCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.regCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            this.regCancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regCancelBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regCancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.regCancelBtn.Location = new System.Drawing.Point(65, 153);
            this.regCancelBtn.Name = "regCancelBtn";
            this.regCancelBtn.Size = new System.Drawing.Size(58, 23);
            this.regCancelBtn.TabIndex = 7;
            this.regCancelBtn.Text = "Cancel";
            this.regCancelBtn.UseVisualStyleBackColor = false;
            // 
            // regAcceptBtn
            // 
            this.regAcceptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.regAcceptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(150)))), ((int)(((byte)(110)))));
            this.regAcceptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regAcceptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regAcceptBtn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regAcceptBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.regAcceptBtn.Location = new System.Drawing.Point(3, 153);
            this.regAcceptBtn.Name = "regAcceptBtn";
            this.regAcceptBtn.Size = new System.Drawing.Size(58, 23);
            this.regAcceptBtn.TabIndex = 6;
            this.regAcceptBtn.Text = "Accept";
            this.regAcceptBtn.UseVisualStyleBackColor = false;
            // 
            // registerDisplayNameTb
            // 
            this.registerDisplayNameTb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerDisplayNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.registerDisplayNameTb.Location = new System.Drawing.Point(3, 45);
            this.registerDisplayNameTb.Name = "registerDisplayNameTb";
            this.registerDisplayNameTb.Size = new System.Drawing.Size(120, 21);
            this.registerDisplayNameTb.TabIndex = 7;
            this.registerDisplayNameTb.Text = "Displayname";
            // 
            // registerRepeatPwTb
            // 
            this.registerRepeatPwTb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerRepeatPwTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.registerRepeatPwTb.Location = new System.Drawing.Point(3, 97);
            this.registerRepeatPwTb.Name = "registerRepeatPwTb";
            this.registerRepeatPwTb.Size = new System.Drawing.Size(120, 21);
            this.registerRepeatPwTb.TabIndex = 9;
            this.registerRepeatPwTb.Text = "Repeat Password";
            // 
            // registerPasswordTb
            // 
            this.registerPasswordTb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPasswordTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.registerPasswordTb.Location = new System.Drawing.Point(3, 71);
            this.registerPasswordTb.Name = "registerPasswordTb";
            this.registerPasswordTb.Size = new System.Drawing.Size(120, 21);
            this.registerPasswordTb.TabIndex = 8;
            this.registerPasswordTb.Text = "Password";
            // 
            // registerUserNameTb
            // 
            this.registerUserNameTb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUserNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.registerUserNameTb.Location = new System.Drawing.Point(3, 18);
            this.registerUserNameTb.Name = "registerUserNameTb";
            this.registerUserNameTb.Size = new System.Drawing.Size(120, 21);
            this.registerUserNameTb.TabIndex = 6;
            this.registerUserNameTb.Text = "Username";
            // 
            // registerLbl
            // 
            this.registerLbl.AutoSize = true;
            this.registerLbl.BackColor = System.Drawing.Color.Transparent;
            this.registerLbl.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.registerLbl.Location = new System.Drawing.Point(3, 2);
            this.registerLbl.Name = "registerLbl";
            this.registerLbl.Size = new System.Drawing.Size(103, 13);
            this.registerLbl.TabIndex = 5;
            this.registerLbl.Text = "Register Account";
            // 
            // FormDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(188)))), ((int)(((byte)(154)))));
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loginPnl);
            this.Controls.Add(this.menuPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dungeon Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.loginPnl.ResumeLayout(false);
            this.loginPnl.PerformLayout();
            this.menuPnl.ResumeLayout(false);
            this.menuPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel loginPnl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TextBox userNameTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Panel menuPnl;
        private System.Windows.Forms.Label dmLbl;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button indexBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton playerRb;
        private System.Windows.Forms.RadioButton dmRb;
        private System.Windows.Forms.Button regCancelBtn;
        private System.Windows.Forms.Button regAcceptBtn;
        private System.Windows.Forms.TextBox registerDisplayNameTb;
        private System.Windows.Forms.TextBox registerRepeatPwTb;
        private System.Windows.Forms.TextBox registerPasswordTb;
        private System.Windows.Forms.TextBox registerUserNameTb;
        private System.Windows.Forms.Label registerLbl;
    }
}

