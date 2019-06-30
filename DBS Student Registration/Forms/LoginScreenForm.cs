using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DBS_Student_Registration
{
    public partial class LoginScreen : Form
    {
        Login login = new Login("admin", "1234");
        
       
        public LoginScreen()
        {
            InitializeComponent();
        }

        //Toolstrip Menu Controls
        private void exitToolStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //BUtton on form
        private void btnLogInUser_Click(object sender, EventArgs e)
        {
            string user = txtBoxUserName.Text;
            string pass = txtBoxPassword.Text;
            //check if user is eligible to be logged in 

            if (login.IsLoggedIn(user, pass))
            {
                
                StudentInterface studentEntry = new StudentInterface();
                studentEntry.Show();
                Close();
            }
            
            else
            {
                
                MessageBox.Show("Try again!");
                foreach (var c in Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = String.Empty;
                    }
                }

            }

        }

       
    }
}
