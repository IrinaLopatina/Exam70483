using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_5
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentCard card1 = new StudentCard();
            card1.Alert += Card_Alert;
            card1.StudentName = "Peter";
            card1.ComputerScienceMark = 10;
            card1.MathMark = 20;
            card1.EnglishMark = 30;

            StudentCard card2 = new StudentCard();
            card2.Alert += Card_Alert;
            card2.StudentName = "Olga";
            card2.ComputerScienceMark = 15;
            card2.MathMark = 25;
            card2.EnglishMark = 35;

            card1.MathMark = 50;
            card2.ComputerScienceMark = 35;
        }

        private static void Card_Alert(object sender, EventArgs e)
        {
            StudentEventArgs ev = (StudentEventArgs)e;
            Console.WriteLine("Card_Alert : {0}", ev.Message);
        }
    }
}
