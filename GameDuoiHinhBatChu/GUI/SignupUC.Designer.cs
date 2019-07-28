namespace GUI
{
    partial class SignupUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupUC));
            this.DragControlSignup = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnSignupUC = new System.Windows.Forms.Button();
            this.lblPasswordSignupUC = new System.Windows.Forms.Label();
            this.txtPasswordSignupUC = new System.Windows.Forms.TextBox();
            this.lblPlayerNameSignupUC = new System.Windows.Forms.Label();
            this.txtPlayerNameSignupUC = new System.Windows.Forms.TextBox();
            this.lblNotifySignupSuccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DragControlSignup
            // 
            this.DragControlSignup.Fixed = true;
            this.DragControlSignup.Horizontal = true;
            this.DragControlSignup.TargetControl = this;
            this.DragControlSignup.Vertical = true;
            // 
            // btnSignupUC
            // 
            this.btnSignupUC.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSignupUC.FlatAppearance.BorderSize = 0;
            this.btnSignupUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignupUC.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignupUC.ForeColor = System.Drawing.Color.White;
            this.btnSignupUC.Location = new System.Drawing.Point(41, 266);
            this.btnSignupUC.Name = "btnSignupUC";
            this.btnSignupUC.Size = new System.Drawing.Size(353, 58);
            this.btnSignupUC.TabIndex = 24;
            this.btnSignupUC.Text = "Đăng ký";
            this.btnSignupUC.UseVisualStyleBackColor = false;
            this.btnSignupUC.Click += new System.EventHandler(this.btnSignupUC_Click);
            // 
            // lblPasswordSignupUC
            // 
            this.lblPasswordSignupUC.AutoSize = true;
            this.lblPasswordSignupUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordSignupUC.Image = ((System.Drawing.Image)(resources.GetObject("lblPasswordSignupUC.Image")));
            this.lblPasswordSignupUC.Location = new System.Drawing.Point(33, 124);
            this.lblPasswordSignupUC.Name = "lblPasswordSignupUC";
            this.lblPasswordSignupUC.Size = new System.Drawing.Size(70, 44);
            this.lblPasswordSignupUC.TabIndex = 21;
            this.lblPasswordSignupUC.Text = "     ";
            // 
            // txtPasswordSignupUC
            // 
            this.txtPasswordSignupUC.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignupUC.Location = new System.Drawing.Point(109, 121);
            this.txtPasswordSignupUC.Multiline = true;
            this.txtPasswordSignupUC.Name = "txtPasswordSignupUC";
            this.txtPasswordSignupUC.PasswordChar = '*';
            this.txtPasswordSignupUC.Size = new System.Drawing.Size(285, 47);
            this.txtPasswordSignupUC.TabIndex = 20;
            this.txtPasswordSignupUC.Text = "Mật khẩu";
            this.txtPasswordSignupUC.Click += new System.EventHandler(this.txt_Click);
            // 
            // lblPlayerNameSignupUC
            // 
            this.lblPlayerNameSignupUC.AutoSize = true;
            this.lblPlayerNameSignupUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerNameSignupUC.Image = ((System.Drawing.Image)(resources.GetObject("lblPlayerNameSignupUC.Image")));
            this.lblPlayerNameSignupUC.Location = new System.Drawing.Point(33, 52);
            this.lblPlayerNameSignupUC.Name = "lblPlayerNameSignupUC";
            this.lblPlayerNameSignupUC.Size = new System.Drawing.Size(70, 44);
            this.lblPlayerNameSignupUC.TabIndex = 19;
            this.lblPlayerNameSignupUC.Text = "     ";
            // 
            // txtPlayerNameSignupUC
            // 
            this.txtPlayerNameSignupUC.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerNameSignupUC.Location = new System.Drawing.Point(109, 49);
            this.txtPlayerNameSignupUC.Multiline = true;
            this.txtPlayerNameSignupUC.Name = "txtPlayerNameSignupUC";
            this.txtPlayerNameSignupUC.Size = new System.Drawing.Size(285, 47);
            this.txtPlayerNameSignupUC.TabIndex = 18;
            this.txtPlayerNameSignupUC.Text = "Tên người chơi";
            this.txtPlayerNameSignupUC.Click += new System.EventHandler(this.txt_Click);
            // 
            // lblNotifySignupSuccess
            // 
            this.lblNotifySignupSuccess.AutoSize = true;
            this.lblNotifySignupSuccess.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifySignupSuccess.Location = new System.Drawing.Point(136, 343);
            this.lblNotifySignupSuccess.Name = "lblNotifySignupSuccess";
            this.lblNotifySignupSuccess.Size = new System.Drawing.Size(0, 25);
            this.lblNotifySignupSuccess.TabIndex = 25;
            // 
            // SignupUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNotifySignupSuccess);
            this.Controls.Add(this.btnSignupUC);
            this.Controls.Add(this.lblPasswordSignupUC);
            this.Controls.Add(this.txtPasswordSignupUC);
            this.Controls.Add(this.lblPlayerNameSignupUC);
            this.Controls.Add(this.txtPlayerNameSignupUC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SignupUC";
            this.Size = new System.Drawing.Size(425, 390);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl DragControlSignup;
        private System.Windows.Forms.Button btnSignupUC;
        private System.Windows.Forms.Label lblPasswordSignupUC;
        private System.Windows.Forms.TextBox txtPasswordSignupUC;
        private System.Windows.Forms.Label lblPlayerNameSignupUC;
        private System.Windows.Forms.TextBox txtPlayerNameSignupUC;
        private System.Windows.Forms.Label lblNotifySignupSuccess;
    }
}
