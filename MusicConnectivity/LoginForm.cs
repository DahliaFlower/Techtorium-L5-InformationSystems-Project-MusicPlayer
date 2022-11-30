using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicConnectivity
{
    
    public partial class LoginForm : Form
    {
        //SR06: Login Object Defined
        Login Obj_data = new Login();

        public LoginForm()
        {
            InitializeComponent();
            captchaTxB.Text = Obj_data.GenerateCaptcha();
            
         }

        private void rememberMeChxBx_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        
        private void LogInBtn_Click(object sender, EventArgs e)
        {
            //SR07: Captcha Method being called
            bool val_Captcha = Obj_data.ValidateCaptcha(userCaptchaTB.Text);
            if (val_Captcha)
            {
                string message = Obj_data.processLogin(userNameTBx.Text, passWordTBx.Text);
                if (message == "User login Successfull")
                {
                    MessageBox.Show(message);
                    this.Hide();
                    var homePage_Obj = new homePage();
                    homePage_Obj.Closed += (s, args) => this.Close();
                    homePage_Obj.Show();
                }

                else
                {
                    MessageBox.Show(message);
                }

            }

            else
            {
                MessageBox.Show("Invalid Captcha");
            }


         }

        //Refresh button to renew captcha
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            captchaTxB.Text = Obj_data.GenerateCaptcha();
        }

        private void accessibilityLogInBtn_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(0, 176, 240);
            ForeColor = Color.FromArgb(56, 20, 79);
            userNameTBx.BackColor = Color.FromArgb(0, 176, 240);
            userNameTBx.ForeColor = Color.FromArgb(56, 20, 79);
            passWordTBx.BackColor = Color.FromArgb(0, 176, 240);
            passWordTBx.ForeColor = Color.FromArgb(56, 20, 79);
            rememberMeChxBx.BackColor = Color.FromArgb(0, 176, 240);
            captchaTxB.BackColor = Color.FromArgb(0, 176, 240);
            userCaptchaTB.BackColor = Color.FromArgb(0, 176, 240);
            forgotPwLinkLabel.BackColor = Color.FromArgb(0, 176, 240);
            FBsignInPixBx.BackColor = Color.FromArgb(0, 176, 240);
            googleSignInPixBx.BackColor = Color.FromArgb(0, 176, 240);
            groupBox2.BackColor = Color.FromArgb(56, 20, 79);
            signUpHereBtn.ForeColor = Color.FromArgb(56, 20, 79);
            AccLinkLabel.BackColor = Color.FromArgb(0, 176, 240);

            float scaleX = ((float)Screen.PrimaryScreen.WorkingArea.Width / 1024);
            float scaleY = ((float)Screen.PrimaryScreen.WorkingArea.Height / 768);
            SizeF aSf = new SizeF(scaleX, scaleY);
            this.Scale(aSf);

        }
    }
}
