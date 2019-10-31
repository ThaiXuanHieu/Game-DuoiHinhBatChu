namespace GUI
{
    partial class LoginGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginGUI));
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblNameGame = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.llbGoToSignup = new System.Windows.Forms.LinkLabel();
            this.llbForgetPassword = new System.Windows.Forms.LinkLabel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.llbBack1 = new System.Windows.Forms.LinkLabel();
            this.btnSignup = new System.Windows.Forms.Button();
            this.txtReEnterPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordNew = new System.Windows.Forms.TextBox();
            this.txtPlayerNameNew = new System.Windows.Forms.TextBox();
            this.lblSignup = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblPasswordNewTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.llbBack2 = new System.Windows.Forms.LinkLabel();
            this.btnTakePassword = new System.Windows.Forms.Button();
            this.txtPlayerNameForTakePassword = new System.Windows.Forms.TextBox();
            this.lblTakePassword = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(126, 89);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(176, 38);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Đăng nhập";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(65, 163);
            this.txtPlayerName.Multiline = true;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(301, 43);
            this.txtPlayerName.TabIndex = 1;
            this.txtPlayerName.Text = "Tài khoản";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlTop.Controls.Add(this.lblNameGame);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(432, 60);
            this.pnlTop.TabIndex = 2;
            // 
            // lblNameGame
            // 
            this.lblNameGame.AutoSize = true;
            this.lblNameGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameGame.ForeColor = System.Drawing.Color.White;
            this.lblNameGame.Location = new System.Drawing.Point(66, 9);
            this.lblNameGame.Name = "lblNameGame";
            this.lblNameGame.Size = new System.Drawing.Size(287, 38);
            this.lblNameGame.TabIndex = 1;
            this.lblNameGame.Text = "Đuổi Hình Bắt Chữ";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(65, 212);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(301, 43);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Mật khẩu";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(133, 290);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(154, 45);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // llbGoToSignup
            // 
            this.llbGoToSignup.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.llbGoToSignup.AutoSize = true;
            this.llbGoToSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbGoToSignup.LinkColor = System.Drawing.Color.DodgerBlue;
            this.llbGoToSignup.Location = new System.Drawing.Point(33, 388);
            this.llbGoToSignup.Name = "llbGoToSignup";
            this.llbGoToSignup.Size = new System.Drawing.Size(132, 25);
            this.llbGoToSignup.TabIndex = 4;
            this.llbGoToSignup.TabStop = true;
            this.llbGoToSignup.Text = "Đăng ký ngay";
            this.llbGoToSignup.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.llbGoToSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbGoToSignup_LinkClicked);
            // 
            // llbForgetPassword
            // 
            this.llbForgetPassword.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.llbForgetPassword.AutoSize = true;
            this.llbForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbForgetPassword.LinkColor = System.Drawing.Color.DodgerBlue;
            this.llbForgetPassword.Location = new System.Drawing.Point(256, 388);
            this.llbForgetPassword.Name = "llbForgetPassword";
            this.llbForgetPassword.Size = new System.Drawing.Size(146, 25);
            this.llbForgetPassword.TabIndex = 5;
            this.llbForgetPassword.TabStop = true;
            this.llbForgetPassword.Text = "Quên mật khẩu";
            this.llbForgetPassword.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.llbForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbForgetPassword_LinkClicked);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.llbBack1);
            this.pnlLeft.Controls.Add(this.btnSignup);
            this.pnlLeft.Controls.Add(this.txtReEnterPassword);
            this.pnlLeft.Controls.Add(this.txtPasswordNew);
            this.pnlLeft.Controls.Add(this.txtPlayerNameNew);
            this.pnlLeft.Controls.Add(this.lblSignup);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 60);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(10, 397);
            this.pnlLeft.TabIndex = 5;
            // 
            // llbBack1
            // 
            this.llbBack1.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.llbBack1.AutoSize = true;
            this.llbBack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbBack1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.llbBack1.Location = new System.Drawing.Point(352, 12);
            this.llbBack1.Name = "llbBack1";
            this.llbBack1.Size = new System.Drawing.Size(68, 25);
            this.llbBack1.TabIndex = 4;
            this.llbBack1.TabStop = true;
            this.llbBack1.Text = "Trở về";
            this.llbBack1.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.llbBack1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbBack1_LinkClicked);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(133, 280);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(154, 45);
            this.btnSignup.TabIndex = 3;
            this.btnSignup.Text = "Đăng ký";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // txtReEnterPassword
            // 
            this.txtReEnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReEnterPassword.Location = new System.Drawing.Point(65, 201);
            this.txtReEnterPassword.Multiline = true;
            this.txtReEnterPassword.Name = "txtReEnterPassword";
            this.txtReEnterPassword.PasswordChar = '*';
            this.txtReEnterPassword.Size = new System.Drawing.Size(301, 43);
            this.txtReEnterPassword.TabIndex = 2;
            this.txtReEnterPassword.Text = "Nhập lại mật khẩu";
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordNew.Location = new System.Drawing.Point(65, 152);
            this.txtPasswordNew.Multiline = true;
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.PasswordChar = '*';
            this.txtPasswordNew.Size = new System.Drawing.Size(301, 43);
            this.txtPasswordNew.TabIndex = 1;
            this.txtPasswordNew.Text = "Mật khẩu";
            // 
            // txtPlayerNameNew
            // 
            this.txtPlayerNameNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerNameNew.Location = new System.Drawing.Point(65, 103);
            this.txtPlayerNameNew.Multiline = true;
            this.txtPlayerNameNew.Name = "txtPlayerNameNew";
            this.txtPlayerNameNew.Size = new System.Drawing.Size(301, 43);
            this.txtPlayerNameNew.TabIndex = 0;
            this.txtPlayerNameNew.Text = "Tài khoản";
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignup.Location = new System.Drawing.Point(145, 29);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(138, 38);
            this.lblSignup.TabIndex = 5;
            this.lblSignup.Text = "Đăng ký";
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.lblPasswordNewTitle);
            this.pnlRight.Controls.Add(this.label1);
            this.pnlRight.Controls.Add(this.llbBack2);
            this.pnlRight.Controls.Add(this.btnTakePassword);
            this.pnlRight.Controls.Add(this.txtPlayerNameForTakePassword);
            this.pnlRight.Controls.Add(this.lblTakePassword);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(422, 60);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(10, 397);
            this.pnlRight.TabIndex = 6;
            // 
            // lblPasswordNewTitle
            // 
            this.lblPasswordNewTitle.AutoSize = true;
            this.lblPasswordNewTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordNewTitle.Location = new System.Drawing.Point(134, 268);
            this.lblPasswordNewTitle.Name = "lblPasswordNewTitle";
            this.lblPasswordNewTitle.Size = new System.Drawing.Size(184, 32);
            this.lblPasswordNewTitle.TabIndex = 10;
            this.lblPasswordNewTitle.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "------";
            // 
            // llbBack2
            // 
            this.llbBack2.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.llbBack2.AutoSize = true;
            this.llbBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbBack2.LinkColor = System.Drawing.Color.DodgerBlue;
            this.llbBack2.Location = new System.Drawing.Point(9, 12);
            this.llbBack2.Name = "llbBack2";
            this.llbBack2.Size = new System.Drawing.Size(68, 25);
            this.llbBack2.TabIndex = 2;
            this.llbBack2.TabStop = true;
            this.llbBack2.Text = "Trở về";
            this.llbBack2.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.llbBack2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbBack2_LinkClicked);
            // 
            // btnTakePassword
            // 
            this.btnTakePassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTakePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePassword.ForeColor = System.Drawing.Color.White;
            this.btnTakePassword.Location = new System.Drawing.Point(149, 199);
            this.btnTakePassword.Name = "btnTakePassword";
            this.btnTakePassword.Size = new System.Drawing.Size(154, 45);
            this.btnTakePassword.TabIndex = 1;
            this.btnTakePassword.Text = "Lấy";
            this.btnTakePassword.UseVisualStyleBackColor = false;
            this.btnTakePassword.Click += new System.EventHandler(this.btnTakePassword_Click);
            // 
            // txtPlayerNameForTakePassword
            // 
            this.txtPlayerNameForTakePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerNameForTakePassword.Location = new System.Drawing.Point(80, 110);
            this.txtPlayerNameForTakePassword.Multiline = true;
            this.txtPlayerNameForTakePassword.Name = "txtPlayerNameForTakePassword";
            this.txtPlayerNameForTakePassword.Size = new System.Drawing.Size(301, 43);
            this.txtPlayerNameForTakePassword.TabIndex = 0;
            this.txtPlayerNameForTakePassword.Text = "Tài khoản";
            // 
            // lblTakePassword
            // 
            this.lblTakePassword.AutoSize = true;
            this.lblTakePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTakePassword.Location = new System.Drawing.Point(90, 29);
            this.lblTakePassword.Name = "lblTakePassword";
            this.lblTakePassword.Size = new System.Drawing.Size(254, 38);
            this.lblTakePassword.TabIndex = 5;
            this.lblTakePassword.Text = "Lấy lại mật khẩu";
            // 
            // Timer1
            // 
            this.Timer1.Interval = 30;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Timer2
            // 
            this.Timer2.Interval = 30;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // LoginGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 457);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.llbForgetPassword);
            this.Controls.Add(this.llbGoToSignup);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Đuổi Hình Bắt Chữ";
            this.Load += new System.EventHandler(this.LoginGUI_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblNameGame;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel llbGoToSignup;
        private System.Windows.Forms.LinkLabel llbForgetPassword;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.LinkLabel llbBack1;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.TextBox txtReEnterPassword;
        private System.Windows.Forms.TextBox txtPasswordNew;
        private System.Windows.Forms.TextBox txtPlayerNameNew;
        private System.Windows.Forms.Label lblSignup;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblPasswordNewTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llbBack2;
        private System.Windows.Forms.Button btnTakePassword;
        private System.Windows.Forms.TextBox txtPlayerNameForTakePassword;
        private System.Windows.Forms.Label lblTakePassword;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Timer Timer2;
    }
}