using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginGUI : Form
    {
        private bool hidden1;
        private bool hidden2;

        string[] images = new string[] { "kichdong" };
        string[] answers = new string[] { "KICHDONG" };

        public LoginGUI()
        {
            InitializeComponent();
            hidden1 = true;
            hidden2 = true;
        }

        private static SoundPlayer instance;


        public static SoundPlayer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SoundPlayer("Login.wav");
                }
                return instance;
            }
        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {
            instance = new SoundPlayer("Login.wav");
            instance.Play();
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                PlayerDTO player = new PlayerDTO();
                player = PlayerBUS.Instance.GetPlayerByPlayerName(txtPlayerName.Text);
                if (player.PlayerName.Equals(txtPlayerName.Text) && player.Password.Equals(txtPassword.Text))
                {
                    GameGUI gameGUI = new GameGUI(player.IDPlayer);
                    gameGUI.Show();

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc Mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Tài khoản hoặc Mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void llbGoToSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer1.Start();
        }

        private void llbForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer2.Start();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtPasswordNew.Text.Equals(txtReEnterPassword.Text))
            {
                PlayerBUS.Instance.InsertPlayerToDB(txtPlayerNameNew.Text, txtPasswordNew.Text, 100);
                MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Insert Question

                PlayerDTO player = PlayerBUS.Instance.GetPlayerByPlayerName(txtPlayerNameNew.Text);
                string imageLocation = Application.StartupPath + "\\Resources\\" + images[0] + ".jpg";
                QuestionBUS.Instance.InsertQuestionToDB(1, imageLocation, answers[0], player.IDPlayer);
            }
            else
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void llbBack1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer1.Start();
        }

        private void btnTakePassword_Click(object sender, EventArgs e)
        {

        }

        private void llbBack2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer2.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(hidden1)
            {
                pnlLeft.Width = pnlLeft.Width + 10;
                if(pnlLeft.Width >= 450)
                {
                    Timer1.Stop();
                    hidden1 = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlLeft.Width = pnlLeft.Width - 10;
                if(pnlLeft.Width <= 10)
                {
                    Timer1.Stop();
                    hidden1 = true;
                    this.Refresh();
                }
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (hidden2)
            {
                pnlRight.Width = pnlRight.Width + 10;
                if (pnlRight.Width >= 320)
                {
                    Timer2.Stop();
                    hidden2 = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlRight.Width = pnlRight.Width - 10;
                if (pnlRight.Width <= 10)
                {
                    Timer2.Stop();
                    hidden2 = true;
                    this.Refresh();
                }
            }
        }

        

        
    }
}
