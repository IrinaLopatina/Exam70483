using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace SchoolService
{
    /// <summary>
    /// Summary description for SchoolWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SchoolWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public void Add(string serializedNewStudent)
        {
            JavaScriptSerializer dataContract = new JavaScriptSerializer();
            Student newStudent = dataContract.Deserialize<Student>(serializedNewStudent);

            SqlConnection sqlConnection = GetSqlConnection();
            sqlConnection.Open();
            string command = string.Format("Insert into Student values({0},'{1}')", newStudent.StudentId, newStudent.StudentName);
            SqlCommand cmd = new SqlCommand(command, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private SqlConnection GetSqlConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"localhost\MSSQLSERVER01";
            builder.InitialCatalog = "School";
            builder.IntegratedSecurity = true;

            return new SqlConnection (builder.ToString());
        }

        [WebMethod]
        public string ReadAll()
        {
            List<Student> students = new List<Student>();

            SqlConnection sqlConnection = GetSqlConnection();

            sqlConnection.Open();
            string command = "select * from Student";
            SqlCommand cmd = new SqlCommand(command, sqlConnection);

            SqlDataReader reader = cmd.ExecuteReader();

            int studentId = 0;
            string studentName = null;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    studentId = int.Parse(reader[0].ToString());
                    studentName = reader[1].ToString();

                    var student = new Student
                    {
                        StudentId = studentId,
                        StudentName = studentName
                    };
                    students.Add(student);
                }
            }
            reader.Close();
            sqlConnection.Close();

            //Serialisation
            JavaScriptSerializer dataContract = new JavaScriptSerializer();
            string serializedDataInStringFormat = dataContract.Serialize(students);
            return serializedDataInStringFormat;
        }
    }
}
