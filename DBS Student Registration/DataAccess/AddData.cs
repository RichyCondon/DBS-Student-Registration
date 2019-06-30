using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_Student_Registration.DataAccess
{
    class AddData : DAO
    {
        public void addStudent(int Student_Id, string firstName, string lastName, string email,
            string phoneNumber, string addressLine1, string addressLine2, string city,
            string country, string level, string course)
        {

            


            SqlCommand cmd = new SqlCommand("INSERT INTO Students (" +
                "Student_Id,[First Name],[Last Name],[Email],[Phone Number],[Address Line1],[Address Line2],[City],[Country],[Level],[Course]" +
                ")" +
                    "VALUES(@Student_Id,@firstName,@lastName,@email,@phoneNumber," +
                    "@addressLine1,@addressLine2,@city,@country,@level,@course)", openConnection());
            cmd.Parameters.AddWithValue("@Student_Id", Student_Id);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            cmd.Parameters.AddWithValue("@addressLine1", addressLine1);
            cmd.Parameters.AddWithValue("@addressLine2", addressLine2);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@country", country);
            cmd.Parameters.AddWithValue("@level", level);
            cmd.Parameters.AddWithValue("@course", course);

            SqlCommand cmd1 = new SqlCommand("INSERT INTO Students_History (Student_Added,Student_Edited,Student_Deleted)" +
                " VALUES(1,0,0)", openConnection());
            
            


            try
            {
                openConnection();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Sucessfully added.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", (ex.Message)));
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                closeConnection();

            }
        }



        
    }
}
