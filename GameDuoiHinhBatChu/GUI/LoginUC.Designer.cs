namespace GUI
{
    partial class LoginUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUC));
            this.DragControlLogin = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.chkRememberPassword = new System.Windows.Forms.CheckBox();
            this.btnLoginUC = new System.Windows.Forms.Button();
            this.txtPasswordLoginUC = new System.Windows.Forms.TextBox();
            this.txtPlayerNameLoginUC = new System.Windows.Forms.TextBox();
            this.lblPasswordLoginUC = new System.Windows.Forms.Label();
            this.lblPlayerNameLoginUC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DragControlLogin
            // 
            this.DragControlLogin.Fixed = true;
            this.DragControlLogin.Horizontal = true;
            this.DragControlLogin.TargetControl = this;
            this.DragControlLogin.Vertical = true;
            // 
            // chkRememberPassword
            // 
            this.chkRememberPassword.AutoSize = true;
            this.chkRememberPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRememberPassword.Location = new System.Drawing.Point(41, 210);
            this.chkRememberPassword.Name = "chkRememberPassword";
            this.chkRememberPassword.Size = new System.Drawing.Size(175, 33);
            this.chkRememberPassword.TabIndex = 17;
            this.chkRememberPassword.Text = "Nhớ mật khẩu";
            this.chkRememberPassword.UseVisualStyleBackColor = true;
            // 
            // btnLoginUC
            // 
            this.btnLoginUC.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLoginUC.FlatAppearance.BorderSize = 0;
            this.btnLoginUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginUC.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginUC.ForeColor = System.Drawing.Color.White;
            this.btnLoginUC.Location = new System.Drawing.Point(41, 266);
            this.btnLoginUC.Name = "btnLoginUC";
            this.btnLoginUC.Size = new System.Drawing.Size(353, 58);
            this.btnLoginUC.TabIndex = 16;
            this.btnLoginUC.Text = "Đăng nhập";
            this.btnLoginUC.UseVisualStyleBackColor = false;
            this.btnLoginUC.Click += new System.EventHandler(this.btnLoginUC_Click);
            // 
            // txtPasswordLoginUC
            // 
            this.txtPasswordLoginUC.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLoginUC.Location = new System.Drawing.Point(109, 122);
            this.txtPasswordLoginUC.Multiline = true;
            this.txtPasswordLoginUC.Name = "txtPasswordLoginUC";
            this.txtPasswordLoginUC.PasswordChar = '*';
            this.txtPasswordLoginUC.Size = new System.Drawing.Size(285, 47);
            this.txtPasswordLoginUC.TabIndex = 14;
            this.txtPasswordLoginUC.Text = "Mật khẩu";
            this.txtPasswordLoginUC.Click += new System.EventHandler(this.txt_Click);
            // 
            // txtPlayerNameLoginUC
            // 
            this.txtPlayerNameLoginUC.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerNameLoginUC.Location = new System.Drawing.Point(109, 50);
            this.txtPlayerNameLoginUC.Multiline = true;
            this.txtPlayerNameLoginUC.Name = "txtPlayerNameLoginUC";
            this.txtPlayerNameLoginUC.Size = new System.Drawing.Size(285, 47);
            this.txtPlayerNameLoginUC.TabIndex = 12;
            this.txtPlayerNameLoginUC.Text = "Tên người chơi";
            this.txtPlayerNameLoginUC.Click += new System.EventHandler(this.txt_Click);
            // 
            // lblPasswordLoginUC
            // 
            this.lblPasswordLoginUC.AutoSize = true;
            this.lblPasswordLoginUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLoginUC.Image = ((System.Drawing.Image)(resources.GetObject("lblPasswordLoginUC.Image")));
            this.lblPasswordLoginUC.Location = new System.Drawing.Point(33, 125);
            this.lblPasswordLoginUC.Name = "lblPasswordLoginUC";
            this.lblPasswordLoginUC.Size = new System.Drawing.Size(70, 44);
            this.lblPasswordLoginUC.TabIndex = 15;
            this.lblPasswordLoginUC.Text = "     ";
            // 
            // lblPlayerNameLoginUC
            // 
            this.lblPlayerNameLoginUC.AutoSize = true;
            this.lblPlayerNameLoginUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNameLoginUC.Image = ((System.Drawing.Image)(resources.GetObject("lblPlayerNameLoginUC.Image")));
            this.lblPlayerNameLoginUC.Location = new System.Drawing.Point(33, 53);
            this.lblPlayerNameLoginUC.Name = "lblPlayerNameLoginUC";
            this.lblPlayerNameLoginUC.Size = new System.Drawing.Size(70, 44);
            this.lblPlayerNameLoginUC.TabIndex = 13;
            this.lblPlayerNameLoginUC.Text = "     ";
            // 
            // LoginUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chkRememberPassword);
            this.Controls.Add(this.btnLoginUC);
            this.Controls.Add(this.lblPasswordLoginUC);
            this.Controls.Add(this.txtPasswordLoginUC);
            this.Controls.Add(this.lblPlayerNameLoginUC);
            this.Controls.Add(this.txtPlayerNameLoginUC);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(425, 390);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl DragControlLogin;
        private System.Windows.Forms.CheckBox chkRememberPassword;
        private System.Windows.Forms.Button btnLoginUC;
        private System.Windows.Forms.TextBox txtPasswordLoginUC;
        private System.Windows.Forms.TextBox txtPlayerNameLoginUC;
        private System.Windows.Forms.Label lblPasswordLoginUC;
        private System.Windows.Forms.Label lblPlayerNameLoginUC;
    }
}
