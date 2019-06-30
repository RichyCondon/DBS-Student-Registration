using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_Student_Registration.DataAccess
{
    class DeleteData : DAO
    {


        public void deleteStudent(int Student_Id)
        {
            

            SqlCommand cmd = new SqlCommand("Delete FROM Students " +
                    "WHERE Student_Id=@Student_Id;", openConnection());
            cmd.Parameters.AddWithValue("@Student_Id", Student_Id);

            SqlCommand cmd1 = new SqlCommand("INSERT INTO Students_History (Student_Added,Student_Edited,Student_Deleted)" +
                " VALUES(0,0,1)", openConnection());
            

            try
            {
                openConnection();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show($"Student {Student_Id} sucessfully deleted");
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
