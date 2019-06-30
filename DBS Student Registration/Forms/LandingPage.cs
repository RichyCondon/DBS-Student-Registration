using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_Student_Registration
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            Hide();
        }
    }
}
