using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_2
{
    class TemperatureConverter
    {
        public void Run()
        {
            var continueConvertion = true;
            do
            {
                Console.Clear();
                Console.Write("Select input temperature scale (C for Celsius, F for Fahrenheit): ");
                var inputScale = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Value to convert: ");
                var tempValue = double.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (inputScale)
                {
                    case "F":
                        var farTemp1 = new FahrenheitTemperature(tempValue);
                        CelsiusTemperature celTemp1 = farTemp1;
                        Console.WriteLine(String.Format("Converted value (in Celsius): {0}", celTemp1.value));
                        break;
                    case "C":
                        var celTemp2 = new CelsiusTemperature(tempValue);
                        FahrenheitTemperature farTemp2 = celTemp2;
                        Console.WriteLine(String.Format("Converted value (in Fahrenheit): {0}", farTemp2.value));
                        break;
                }
                continueConvertion = GetContinueFromUser();
            } while (continueConvertion);
        }

        private bool GetContinueFromUser()
        {
            Console.Write("Continue conversion (Y/N) :");
            var input = Console.ReadLine();

            return input.Equals("Y") ? true : false;
        }
    }
}
