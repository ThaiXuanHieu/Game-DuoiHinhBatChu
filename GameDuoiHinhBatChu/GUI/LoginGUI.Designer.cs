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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginGUI));
            this.btnSignupGUI = new System.Windows.Forms.Button();
            this.btnLoginGUI = new System.Windows.Forms.Button();
            this.pnlGUI = new System.Windows.Forms.Panel();
            this.loginUC = new GUI.LoginUC();
            this.signupUC = new GUI.SignupUC();
            this.pnlGUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignupGUI
            // 
            this.btnSignupGUI.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSignupGUI.FlatAppearance.BorderSize = 0;
            this.btnSignupGUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignupGUI.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignupGUI.ForeColor = System.Drawing.Color.White;
            this.btnSignupGUI.Location = new System.Drawing.Point(0, 0);
            this.btnSignupGUI.Name = "btnSignupGUI";
            this.btnSignupGUI.Size = new System.Drawing.Size(212, 80);
            this.btnSignupGUI.TabIndex = 0;
            this.btnSignupGUI.Text = "Đăng ký";
            this.btnSignupGUI.UseVisualStyleBackColor = false;
            this.btnSignupGUI.Click += new System.EventHandler(this.btnSignupGUI_Click);
            // 
            // btnLoginGUI
            // 
            this.btnLoginGUI.BackColor = System.Drawing.Color.White;
            this.btnLoginGUI.FlatAppearance.BorderSize = 0;
            this.btnLoginGUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginGUI.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginGUI.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnLoginGUI.Location = new System.Drawing.Point(212, 0);
            this.btnLoginGUI.Name = "btnLoginGUI";
            this.btnLoginGUI.Size = new System.Drawing.Size(213, 80);
            this.btnLoginGUI.TabIndex = 1;
            this.btnLoginGUI.Text = "Đăng nhập";
            this.btnLoginGUI.UseVisualStyleBackColor = false;
            this.btnLoginGUI.Click += new System.EventHandler(this.btnLoginGUI_Click);
            // 
            // pnlGUI
            // 
            this.pnlGUI.Controls.Add(this.loginUC);
            this.pnlGUI.Controls.Add(this.signupUC);
            this.pnlGUI.Location = new System.Drawing.Point(0, 80);
            this.pnlGUI.Name = "pnlGUI";
            this.pnlGUI.Size = new System.Drawing.Size(425, 384);
            this.pnlGUI.TabIndex = 2;
            // 
            // loginUC
            // 
            this.loginUC.BackColor = System.Drawing.Color.White;
            this.loginUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginUC.Location = new System.Drawing.Point(0, 0);
            this.loginUC.Name = "loginUC";
            this.loginUC.Size = new System.Drawing.Size(425, 384);
            this.loginUC.TabIndex = 1;
            // 
            // signupUC
            // 
            this.signupUC.BackColor = System.Drawing.Color.White;
            this.signupUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signupUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupUC.Location = new System.Drawing.Point(0, 0);
            this.signupUC.Name = "signupUC";
            this.signupUC.Size = new System.Drawing.Size(425, 384);
            this.signupUC.TabIndex = 0;
            // 
            // LoginGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 470);
            this.Controls.Add(this.pnlGUI);
            this.Controls.Add(this.btnLoginGUI);
            this.Controls.Add(this.btnSignupGUI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginGUI_Load);
            this.pnlGUI.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoginGUI;
        private System.Windows.Forms.Button btnSignupGUI;
        private System.Windows.Forms.Panel pnlGUI;
        private LoginUC loginUC;
        private SignupUC signupUC;
    }
}

