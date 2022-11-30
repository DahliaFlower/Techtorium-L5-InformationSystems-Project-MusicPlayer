using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MusicConnectivity
{
      //SR06: Class Login & constructor
    public class Login
    {
        public string username;
        public string passWord;
        int number = 0;

        //Constructor
        public Login()
        {
            username = "monarch";
            passWord = "flutter";
            
        }

        //SR04: Method to Generate Captcha
        public string GenerateCaptcha()
        {
            Random randomNumber = new Random();
            number = randomNumber.Next(9999, 20000);
            return number.ToString();

        }

        //SR04: Method to Validate Captcha
                public bool ValidateCaptcha(string userCaptcha)
        {
            if (number.ToString() == userCaptcha)
            {
                return true;
            }

            else 
            {
                return false;
            }

        }

        //SR06: Validate username and login for secure access
        public string processLogin(string username, string password)
        {
            if (username != this.username)
            {
                return "User name not valid";
            }

            if (password != this.passWord)
            {
                return "Password not valid";
            }

            else
            {
                return "User login Successfull";
            }

         }


    }
}
