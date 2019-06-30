using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_Student_Registration
{
    class Login
    {  //declare properties 
        public string Username { get; set; }
        public string Userpassword { get; set; }

        //intialise  
        public Login(string user, string pass)
        {
            Username = user;
            Userpassword = pass;
        }
        //validate string 
        private bool StringValidator(string input)
        {
            string pattern = "[^a-zA-Z]";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //clear user inputs 
        private void ClearTexts(string user, string pass)
        {
            user = String.Empty;
            pass = String.Empty;
        }

        //method to check if eligible to be logged in 
        internal bool IsLoggedIn(string user, string pass)
        {
            //check user name empty 
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Enter the user name!");
                return false;

            }
            //check user name is valid type 
            else if (StringValidator(user))
            {
                MessageBox.Show("Enter only text here.");
                ClearTexts(user, pass);
                return false;
            }
            //check user name is correct 
            else
            {
                if (Username != user)
                {
                    MessageBox.Show("User name is incorrect!");
                    ClearTexts(user, pass);
                    return false;
                }
                //check password is empty 
                else
                {
                    if (string.IsNullOrEmpty(pass))
                    {
                        MessageBox.Show("Enter the password!");
                            
                        return false;
                    }
                    
                    //check password is correct 
                    else if (Userpassword != pass)
                    {
                        MessageBox.Show("Password is incorrect!");
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("You are logged in successfully");
                        return true;
                    }
                }
            }
        }
    }
} 
    

