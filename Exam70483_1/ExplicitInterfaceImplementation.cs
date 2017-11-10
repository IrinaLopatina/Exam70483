using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_1
{
    interface IConflictOne
    {
        void PrintMyString(string str);
    }
    interface IConflictTwo
    {
        void PrintMyString(string str);
    }

    class ExplicitInterfaceImplementation : IConflictOne, IConflictTwo
    {
        void IConflictOne.PrintMyString(string str) //NB: no "public" here!
        {
            Console.WriteLine("Printing string 1: " + str);
        }
        
        void IConflictTwo.PrintMyString(string str) //NB: no "public" here!
        {
            Console.WriteLine("Printing string 2: " + str);
        }

        //Class member(non-interface)
        public void PrintMyString(string str)
        {
            Console.WriteLine("Printing string 3: " + str);
        }
    }
}
