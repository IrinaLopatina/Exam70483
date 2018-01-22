using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;

namespace ClientOfSchoolService
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the proxy for service to use its methods
            MySchoolWebService.SchoolWebServiceSoapClient proxy = new MySchoolWebService.SchoolWebServiceSoapClient();

            //Serialisation/Deserialization
            JavaScriptSerializer dataContract = new JavaScriptSerializer();

            Console.WriteLine("Insert student Id: ");
            int studentId = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert student name: ");
            string studentName = Console.ReadLine();

            Student newStudent = new Student
            {
                StudentId = studentId,
                StudentName = studentName
            };

            string serializedNewStudent = dataContract.Serialize(newStudent);
            proxy.Add(serializedNewStudent);

            string serializedDataInStringFormat = proxy.ReadAll();

            List<Student> students = null;
            students = dataContract.Deserialize<List<Student>>(serializedDataInStringFormat);

            Console.WriteLine("All students.............................");
            foreach (var student in students)
            {
                Console.WriteLine("StudentId: {0}, StudentName: {1}", student.StudentId, student.StudentName);
            }
        }

        private class Student
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
        }
    }
}
