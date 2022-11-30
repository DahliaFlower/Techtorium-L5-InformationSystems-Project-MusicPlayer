using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicConnectivity
{
    // SR03 - Class named Registration:
    public class Registration
    {
        public string email;
        public string passWord;
        public string prefferredName;
        public string DateOfBirth;
        public string gender;
           
         //Constructor
        public Registration(string email, string passWord, string preffferredName, string DateOfBirth, string gender)
        {
            this.email = email;
            this.passWord = passWord;
            this.prefferredName = passWord;
            this.DateOfBirth = DateOfBirth;
            this.gender = gender;

         }

    }
}
