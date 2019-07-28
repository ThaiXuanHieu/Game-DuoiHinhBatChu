using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.IO;

namespace GUI
{
    public partial class SignupUC : UserControl
    {
        string[] images = new string[] { "kichdong" };
        string[] answers = new string[] { "KICHDONG" };
        Bitmap bitmap;

        public SignupUC()
        {
            InitializeComponent();
        }

        private void txt_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(textBox.Text == "Tên người chơi")
            {
                txtPlayerNameSignupUC.Text = "";
            }
            else
            {
                txtPasswordSignupUC.Text = "";
            }
            
        }

        private void btnSignupUC_Click(object sender, EventArgs e)
        {
            PlayerBUS.Instance.SavePlayerToDB(txtPlayerNameSignupUC.Text, txtPasswordSignupUC.Text, 100);
            lblNotifySignupSuccess.Text = "Đăng ký thành công";
            SaveQuestionToDB();
        }

        public byte[] ConvertImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public void SaveQuestionToDB()
        {
            bitmap = new Bitmap(Application.StartupPath + "\\Resources\\" + images[0] + ".jpg");

            QuestionBUS.Instance.SaveQuestionToDB("1", ConvertImageToByteArray(bitmap), answers[0], txtPlayerNameSignupUC.Text);
        }
    }
}
