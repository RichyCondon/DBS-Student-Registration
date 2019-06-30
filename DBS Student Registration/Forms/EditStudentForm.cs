using DBS_Student_Registration.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_Student_Registration.Forms
{
    public partial class EditStudentForm : Form
    {
        private DAO dao = new DAO();

        public EditStudentForm()
        {
            InitializeComponent();
            studentGrid.DataSource = dao.refreshTable();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

            //Validates collection of textboxes on form to ensure they are not empty
            var textBoxCollection = new[] { textBoxStudentId, textBoxEmail, textBoxPhone,
                textBoxAddressL1, textBoxAddressL2, textBoxCity, textBoxLevel };

            bool atleastOneTextboxEmpty = textBoxCollection
                                   .Any(t => string.IsNullOrWhiteSpace(t.Text));
            //If one is empty, form will not submit
            if (atleastOneTextboxEmpty)
            {
                MessageBox.Show("No fields can be left empty.");
                DialogResult = DialogResult.None;
            }
            //Email validation
            else if (!IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Email address must be valid format");
                DialogResult = DialogResult.None;

            }
            else
            {
                Student.editStudent(int.Parse(textBoxStudentId.Text),
                 textBoxEmail.Text, textBoxPhone.Text,
                 textBoxAddressL1.Text, textBoxAddressL2.Text,
                 textBoxCity.Text, cBoxCounty.Text,
                 textBoxLevel.Text);

                StudentInterface studentInterface = new StudentInterface();
                studentInterface.Show();
                Close();
            }

        }

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            new StudentInterface().Show();
        }


        //Toolstrip menu items. Enables quick navigation between sections.
        private void viewDatabaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new DBHistory().Show();
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

        private void exportXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new XMLExportForm().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LandingPage().Show();
            Close();
        }



        //Double clicking on record in the grid view populates the textboxes with the chosen selection to edit.
        private void studentGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (studentGrid.CurrentRow.Index != -1)
            {
                textBoxStudentId.Text = studentGrid.CurrentRow.Cells[0].Value.ToString();
                textBoxAddressL1.Text = studentGrid.CurrentRow.Cells[3].Value.ToString();
                textBoxAddressL2.Text = studentGrid.CurrentRow.Cells[4].Value.ToString();
                textBoxCity.Text = studentGrid.CurrentRow.Cells[5].Value.ToString();
                cBoxCounty.Text = studentGrid.CurrentRow.Cells[6].Value.ToString();
                textBoxPhone.Text = studentGrid.CurrentRow.Cells[7].Value.ToString();
                textBoxEmail.Text = studentGrid.CurrentRow.Cells[8].Value.ToString();
                textBoxLevel.Text = studentGrid.CurrentRow.Cells[9].Value.ToString();
                
            }
        }

        //
        //Data verification
        //

        //Email validation function
        bool IsValidEmail(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        ////Disallows anything other than numbers, delete or backspace key presses for number fields.
        private void textBoxStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

       
    }
}
