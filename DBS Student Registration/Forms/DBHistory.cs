using DBS_Student_Registration.DataAccess;
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

namespace DBS_Student_Registration.Forms
{
    public partial class DBHistory : Form
    {
        private DAO dao = new DAO();

        public DBHistory()
        {
            InitializeComponent();
            refreshTable();
            
        }
        public void refreshTable()
        {
            SqlCommand cmd = new SqlCommand("Select * From Students_History", dao.openConnection());
            try
            {
                dao.openConnection();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                studentHistoryGrid.DataSource = dt;
            }
            finally
            {
                dao.closeConnection();
            }

        }

       

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LandingPage().Show();
            Close();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new AddStudent().Show();
            
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new EditStudentForm().Show();
            
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new StudentDeleteForm().Show();
            

        }

        private void xMLExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new XMLExportForm().Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
            new StudentInterface().Show();
        }
    }
}
