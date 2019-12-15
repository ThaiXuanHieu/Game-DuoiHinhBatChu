using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginGUI : Form
    {
        private bool hidden1;
        private bool hidden2;

        string[] images = new string[] { "mahoa" };
        string[] answers = new string[] { "MAHOA" };

        PlayerDTO player = new PlayerDTO();

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

            if (!EmailValidation.IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable dtPlayer = PlayerBUS.Instance.GetPlayer(txtEmail.Text, txtPassword.Text);
            if (dtPlayer.Rows.Count != 0)
            {
                int idPlayer = dtPlayer.Rows[0].Field<int>("idPlayer");
                player = PlayerBUS.Instance.GetPlayerByIDPlayer(idPlayer);
                this.Hide();
                GameGUI gameGUI = new GameGUI(player);
                gameGUI.ShowDialog();

            }
            else
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
            if (!EmailValidation.IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!EmailValidation.IsValid(txtEmailNew.Text))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPasswordNew.Text.Equals(txtReEnterPassword.Text))
            {
                // Insert Player
                PlayerBUS.Instance.InsertPlayerToDB(txtEmailNew.Text, txtPasswordNew.Text, 100);
                MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Insert Question
                DataTable dtPlayer = PlayerBUS.Instance.GetPlayer(txtEmailNew.Text, txtPasswordNew.Text);
                int idPlayer = dtPlayer.Rows[0].Field<int>("idPlayer");
                string imageLocation = Application.StartupPath + "\\Resources\\" + images[0] + ".jpg";
                QuestionBUS.Instance.InsertQuestionToDB(1, imageLocation, answers[0], idPlayer);
            }
            else
            {
                MessageBox.Show("Mật khẩu không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenNewPassword_Click(object sender, EventArgs e)
        {
            if (!EmailValidation.IsValid(txtEmailVerify.Text.Trim()))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dtPlayer = PlayerBUS.Instance.GetPlayerByEmail(txtEmailVerify.Text);
            if (dtPlayer.Rows.Count != 0)
            {
                // Phát sinh ngẫu nhiên mật khẩu mới
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[8];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                string newPassword = new String(stringChars);
                // Không cho phép tạo mật khẩu mới nhiều lần
                btnGenNewPassword.Enabled = false;

                try
                {

                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress("likeafternoonqp@gmail.com");
                    msg.To.Add(txtEmail.Text);
                    msg.Subject = "Thông báo Bảo mật quan trọng";
                    msg.Body = "Mật khẩu mới của bạn : " + newPassword;

                    SmtpClient smt = new SmtpClient();
                    smt.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential ntcd = new NetworkCredential();
                    ntcd.UserName = "likeafternoonqp@gmail.com";
                    ntcd.Password = "Matkhauqp1";
                    smt.Credentials = ntcd;
                    smt.EnableSsl = true;
                    smt.Port = 587;
                    smt.Send(msg);

                    MessageBox.Show("Mật khẩu mới của bạn được gửi về Email của bạn");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                PlayerBUS.Instance.UpdatePassword(txtEmailVerify.Text, newPassword);
            }
        }

        private void llbBack1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer1.Start();
        }

        private void llbBack2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer2.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (hidden1)
            {
                pnlLeft.Width = pnlLeft.Width + 10;
                if (pnlLeft.Width >= 450)
                {
                    Timer1.Stop();
                    hidden1 = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlLeft.Width = pnlLeft.Width - 10;
                if (pnlLeft.Width <= 10)
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

        private void LoginGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("BẠN CHẮC CHẮN ĐÓNG ỨNG DỤNG KHÔNG?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Application.ExitThread();
        }

        private void txtEmailNew_Leave(object sender, EventArgs e)
        {
            DataTable dtPlayer = PlayerBUS.Instance.GetPlayerByEmail(txtEmailNew.Text);
            if (dtPlayer.Rows.Count != 0)
            {
                MessageBox.Show("Email này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmailNew.Focus();
            }
        }
    }
}
