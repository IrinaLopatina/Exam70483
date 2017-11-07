using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_1
{
    class Calculator
    {
        /*
         * B: no exceptions and validation implemented yet
         */

        internal void Run()
        {
            var continueCalculation = true;
            do
            {
                Console.Clear();
                DisplayOperatorInstructions();
                var operation = CollectUserInput();

                DisplayValueInstructions(1);
                var value1 = CollectUserInput();

                DisplayValueInstructions(2);
                var value2 = CollectUserInput();

                var result = Calculate(operation, value1, value2);
                DisplayCalculationResult(operation, value1, value2, result);

                DisplayContinueCalculationInstructions();
                continueCalculation = CollectContinueUserInput();
            } while (continueCalculation);
        }


        private void DisplayOperatorInstructions()
        {
            Console.WriteLine("Press any following key to perform an arithmetic operation");
            Console.WriteLine();
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine();
        }

        private void DisplayValueInstructions(int i)
        {
            Console.WriteLine(String.Format("Enter value {0}", i));
        }

        private void DisplayContinueCalculationInstructions()
        {
            Console.WriteLine("Do you want to continue again Y/N?");
        }

        private int CollectUserInput()
        {
            var inputValue = Console.ReadLine();
            return int.Parse(inputValue);
        }

        private bool CollectContinueUserInput()
        {
            var inputValue = Console.ReadLine();

            return char.Parse(inputValue) == 'Y' ? true : false;
        }


        private void DisplayCalculationResult(int operation, int value1, int value2, int result)
        {
            char operationSymbol = '@';
            switch (operation)
            {
                case 1:
                    operationSymbol = '+';
                    break;
                case 2:
                    operationSymbol = '-';
                    break;
                case 3:
                    operationSymbol = '*';
                    break;
                case 4:
                    operationSymbol = '/';
                    break;
            }

            Console.WriteLine();
            Console.WriteLine(String.Format("Result: {0} {1} {2} = {3}", value1, operationSymbol, value2, result));
            Console.WriteLine();
        }

        private int Calculate(int operation, int value1, int value2)
        {
            int result = -100000;
            switch (operation)
            {
                case 1:
                    result = value1 + value2;
                    break;
                case 2:
                    result = value1 - value2;
                    break;
                case 3:
                    result = value1 * value2;
                    break;
                case 4:
                    result = value1 / value2;
                    break;
                default:
                    break;
            }
            return result;
        }

        
    }
}
