using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentReportCardApplication = new StudentReportCardApplication();
            studentReportCardApplication.Run();

            /* Calculator
            var calculator = new Calculator();
            calculator.Run();
            */

            /* Jagger array
            string[][] friends = new string[3][]{ new string[]{ "A1", "B1", "C1" }, 
                                                  new string []{ "A2", "B2", "C2", "D2" },
                                                  new string []{ "A3", "B3", "C3", "D3", "E3" }};

            for (int i = 0; i < friends.Length; i++)
            {
                for (int j = 0; j < friends[i].Length; j++)
                    Console.Write(friends[i][j]);
                Console.WriteLine();
            }
            */
        }
    }
}
