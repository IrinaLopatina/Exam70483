using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyService.WebService1SoapClient proxy = new MyService.WebService1SoapClient();

            int addResult = proxy.Add(5, 19);
            int subtractResult = proxy.Subtract(22, 12);

            Console.WriteLine("Addition result is: {0}", addResult);
            Console.WriteLine("Subtraction result is: {0}", subtractResult);
        }
    }
}
