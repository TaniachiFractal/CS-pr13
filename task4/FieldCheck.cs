using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task4
{
    internal class FieldCheck
    {
        // List of regular expressions
        static readonly Regex regexLogin = new Regex(@"^[a-zA-z0-9_-]{1,50}$");
        static readonly Regex regexPassword = new Regex(@"^[a-zA-z0-9(@|#|$|%)]{8,15}$");
        static readonly Regex regexEmail = new Regex(@"^[a-zA-z0-9.]{1,100}@[a-zA-z0-9.]{1,100}\.[a-zA-z0-9.]{1,100}$");




        static public bool CheckNotEmpty(string name)
        {
            if (name == string.Empty)
            {
                return false;
            }
            return true;
        }

        // Functions for checking regexes
        static public bool CheckLogin(string login)
        {
            if (regexLogin.Match(login).Success)
            {
                return true;
            }
            return false;
        }

        static public bool CheckPassword(string password)
        {
            if (regexPassword.Match(password).Success)
            {
                return true;
            }
            return false;
        }

        static public bool CheckEmail(string email)
        {
            if (regexEmail.Match(email).Success)
            {
                return true;
            }
            return false;
        }
    }
}
