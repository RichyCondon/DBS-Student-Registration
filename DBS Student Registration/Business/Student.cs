using DBS_Student_Registration.DataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace DBS_Student_Registration
{
    
    public class Student
    {
        static AddData data = new AddData();
        static DeleteData delete = new DeleteData();
        static EditData edit = new EditData();
        
        

        public int Student_Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string Level { get; private set; }
        public string Course { get; private set; }

      

        public Student(int sid, string f, string l, string e, string p,
            string a1, string a2, string c, string cu, string lvl, string co)
        {
            Student_Id = sid;
            FirstName = f;
            LastName = l;
            Email = e;
            PhoneNumber = p;
            AddressLine1 = a1;
            AddressLine2 = a2;
            City = c;
            Country = cu;
            Level = lvl;
            Course = co;
        }

        public Student(int sid, string e, string p,
            string a1, string a2, string c, string cu, string lvl)
        {
            Student_Id = sid;
            Email = e;
            PhoneNumber = p;
            AddressLine1 = a1;
            AddressLine2 = a2;
            City = c;
            Country = cu;
            Level = lvl;
            
        }

        public Student(int sid)
        {
            Student_Id = sid;
            
        }

        public void addtoDB()
        {
            data.addStudent(Student_Id, FirstName, LastName, Email, PhoneNumber, AddressLine1, AddressLine2,
                City, Country, Level, Course);
        }

        public void deletefromDB()
        {
            delete.deleteStudent(Student_Id);
        }

        public void editDB()
        {
            edit.editStudent(Student_Id, Email, PhoneNumber, AddressLine1, AddressLine2,
                City, Country, Level);
        }

        

        public static void addStudent(int sid, string f, string l, string e, string p, 
            string a1, string a2, string c, string cu, string lvl, string co)
        {
            Student s = new Student(sid,f,l,e,p,a1,a2,c,cu,lvl,co);
            //string xml = GetXMLFromObject(s);
            s.addtoDB();
        }

        public static void editStudent(int sid, string e, string p,
           string a1, string a2, string c, string cu, string lvl)
        {
            Student s = new Student(sid, e, p, a1, a2, c, cu, lvl);

            s.editDB();
        }

        public static void deleteStudent(int sid)
        {
            Student s = new Student(sid);

            s.deletefromDB();
        }

        //public static string GetXMLFromObject(object o)
        //{
        //    StringWriter sw = new StringWriter();
        //    XmlTextWriter tw = null;
        //    try
        //    {
        //        XmlSerializer serializer = new XmlSerializer(o.GetType());
        //        tw = new XmlTextWriter(sw);
        //        serializer.Serialize(tw, o);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        sw.Close();
        //        if (tw != null)
        //        {
        //            tw.Close();
        //        }
        //    }
        //    return sw.ToString();
        //}

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
