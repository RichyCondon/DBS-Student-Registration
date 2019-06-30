using DBS_Student_Registration.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_Student_Registration.Forms
{
    public partial class StudentDeleteForm : Form
    {
        static DAO dao = new DAO();
        public StudentDeleteForm()
        {
            InitializeComponent();
            dgvStudents.DataSource = dao.refreshTable();
        }

        //Form buttons
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            Student.deleteStudent(int.Parse(textBoxStudentId.Text));
            StudentInterface studentInterface = new StudentInterface();
            studentInterface.Show();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            new StudentInterface().Show();
        }

        //Menu strip items
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

        private void viewDatabaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new DBHistory().Show();
        }

        private void exportXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new XMLExportForm().Show();

        }

        //Fills current selection from datagrid view into textbox
        private void dgvStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudents.CurrentRow.Index != -1)
            {
                textBoxStudentId.Text = dgvStudents.CurrentRow.Cells[0].Value.ToString();
                
            }
        }

        
    }
}
