using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class validateMe
    {

        public string registerUser(string username)
        {
            string msg = "";
            if (username.Length < 1)
            {
                msg += "Please fill out Username.\n";
            }
            return msg;
        }

        public string registerPass(string pass1, string pass2)
        {
            string msg = "";
            if (pass1 != pass2)
            {
                msg += "Your passwords do not match!\n";
                return msg;
            }
            if (pass1.Length < 5)
            {
                msg += "Password minimum is 5 chars!\n";
            }
            return msg;
        }








    }
    }

