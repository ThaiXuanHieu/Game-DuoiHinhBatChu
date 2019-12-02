using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GameGUI : Form
    {
        PlayerDTO player;
        QuestionDTO question;
        string[] images = new string[] { "mahoa", "xauho", "yeuot", "xalan", "cobap", "bienhieu", "tichphan", "nhanhieu", "xemtuong", "tungtang", "thichthu", "thankhoc", "motmatmuoingo", "duongxichdao", "danhgiaplaca", "bachimbaynoi", "toganlonmat", "nghesinhandan", "nutthatcochai", "guongchieuhau" };
        string[] answers = new string[] { "MAHOA", "XAUHO", "YEUOT", "XALAN", "COBAP", "BIENHIEU", "TICHPHAN", "NHANHIEU", "XEMTUONG", "TUNGTANG", "THICHTHU", "THANKHOC", "MOTMATMUOINGO", "DUONGXICHDAO", "DANHGIAPLACA", "BACHIMBAYNOI", "TOGANLONMAT", "NGHESINHANDAN", "NUTTHATCOCHAI", "GUONGCHIEUHAU" };
        string[] answersVie = new string[] { "MÃ HÓA", "XẤU HỔ", "YẾU ỚT", "XÀ LAN", "CƠ BẮP", "BIỂN HIỆU", "TÍCH PHÂN", "NHÃN HIỆU", "XEM TƯỚNG", "TUNG TĂNG", "THÍCH THÚ", "THAN KHÓC", "MỘT MẤT MƯỜI NGỜ", "ĐƯỜNG XÍCH ĐẠO", "ĐÁNH GIÁP LÁ CÀ", "BA CHÌM BẢY NỔI", "TO GAN LỚN MẬT", "NGHỆ SĨ NHÂN DÂN", "NÚT THẮT CỔ CHAI", "GƯƠNG CHIẾU HẬU" };
        List<Button> buttons;

        Bitmap bitmap;

        int i = 0;
        TextBox[] textBoxes;
        string result = string.Empty;
        int index = 0;
        string imageLocation = Application.StartupPath + "\\Resources\\";

        public GameGUI(PlayerDTO _player)
        {
            InitializeComponent();

            this.player = _player;
            
        }

        private void GameGUI_Load(object sender, EventArgs e)
        {
            
            question = QuestionBUS.Instance.GetQuestionByIDPlayer(player.IDPlayer);
            index = question.IDQuestion;// = 1
            lblCoin.Text = player.Coin.ToString();// = 100;
            lblOrdinal.Text = question.IDQuestion.ToString();// = 1;
            picQuestion.Image = new Bitmap(question.ImageQuestion + ".jpg");
            GenTextBox();
            GenButtonChar(index);
        }
  
        public void CheckAnswer()
        {
            if (result.Equals(answers[index - 1]))
            {
                string text = "ĐÁP ÁN : " + answersVie[index - 1];
                MessageBox.Show("CHÚC MỪNG! THƯỞNG 100 COIN\n\n" + text, "Thông báo");
                RemoveTextBox();
                LoadNextQuestion();
            }
            else
            {
                MessageBox.Show("Sai rồi! Mời nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                for(int i = 0; i < answers[index - 1].Length; i++)
                {
                    textBoxes[i].Text = string.Empty;
                }

                i = 0;
                result = string.Empty;

                GenButtonChar(index);
            }
        }

        public void LoadNextQuestion()
        {
            // Xóa các button của câu hỏi cũ
            foreach (var btn in buttons)
            {
                pnlButton.Controls.Remove(btn);
            }

            index++;
            CheckWin();
            lblOrdinal.Text = index.ToString(); // ordinal = 2
            lblCoin.Text = (int.Parse(lblCoin.Text) + 100).ToString(); // coin = 200
            bitmap = new Bitmap(Application.StartupPath + "\\Resources\\" + images[index - 1].ToString() + ".jpg"); 
            picQuestion.Image = bitmap;
            GenTextBox();
            GenButtonChar(index);
            i = 0;
            result = string.Empty;

        }

        public void CheckWin()
        {
            if(index > 20)
            {
                MessageBox.Show("CHÚC MỪNG! BẠN ĐÃ VƯỢT QUA HẾT CÁC CÂU HỎI\nCHƠI LẠI TỪ ĐẦU", "Thông báo", MessageBoxButtons.OK);
                index = 1;
            }
        }

        public void RemoveTextBox()
        {
            for (int i = 0; i < answers[index - 1].Length; i++)
            {
                this.Controls.Remove(textBoxes[i]);
            }
        }

        public void GenTextBox()
        {
            int length = answers[index - 1].Length; // index = 1 => length = 8;
            textBoxes = new TextBox[length];

            int ToaDoX = picQuestion.Size.Width/length;
            int ToaDoY = 460;
            
            for (int i = 0; i < length; i++)
            {
                textBoxes[i] = new TextBox()
                {
                    Size = new Size(40, 40),
                    Location = new Point(ToaDoX - 20, ToaDoY),
                    Font = new Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold),
                    TextAlign = HorizontalAlignment.Center,
                    Text = string.Empty
                };
                
                this.Controls.Add(textBoxes[i]);

                ToaDoX += 45;
            }
        }

        // Tạo các Button với các ký tự được phát sinh ngẫu nhiên từ Đáp án và Bảng chữ cái
        private void GenButtonChar(int index)
        {
            
            List<string> chars = new List<string>(14);
            foreach(var ch in answers[index - 1])
            {
                chars.Add(ch.ToString());
            }

            Random rd = new Random();
            int indexRandom;
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVXY".ToCharArray();

            for (int i = chars.Count; i < chars.Capacity; i++)
            {
                indexRandom = rd.Next(alphabet.Length);
                chars.Add(alphabet[i].ToString());
            }

            buttons = new List<Button>() { btnChar1, btnChar2, btnChar3, btnChar4, btnChar5, btnChar6, 
            btnChar7, btnChar8, btnChar9, btnChar10, btnChar11, btnChar12, btnChar13, btnChar14};

            foreach(var button in buttons)
            {
                indexRandom = rd.Next(chars.Count);
                button.Text = chars[indexRandom];
                chars.Remove(chars[indexRandom]);

                pnlButton.Controls.Add(button);
            }

        }

        private void btnChar_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBoxes[i].Text = btn.Text;
            pnlButton.Controls.Remove(btn);
            result += btn.Text;
            i++;
            if (i == answers[index - 1].Length)
            {
                CheckAnswer();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Lưu và Thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                PlayerBUS.Instance.UpdatePlayer(player.IDPlayer, int.Parse(lblCoin.Text));
                QuestionBUS.Instance.UpdateQuestion(Int32.Parse(lblOrdinal.Text), imageLocation + images[index - 1], answers[index - 1], question.IDPlayer);

                Application.Exit();
            }
        }

        private void btnOnOffSound_CheckedChanged(object sender, EventArgs e)
        {
            if(btnOnOffSound.Checked)
            {
                btnOnOffSound.BackgroundImage = global::GUI.Properties.Resources.icons8_No_Audio_32px;
                LoginGUI.Instance.Stop();
            }
            else
            {
                btnOnOffSound.BackgroundImage = global::GUI.Properties.Resources.icons8_Audio_32px;
                LoginGUI.Instance.Play();
            }
        }
    }
}
