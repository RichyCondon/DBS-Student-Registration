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
    class EditData : DAO
    {
        public void editStudent(int Student_Id, string email,
            string phoneNumber, string addressLine1, string addressLine2, string city,
            string country, string level)
        {
            string date = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            SqlCommand cmd = new SqlCommand("UPDATE Students " +
            "SET [Email]=@email, [Phone Number]=@phonenumber, [Address Line1]=@addressLine1, " +
            "[Address Line2]=@addressLine2, " +
            "[City]=@city, [Country]=@country, [Level]=@level " +
            "WHERE Student_Id=@Student_Id;", openConnection());
            cmd.Parameters.AddWithValue("@Student_Id", Student_Id);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            cmd.Parameters.AddWithValue("@addressLine1", addressLine1);
            cmd.Parameters.AddWithValue("@addressLine2", addressLine2);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@country", country);
            cmd.Parameters.AddWithValue("@level", level);

            SqlCommand cmd1 = new SqlCommand("INSERT INTO Students_History (Student_Added,Student_Edited,Student_Deleted)" +
              " VALUES(0,1,0)", openConnection());
            

            try
            {
                openConnection();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();


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
