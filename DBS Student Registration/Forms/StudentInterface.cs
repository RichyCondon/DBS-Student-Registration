using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using DBS_Student_Registration.Forms;
using DBS_Student_Registration.DataAccess;

namespace DBS_Student_Registration
{
    public partial class StudentInterface: Form 
    {

        private DAO dao = new DAO();
        

        public StudentInterface()
        {
            InitializeComponent();
            
        }

        private void StudentEntry_Load(object sender, EventArgs e)
        {
            studentGrid.DataSource = dao.refreshTable();
            
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Close();
            new AddStudent().ShowDialog();
            
            
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            Close();
            new EditStudentForm().ShowDialog();

            
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            Close();
            new StudentDeleteForm().ShowDialog();
            

        }

        
        //Menu Strip items 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LandingPage().Show();
            Close();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new AddStudent().Show();

        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new StudentDeleteForm().Show();

        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewDatabaseHistory_Click(object sender, EventArgs e)
        {
            Close();
            new DBHistory().Show();
        }

        private void btnXMLExport_Click(object sender, EventArgs e)
        {
            Close();
            new XMLExportForm().Show();
            
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new EditStudentForm().Show();
        }

        private void viewDatabaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new DBHistory().Show();
        }
    }
}
