using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_5
{
    class StudentEventArgs : EventArgs
    {
        public string Message { get; set; }
    }

    class StudentCard
    {
        private string studentName;
        private int computerScienceMark;
        private int mathMark;
        private int englishMark;

        public event EventHandler Alert;

        public StudentCard()
        {
            studentName = string.Empty;
            computerScienceMark = 0;
            mathMark = 0;
            englishMark = 0;
    }

        public StudentCard(string name)
        {
            studentName = name;
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public int ComputerScienceMark
        {
            get { return computerScienceMark; }
            set
            {
                computerScienceMark = value;
                CheckExamsPassed();
            }
        }

        public int MathMark
        {
            get { return mathMark; }
            set
            {
                mathMark = value;
                CheckExamsPassed();
            }
        }

        public int EnglishMark
        {
            get { return englishMark; }
            set
            {
                englishMark = value;
                CheckExamsPassed();
            }
        }

        //Create the OnPropertyChanged method to raise the  event
        protected void CheckExamsPassed()
        {
            int total = ComputerScienceMark + MathMark + EnglishMark;

            string message = total > 75 ? string.Format("Congratulations, {0}! Exams are passed with score {1}/150", StudentName, total) :
                                          string.Format("It's a pity, {0}! Exams are not passed (F). Your score is {1}/150", StudentName, total);

            var eventArgs = new StudentEventArgs
                            { Message = message };

            Alert?.Invoke(this, eventArgs);
        }
    }
}
