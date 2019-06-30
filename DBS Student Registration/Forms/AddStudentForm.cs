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
using DBS_Student_Registration.Forms;
using DBS_Student_Registration.DataAccess;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace DBS_Student_Registration
{
    public partial class AddStudent : Form
    {
        static DAO dao = new DAO();
        

        public AddStudent()
        {
            InitializeComponent();
            
        }

        //Buttons on form

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        //Submit Button - Submits student to DB & performs verification checks on click
        private void submitBtn_Click(object sender, EventArgs e)
        {
            //Validates collection of textboxes on form to ensure they are not empty
            var textBoxCollection = new[] { textBoxStudentId, textBoxfName, textBoxSName, textBoxEmail, textBoxPhone,
                textBoxAddressL1, textBoxAddressL2, textBoxCity, textBoxLevel, textBoxCourse };

            bool atleastOneTextboxEmpty = textBoxCollection
                                   .Any(t => String.IsNullOrWhiteSpace(t.Text));
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
                Student.addStudent(int.Parse(textBoxStudentId.Text),
                 textBoxfName.Text, textBoxSName.Text,
                 textBoxEmail.Text, textBoxPhone.Text,
                 textBoxAddressL1.Text, textBoxAddressL2.Text,
                 textBoxCity.Text, cBoxCounty.Text,
                 textBoxLevel.Text, textBoxCourse.Text);


                StudentInterface studentInterface = new StudentInterface();
                studentInterface.Show();
                Close();
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
            new StudentInterface().Show();
        }

        //
        //Menu Strip Controls Start
        //

        //Logs user out
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LandingPage().Show();
            Close();
        }

        //Exits App
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Goes to "delete student" section & closes this form
        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new StudentDeleteForm().Show();
        }

        //Goes to "edit student" section & closes this form
        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new EditStudentForm().Show();
        }

        //Goes to "view DB History section/gridview
        private void viewDatabaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new DBHistory().Show();
        }

        private void xMLExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            new XMLExportForm().Show();

        }
        //Menu Strip Controls end

        //
        //Validation & Form Control start
        //

        //Clears all textbxes in the form
        private void clearFields()
        {
            foreach (var c in Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
        }

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
        

        //Disallows anything other than numbers, delete or backspace key presses for fields requiring numbers.
        private void textBoxStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;

            }

        }

       
    }
}
