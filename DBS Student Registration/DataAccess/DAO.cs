using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Student_Registration.DataAccess
{
    public class DAO
    {
        private SqlConnection conn;
        public DAO()
        {
            conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Richy\\source\\repos\\DBS Student Registration\\DBS Student Registration\\Students.mdf; Integrated Security=True;");
        }
        public SqlConnection openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed ||
                conn.State == System.Data.ConnectionState.Broken)
                conn.Open();
            return conn;
        }
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        public System.Data.DataTable FillSearchGridView(string studentname)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("StudentViewSearch", openConnection());
            sqlDa.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@StudentName", studentname);
            System.Data.DataTable dtbl = new System.Data.DataTable();
            sqlDa.Fill(dtbl);
            return dtbl;

        }

        public System.Data.DataTable refreshTable()
        {
            SqlCommand cmd = new SqlCommand("Select * From Students", openConnection());
            try
            {
                openConnection();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                return dt;
                
            }
            finally
            {
                closeConnection();
            }
        }

    }
}
