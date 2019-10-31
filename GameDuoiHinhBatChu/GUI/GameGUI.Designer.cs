namespace GUI
{
    partial class GameGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameGUI));
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblCoin = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblOrdinalOfQuestion = new System.Windows.Forms.Label();
            this.lblOrdinal = new System.Windows.Forms.Label();
            this.picCoin = new System.Windows.Forms.PictureBox();
            this.picQuestion = new System.Windows.Forms.PictureBox();
            this.btnOnOffSound = new System.Windows.Forms.CheckBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChar1 = new System.Windows.Forms.Button();
            this.btnChar2 = new System.Windows.Forms.Button();
            this.btnChar3 = new System.Windows.Forms.Button();
            this.btnChar4 = new System.Windows.Forms.Button();
            this.btnChar5 = new System.Windows.Forms.Button();
            this.btnChar6 = new System.Windows.Forms.Button();
            this.btnChar7 = new System.Windows.Forms.Button();
            this.btnChar8 = new System.Windows.Forms.Button();
            this.btnChar9 = new System.Windows.Forms.Button();
            this.btnChar10 = new System.Windows.Forms.Button();
            this.btnChar11 = new System.Windows.Forms.Button();
            this.btnChar12 = new System.Windows.Forms.Button();
            this.btnChar13 = new System.Windows.Forms.Button();
            this.btnChar14 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuestion)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // lblCoin
            // 
            this.lblCoin.AutoSize = true;
            this.lblCoin.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCoin.Location = new System.Drawing.Point(439, 43);
            this.lblCoin.Name = "lblCoin";
            this.lblCoin.Size = new System.Drawing.Size(0, 39);
            this.lblCoin.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(550, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblOrdinalOfQuestion
            // 
            this.lblOrdinalOfQuestion.AutoSize = true;
            this.lblOrdinalOfQuestion.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdinalOfQuestion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblOrdinalOfQuestion.Location = new System.Drawing.Point(12, 77);
            this.lblOrdinalOfQuestion.Name = "lblOrdinalOfQuestion";
            this.lblOrdinalOfQuestion.Size = new System.Drawing.Size(89, 39);
            this.lblOrdinalOfQuestion.TabIndex = 4;
            this.lblOrdinalOfQuestion.Text = "Câu :";
            // 
            // lblOrdinal
            // 
            this.lblOrdinal.AutoSize = true;
            this.lblOrdinal.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdinal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblOrdinal.Location = new System.Drawing.Point(118, 77);
            this.lblOrdinal.Name = "lblOrdinal";
            this.lblOrdinal.Size = new System.Drawing.Size(0, 39);
            this.lblOrdinal.TabIndex = 5;
            // 
            // picCoin
            // 
            this.picCoin.Image = ((System.Drawing.Image)(resources.GetObject("picCoin.Image")));
            this.picCoin.Location = new System.Drawing.Point(368, 76);
            this.picCoin.Name = "picCoin";
            this.picCoin.Size = new System.Drawing.Size(53, 40);
            this.picCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoin.TabIndex = 1;
            this.picCoin.TabStop = false;
            // 
            // picQuestion
            // 
            this.picQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQuestion.Location = new System.Drawing.Point(10, 136);
            this.picQuestion.Name = "picQuestion";
            this.picQuestion.Size = new System.Drawing.Size(578, 292);
            this.picQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQuestion.TabIndex = 0;
            this.picQuestion.TabStop = false;
            // 
            // btnOnOffSound
            // 
            this.btnOnOffSound.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnOnOffSound.BackgroundImage = global::GUI.Properties.Resources.icons8_Audio_32px;
            this.btnOnOffSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOnOffSound.FlatAppearance.BorderSize = 0;
            this.btnOnOffSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnOffSound.Location = new System.Drawing.Point(531, 76);
            this.btnOnOffSound.Name = "btnOnOffSound";
            this.btnOnOffSound.Size = new System.Drawing.Size(57, 39);
            this.btnOnOffSound.TabIndex = 30;
            this.btnOnOffSound.UseVisualStyleBackColor = true;
            this.btnOnOffSound.CheckedChanged += new System.EventHandler(this.btnOnOffSound_CheckedChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo.Location = new System.Drawing.Point(180, 676);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(241, 25);
            this.lblInfo.TabIndex = 31;
            this.lblInfo.Text = "© - Thái Xuân Hiếu - 2019";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnChar1);
            this.flowLayoutPanel1.Controls.Add(this.btnChar2);
            this.flowLayoutPanel1.Controls.Add(this.btnChar3);
            this.flowLayoutPanel1.Controls.Add(this.btnChar4);
            this.flowLayoutPanel1.Controls.Add(this.btnChar5);
            this.flowLayoutPanel1.Controls.Add(this.btnChar6);
            this.flowLayoutPanel1.Controls.Add(this.btnChar7);
            this.flowLayoutPanel1.Controls.Add(this.btnChar8);
            this.flowLayoutPanel1.Controls.Add(this.btnChar9);
            this.flowLayoutPanel1.Controls.Add(this.btnChar10);
            this.flowLayoutPanel1.Controls.Add(this.btnChar11);
            this.flowLayoutPanel1.Controls.Add(this.btnChar12);
            this.flowLayoutPanel1.Controls.Add(this.btnChar13);
            this.flowLayoutPanel1.Controls.Add(this.btnChar14);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(137, 535);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(315, 105);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // btnChar1
            // 
            this.btnChar1.BackColor = System.Drawing.Color.White;
            this.btnChar1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChar1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChar1.Location = new System.Drawing.Point(3, 3);
            this.btnChar1.Name = "btnChar1";
            this.btnChar1.Size = new System.Drawing.Size(39, 46);
            this.btnChar1.TabIndex = 38;
            this.btnChar1.UseVisualStyleBackColor = false;
            this.btnChar1.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnChar2
            // 
            this.btnChar2.BackColor = System.Drawing.Color.White;
            this.btnChar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChar2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChar2.Location = new System.Drawing.Point(48, 3);
            this.btnChar2.Name = "btnChar2";
            this.btnChar2.Size = new System.Drawing.Size(39, 46);
            this.btnChar2.TabIndex = 37;
            this.btnChar2.UseVisualStyleBackColor = false;
            this.btnChar2.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnChar3
            // 
            this.btnChar3.BackColor = System.Drawing.Color.White;
            this.btnChar3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChar3.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChar3.Location = new System.Drawing.Point(93, 3);
            this.btnChar3.Name = "btnChar3";
            this.btnChar3.Size = new System.Drawing.Size(39, 46);
            this.btnChar3.TabIndex = 36;
            this.btnChar3.UseVisualStyleBackColor = false;
            this.btnChar3.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnChar4
            // 
            this.btnChar4.BackColor = System.Drawing.Color.White;
            this.btnChar4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChar4.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChar4.Location = new System.Drawing.Point(138, 3);
            this.btnChar4.Name = "btnChar4";
            this.btnChar4.Size = new System.Drawing.Size(39, 46);
            this.btnChar4.TabIndex = 35;
            this.btnChar4.UseVisualStyleBackColor = false;
            this.btnChar4.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnChar5
            // 
            this.btnChar5.BackColor = System.Drawing.Color.White;
            this.btnChar5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChar5.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChar5.Location = new System.Drawing.Point(183, 3);
            this.btnChar5.Name = "btnChar5";
            this.btnChar5.Size = new System.Drawing.Size(39, 46);
            this.btnChar5.TabIndex = 34;
            this.btnChar5.UseVisualStyleBackColor = false;
            this.btnChar5.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnChar6
            // 
            this.btnChar6.BackColor = System.Drawing.Color.White;
            this.btnChar6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChar6.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChar6.Location = new System.Drawing.Point(228, 3);
            this.btnChar6.Name = "btnChar6";
            this.btnChar6.Size = new System.Drawing.Size(39, 46);
            this.btnChar6.TabIndex = 33;
            this.btnChar6.UseVisualStyleBackColor = false;
            this.btnChar6.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnChar7
            // 
            this.btnChar7.BackColor = System.Drawing.Color.White;
            this.btnChar7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChar7.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChar7.Location = new System.Drawing.Point(273, 3);
            this.btnChar7.Name = "btnChar7";
            this.btnChar7.Size = new System.Drawing.Size(39, 46);
            this.btnChar7.TabIndex = 32;
            this.btnChar7.UseVisualStyleBackColor = false;
            this.btnChar7.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnChar8
            // 
            this.btnChar8.BackColor = System.Drawing.Color.White;
            this.btnChar8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChar8.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChar8.Location = new System.Drawing.Point(3, 55);
            this.btnChar8.Name = "btnChar8";
            this.btnChar8.Size = new System.Drawing.Size(39, 46);
            this.btnChar8.TabIndex = 31;
            this.btnChar8.UseVisualStyleBackColor = false;
            this.btnChar8.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnChar9
            // 
            this.btnChar9.BackColor = System.Drawing.Color.White;
            this.btnChar9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChar9.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChar9.Location = new System.Drawing.Point(48, 55);
            this.btnChar9.Name = "btnChar9";
            this.btnChar9.Size = new System.Drawing.Size(39, 46);
            this.btnChar9.TabIndex = 30;
            this.btnChar9.UseVisualStyleBackColor = false;
            this.btnChar9.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnChar10
            // 
            this.btnChar10.BackColor = System.Drawing.Color.White;
            this.btnChar10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChar10.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChar10.Location = new System.Drawing.Point(93, 55);
            this.btnChar10.Name = "btnChar10";
            this.btnChar10.Size = new System.Drawing.Size(39, 46);
            this.btnChar10.TabIndex = 29;
            this.btnChar10.UseVisualStyleBackColor = false;
            this.btnChar10.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnChar11
            // 
            this.btnChar11.BackColor = System.Drawing.Color.White;
            this.btnChar11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChar11.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChar11.Location = new System.Drawing.Point(138, 55);
            this.btnChar11.Name = "btnChar11";
            this.btnChar11.Size = new System.Drawing.Size(39, 46);
            this.btnChar11.TabIndex = 28;
            this.btnChar11.UseVisualStyleBackColor = false;
            this.btnChar11.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnChar12
            // 
            this.btnChar12.BackColor = System.Drawing.Color.White;
            this.btnChar12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChar12.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChar12.Location = new System.Drawing.Point(183, 55);
            this.btnChar12.Name = "btnChar12";
            this.btnChar12.Size = new System.Drawing.Size(39, 46);
            this.btnChar12.TabIndex = 27;
            this.btnChar12.UseVisualStyleBackColor = false;
            this.btnChar12.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnChar13
            // 
            this.btnChar13.BackColor = System.Drawing.Color.White;
            this.btnChar13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChar13.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChar13.Location = new System.Drawing.Point(228, 55);
            this.btnChar13.Name = "btnChar13";
            this.btnChar13.Size = new System.Drawing.Size(39, 46);
            this.btnChar13.TabIndex = 26;
            this.btnChar13.UseVisualStyleBackColor = false;
            this.btnChar13.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnChar14
            // 
            this.btnChar14.BackColor = System.Drawing.Color.White;
            this.btnChar14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChar14.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChar14.Location = new System.Drawing.Point(273, 55);
            this.btnChar14.Name = "btnChar14";
            this.btnChar14.Size = new System.Drawing.Size(39, 46);
            this.btnChar14.TabIndex = 25;
            this.btnChar14.UseVisualStyleBackColor = false;
            this.btnChar14.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // GameGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 710);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnOnOffSound);
            this.Controls.Add(this.lblOrdinal);
            this.Controls.Add(this.lblOrdinalOfQuestion);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCoin);
            this.Controls.Add(this.picCoin);
            this.Controls.Add(this.picQuestion);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GameGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuestion)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.PictureBox picQuestion;
        private System.Windows.Forms.Label lblCoin;
        private System.Windows.Forms.PictureBox picCoin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblOrdinal;
        private System.Windows.Forms.Label lblOrdinalOfQuestion;
        private System.Windows.Forms.CheckBox btnOnOffSound;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnChar1;
        private System.Windows.Forms.Button btnChar2;
        private System.Windows.Forms.Button btnChar3;
        private System.Windows.Forms.Button btnChar4;
        private System.Windows.Forms.Button btnChar5;
        private System.Windows.Forms.Button btnChar6;
        private System.Windows.Forms.Button btnChar7;
        private System.Windows.Forms.Button btnChar8;
        private System.Windows.Forms.Button btnChar9;
        private System.Windows.Forms.Button btnChar10;
        private System.Windows.Forms.Button btnChar11;
        private System.Windows.Forms.Button btnChar12;
        private System.Windows.Forms.Button btnChar13;
        private System.Windows.Forms.Button btnChar14;
    }
}