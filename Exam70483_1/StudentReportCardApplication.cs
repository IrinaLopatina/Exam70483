using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_1
{
    class StudentReportCardApplication
    {
        internal void Run()
        {
            var numberOfStudents = ObtainNumberOfStudents();

            string[,] studentData = new string[numberOfStudents, 4];
            for (int i = 0; i < numberOfStudents; i++)
            {
                ObtainStudentData(i, studentData);
            }
            GenerateReport(studentData);
        }

        private int ObtainNumberOfStudents()
        {
            Console.Write("Enter total number of students : ");
            return int.Parse(Console.ReadLine());
        }

        private void ObtainStudentData(int i, string[,] studentData)
        {
            Console.WriteLine("*****************************************************");
            Console.Write("Enter student name : ");
            studentData[i, 0] = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter English marks (out of 100) : ");
            studentData[i, 1] = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter Math marks (out of 100) : ");
            studentData[i, 2] = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter Computer marks (out of 100) : ");
            studentData[i, 3] = Console.ReadLine();
            Console.WriteLine();
        }

        private void GenerateReport(string[,] studentData)
        {
            Console.WriteLine("******************* Report card ********************");

            var numberOfStudents = studentData.GetLength(0);
            var generatedRows = new ArrayList();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var iterationMax = 0;
                var iterationIndex = 0;
                for (int j = 0; j < numberOfStudents; j++)
                {
                    var total = int.Parse(studentData[j, 1]) + int.Parse(studentData[j, 2]) + int.Parse(studentData[j, 3]);
                    if (iterationMax < total && !generatedRows.Contains(j))
                    {
                        iterationMax = total;
                        iterationIndex = j;
                    }
                }
                generatedRows.Add(iterationIndex);

                Console.WriteLine("*****************************************************");
                Console.WriteLine(String.Format("Student Name : {0}, Position : {1}, Total : {2}/300", studentData[iterationIndex, 0], i, iterationMax));

                Console.WriteLine("*****************************************************");
            }
        }
    }
}
