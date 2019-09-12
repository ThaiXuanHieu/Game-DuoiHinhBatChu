using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GUI
{
    public partial class LoginGUI : Form
    {
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

        public LoginGUI()
        {
            InitializeComponent();
        }

        private void btnLoginGUI_Click(object sender, EventArgs e)
        {
            signupUC.Visible = false;
            loginUC.Visible = true;
            btnLoginGUI.BackColor = Color.White;
            btnLoginGUI.ForeColor = Color.DodgerBlue;
            btnSignupGUI.BackColor = Color.DodgerBlue;
            btnSignupGUI.ForeColor = Color.White;
        }

        private void btnSignupGUI_Click(object sender, EventArgs e)
        {
            signupUC.Visible = true;
            loginUC.Visible = false;
            btnSignupGUI.BackColor = Color.White;
            btnSignupGUI.ForeColor = Color.DodgerBlue;
            btnLoginGUI.BackColor = Color.DodgerBlue;
            btnLoginGUI.ForeColor = Color.White;
        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {
            loginUC.Visible = true;
            signupUC.Visible = false;
            instance = new SoundPlayer("Login.wav");
            instance.Play();
        }
    }
}
