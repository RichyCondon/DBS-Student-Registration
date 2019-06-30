using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS_Student_Registration.DataAccess
{
    public class XMLExport : DAO
    {
        public bool StudentXML(string filename, string studentid, string firstname, string surname, string address1, string address2, string city, string county, string email, string phone, string level, string course)
        {

            DataSet ds = new DataSet();
            DataTable dt;
            ds = new DataSet("StudentExport");
            dt = new DataTable("StudentXML");
            dt.Columns.Add("StudentID");
            dt.Columns.Add("FirstName");
            dt.Columns.Add("Surname");
            dt.Columns.Add("Address1");
            dt.Columns.Add("Address2");
            dt.Columns.Add("City");
            dt.Columns.Add("County");
            dt.Columns.Add("Email");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Level");
            dt.Columns.Add("Course");
            ds.Tables.Add(dt);

            dt = ds.Tables["StudentXML"];
            DataRow row = dt.NewRow();
            row["StudentID"] = studentid;
            row["FirstName"] = firstname;
            row["Surname"] = surname;
            row["Address1"] = address1;
            row["Address2"] = address2;
            row["City"] = city;
            row["County"] = county;
            row["Email"] = email;
            row["Phone"] = phone;
            row["Level"] = level;
            row["Course"] = course;
            dt.Rows.Add(row);
            dt.AcceptChanges();
            if (filename == "")
            {
                filename = "Students.xml";
            }
            ds.WriteXml(filename);
            return true;


        }


    }
}
