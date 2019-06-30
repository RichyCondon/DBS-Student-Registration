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
    public partial class XMLExportForm : Form
    {
        static DAO dao = new DAO();

        public XMLExportForm()
        {
            InitializeComponent();
            dgvStudents.DataSource = dao.refreshTable();
        }

       //Select, by double clicking record, a student for exporting, auto fills textboxes.

        private void dgvStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudents.CurrentRow.Index != -1)
            {
                textBoxStudentId.Text = dgvStudents.CurrentRow.Cells[0].Value.ToString();
                textBoxFName.Text = dgvStudents.CurrentRow.Cells[1].Value.ToString();
                textBoxSName.Text = dgvStudents.CurrentRow.Cells[2].Value.ToString();
                textBoxAddressL1.Text = dgvStudents.CurrentRow.Cells[3].Value.ToString();
                textBoxAddressL2.Text = dgvStudents.CurrentRow.Cells[4].Value.ToString();
                textBoxCity.Text = dgvStudents.CurrentRow.Cells[5].Value.ToString();
                textBoxCounty.Text = dgvStudents.CurrentRow.Cells[6].Value.ToString();
                textBoxPhone.Text = dgvStudents.CurrentRow.Cells[7].Value.ToString();
                textBoxEmail.Text = dgvStudents.CurrentRow.Cells[8].Value.ToString();
                textBoxLevel.Text = dgvStudents.CurrentRow.Cells[9].Value.ToString();
                textBoxCourse.Text = dgvStudents.CurrentRow.Cells[10].Value.ToString();
            }
        }

        //Auto fills file name if not entered, creates & exports XML using XML Export class in the Data Access layer
        private void exportXMLBtn_Click(object sender, EventArgs e)
        {
            if (textBoxFileName.Text == "")
            {
                textBoxFileName.Text = "Student.xml";
            }
            XMLExport exportXML = new XMLExport();

            exportXML.StudentXML(textBoxFileName.Text.Trim(), textBoxStudentId.Text.Trim(), 
                textBoxFName.Text.Trim(), textBoxSName.Text.Trim(), 
                textBoxAddressL1.Text.Trim(), textBoxAddressL2.Text.Trim(), 
                textBoxCity.Text.Trim(), textBoxCounty.Text.Trim(), textBoxPhone.Text.Trim(), 
                textBoxEmail.Text.Trim(),textBoxLevel.Text.Trim(), textBoxCourse.Text.Trim());

            MessageBox.Show("Exported Successfully!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StudentInterface studentInterface = new StudentInterface();
            studentInterface.Show();
            Close();
        }

        //Menustrip items for system nav
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

        private void viewDatabaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new DBHistory().Show();
        }
    }
}
