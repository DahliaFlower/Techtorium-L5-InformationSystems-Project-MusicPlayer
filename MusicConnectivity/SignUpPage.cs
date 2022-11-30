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
        public partial class SignUpPage : Form
        {
        Login Obj_data = new Login();

        public SignUpPage()
                {
                    InitializeComponent();
                    captchaTxB2.Text = Obj_data.GenerateCaptcha();
                 }

                private void DOBLabel_Click(object sender, EventArgs e)
                {

                }

                private void PrivacyPolicyTxbx_TextChanged(object sender, EventArgs e)
                {

                }

                      //SR03 - Object Defined
                private void SignUpBtn_Click(object sender, EventArgs e)
                {
                     //SR04: Implement Captcha at Sign up:
                    bool val_Captcha = Obj_data.ValidateCaptcha(userCaptchaTB2.Text);
                    if (val_Captcha)
                    {

                        if (privacyPolicyCxBx.Checked) //SR05: Accept Privacy Policy to continue.
                        {
                            Registration newUser = new Registration(EmailTxBx.Text, createPwTxbx.Text, PrefferrednameTxBx.Text, DOBDateTimePicker.Text, genderAnswerTxBx.Text);
                            var homePage_Obj = new homePage();
                            MessageBox.Show("SignUp Successfull! ");
                            homePage_Obj.Closed += (s, args) => this.Close();
                            homePage_Obj.Show();
                        }
                        else
                        {
                            MessageBox.Show("Please accept the Privacy Policy to Continue.");  //SR05: If Privacy Policy  not checked, this message will show.
                        }
            

                    }
                    else
                    {
                        MessageBox.Show("Invalid Captcha");
                    }
        }



                private void privacyPolicyCxBx_CheckedChanged(object sender, EventArgs e)
                {

                }

                    //SR08: Change Colours for Accessibility / Vision impariment
                    private void accessibilityBtn_Click(object sender, EventArgs e)
                    {
                            BackColor = Color.FromArgb(0, 176, 240);
                            ForeColor = Color.FromArgb(56, 20, 79);
                            EmailTxBx.BackColor = Color.FromArgb(0, 176, 240);
                            conFEmailTxbx.BackColor = Color.FromArgb(0, 176, 240);
                            createPwTxbx.BackColor = Color.FromArgb(0, 176, 240);
                            ConfPwTxBx.BackColor = Color.FromArgb(0, 176, 240);
                            PrefferrednameTxBx.BackColor = Color.FromArgb(0, 176, 240);
                            DOBDateTimePicker.CalendarMonthBackground = Color.FromArgb(0, 176, 240);
                            DOBDateTimePicker.BackColor = Color.FromArgb(0, 176, 240);
                            genderAnswerTxBx.BackColor = Color.FromArgb(0, 176, 240);
                            PrivacyPolicyTxbx.BackColor = Color.FromArgb(0, 176, 240);
                            PrivPolAgreeLabel.BackColor = Color.FromArgb(0, 176, 240);
                            captchaTxB2.BackColor = Color.FromArgb(0, 176, 240);
                            SignUpBtn.BackColor = Color.FromArgb(56, 20, 79);
                            SignUpBtn.ForeColor = Color.FromArgb(0, 176, 240);
                            textTB.BackColor = Color.FromArgb(0, 176, 240);

                            float scaleX = ((float)Screen.PrimaryScreen.WorkingArea.Width / 1024);
                            float scaleY = ((float)Screen.PrimaryScreen.WorkingArea.Height / 768);
                            SizeF aSf = new SizeF(scaleX, scaleY);
                            this.Scale(aSf);
              
                     }
    
                    public void accessibilityContrast()
                            {
                                
                                

                            }

        private void refreshBtn2_Click(object sender, EventArgs e)
        {
            captchaTxB2.Text = Obj_data.GenerateCaptcha();
        }
    }


}
