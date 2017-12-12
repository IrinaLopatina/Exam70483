using System;

namespace Exam70483_7
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebRequester req = new WebRequester())
            {
            }
            Console.WriteLine("The end");
        }
    }
}
