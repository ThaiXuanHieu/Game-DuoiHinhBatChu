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
using DTO;

namespace GUI
{
    public partial class LoginUC : UserControl
    {

        public LoginUC()
        {
            InitializeComponent();
        }

        private void txt_Click(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(textBox.Text == "Tên người chơi")
            {
                txtPlayerNameLoginUC.Text = "";
            }
            else
            {
                txtPasswordLoginUC.Text = "";
            }
        }

        private void btnLoginUC_Click(object sender, EventArgs e)
        {
            GameGUI gameGUI = new GameGUI(txtPlayerNameLoginUC.Text);
            PlayerDTO player = new PlayerDTO();
            player = PlayerBUS.Instance.GetPlayerByPlayerName(txtPlayerNameLoginUC.Text);
            if (player.PlayerName == txtPlayerNameLoginUC.Text && player.Password == txtPasswordLoginUC.Text)
            {
                
                gameGUI.Show();
                
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc Mật khẩu không đúng", "Thông báo");
            }
        }
    }
}
