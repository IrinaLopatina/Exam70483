using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolDB db = new SchoolDB();
            var students = db.Student.ToList();

            students.ForEach(s => Console.WriteLine("Id is: {0}, Name is: {1}", s.StudentId, s.StudentName));

            Student st = new Student
            {
                StudentId = 5,
                StudentName = "Karsten Vileid"
            };

            db.Student.Add(st);
            db.SaveChanges();
            Console.WriteLine("Student Added");
        }
    }
}
