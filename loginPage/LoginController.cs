using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPage
{
    // Login Controller Class
    //
    // By: Dr. Ryan Rybarczyk
    public class LoginController
    {
        public LoginController()
        {
            myConnection_ = new DatabaseConnection();

            username_ = "";
            password_ = "";
        }

        public bool validateLogin(string username, string password)
        {
            username_ = username;
            password_ = password;

            if (password_.Length < 1)
            {
                return false;
            }
            else
            {
                string[] args = new string[2];

                args[0] = username_;
                args[1] = password_;

                if (myConnection_.selectQuery("login", args))
                {
                    return true;
                }
            }

            return false;
        }


        // Trailing underscore to identify local member.
        private DatabaseConnection myConnection_;
        private string username_;
        private string password_;
    }
}