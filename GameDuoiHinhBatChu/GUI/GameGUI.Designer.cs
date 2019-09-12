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
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.picCoin = new System.Windows.Forms.PictureBox();
            this.picQuestion = new System.Windows.Forms.PictureBox();
            this.btnOnOffSound = new System.Windows.Forms.CheckBox();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQuestion)).BeginInit();
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
            this.lblOrdinalOfQuestion.Location = new System.Drawing.Point(26, 43);
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
            this.lblOrdinal.Location = new System.Drawing.Point(121, 43);
            this.lblOrdinal.Name = "lblOrdinal";
            this.lblOrdinal.Size = new System.Drawing.Size(0, 39);
            this.lblOrdinal.TabIndex = 5;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.White;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnA.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(31, 536);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(39, 46);
            this.btnA.TabIndex = 6;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.White;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnB.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(76, 536);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(39, 46);
            this.btnB.TabIndex = 7;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.White;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnC.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(121, 536);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(39, 46);
            this.btnC.TabIndex = 8;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.White;
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnD.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(166, 536);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(39, 46);
            this.btnD.TabIndex = 9;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnE
            // 
            this.btnE.BackColor = System.Drawing.Color.White;
            this.btnE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnE.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(211, 536);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(39, 46);
            this.btnE.TabIndex = 10;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnF
            // 
            this.btnF.BackColor = System.Drawing.Color.White;
            this.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnF.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(256, 536);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(39, 46);
            this.btnF.TabIndex = 11;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = false;
            this.btnF.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnG
            // 
            this.btnG.BackColor = System.Drawing.Color.White;
            this.btnG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnG.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG.Location = new System.Drawing.Point(301, 536);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(39, 46);
            this.btnG.TabIndex = 12;
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = false;
            this.btnG.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnH
            // 
            this.btnH.BackColor = System.Drawing.Color.White;
            this.btnH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnH.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnH.Location = new System.Drawing.Point(346, 536);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(39, 46);
            this.btnH.TabIndex = 13;
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = false;
            this.btnH.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.Color.White;
            this.btnI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnI.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Location = new System.Drawing.Point(391, 536);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(39, 46);
            this.btnI.TabIndex = 14;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = false;
            this.btnI.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnJ
            // 
            this.btnJ.BackColor = System.Drawing.Color.White;
            this.btnJ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJ.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJ.Location = new System.Drawing.Point(436, 536);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(39, 46);
            this.btnJ.TabIndex = 15;
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = false;
            this.btnJ.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnK
            // 
            this.btnK.BackColor = System.Drawing.Color.White;
            this.btnK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnK.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnK.Location = new System.Drawing.Point(481, 536);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(39, 46);
            this.btnK.TabIndex = 16;
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = false;
            this.btnK.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.White;
            this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnL.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(526, 536);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(39, 46);
            this.btnL.TabIndex = 17;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnY
            // 
            this.btnY.BackColor = System.Drawing.Color.White;
            this.btnY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnY.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnY.Location = new System.Drawing.Point(526, 588);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(39, 46);
            this.btnY.TabIndex = 29;
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = false;
            this.btnY.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.White;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnX.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(481, 588);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(39, 46);
            this.btnX.TabIndex = 28;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.Color.White;
            this.btnV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnV.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.Location = new System.Drawing.Point(436, 588);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(39, 46);
            this.btnV.TabIndex = 27;
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = false;
            this.btnV.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnU
            // 
            this.btnU.BackColor = System.Drawing.Color.White;
            this.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnU.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnU.Location = new System.Drawing.Point(391, 588);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(39, 46);
            this.btnU.TabIndex = 26;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = false;
            this.btnU.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnT
            // 
            this.btnT.BackColor = System.Drawing.Color.White;
            this.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnT.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnT.Location = new System.Drawing.Point(346, 588);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(39, 46);
            this.btnT.TabIndex = 25;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = false;
            this.btnT.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.White;
            this.btnS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnS.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(301, 588);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(39, 46);
            this.btnS.TabIndex = 24;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.White;
            this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnR.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnR.Location = new System.Drawing.Point(256, 588);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(39, 46);
            this.btnR.TabIndex = 23;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnQ
            // 
            this.btnQ.BackColor = System.Drawing.Color.White;
            this.btnQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQ.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ.Location = new System.Drawing.Point(211, 588);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(39, 46);
            this.btnQ.TabIndex = 22;
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = false;
            this.btnQ.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnP
            // 
            this.btnP.BackColor = System.Drawing.Color.White;
            this.btnP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnP.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP.Location = new System.Drawing.Point(166, 588);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(39, 46);
            this.btnP.TabIndex = 21;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = false;
            this.btnP.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.Color.White;
            this.btnO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnO.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnO.Location = new System.Drawing.Point(121, 588);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(39, 46);
            this.btnO.TabIndex = 20;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = false;
            this.btnO.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnN
            // 
            this.btnN.BackColor = System.Drawing.Color.White;
            this.btnN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnN.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN.Location = new System.Drawing.Point(76, 588);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(39, 46);
            this.btnN.TabIndex = 19;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = false;
            this.btnN.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.White;
            this.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnM.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(31, 588);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(39, 46);
            this.btnM.TabIndex = 18;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // picCoin
            // 
            this.picCoin.Image = ((System.Drawing.Image)(resources.GetObject("picCoin.Image")));
            this.picCoin.Location = new System.Drawing.Point(379, 42);
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
            this.btnOnOffSound.Location = new System.Drawing.Point(531, 43);
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
            // GameGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(600, 710);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnOnOffSound);
            this.Controls.Add(this.btnY);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnH);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
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
        private System.Windows.Forms.Button btnY;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnV;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.CheckBox btnOnOffSound;
        private System.Windows.Forms.Label lblInfo;
    }
}