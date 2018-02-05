using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Exam70483_15_2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!PerformanceCounterCategory.Exists("Exam40783_15_2_Counters"))
            {
                CounterCreationDataCollection counters = new CounterCreationDataCollection();

                CounterCreationData inputCounterData = new CounterCreationData
                {
                    CounterName = "InputDone",
                    CounterHelp = "Total number of inputs",
                    CounterType = PerformanceCounterType.NumberOfItems32
                };
                counters.Add(inputCounterData);

                CounterCreationData outputCounterData = new CounterCreationData
                {
                    CounterName = "OutputDone",
                    CounterHelp = "Total number of outputs",
                    CounterType = PerformanceCounterType.NumberOfItems32
                };
                counters.Add(outputCounterData);

                //Create new category with the counters above

                PerformanceCounterCategory.Create("Exam40783_15_2_Counters", "Test perfrmance counters for Exam70483_15_2", PerformanceCounterCategoryType.SingleInstance, counters);
                Console.WriteLine("Performance counters created!!!!!!!");
            }
            else
                Console.WriteLine("Performance counters already created");


            PerformanceCounter inputCounter = new PerformanceCounter();
            inputCounter.CategoryName = "Exam40783_15_2_Counters";
            inputCounter.CounterName = "InputDone";
            inputCounter.MachineName = ".";
            inputCounter.ReadOnly = false;

            PerformanceCounter outputCounter = new PerformanceCounter();
            outputCounter.CategoryName = "Exam40783_15_2_Counters";
            outputCounter.CounterName = "OutputDone";
            outputCounter.MachineName = ".";
            outputCounter.ReadOnly = false;

            int incrementValue = 100;
            bool process = true;
            while (process)
            {
                Console.WriteLine("0 - for input");
                Console.WriteLine("1 - for output");
                Console.WriteLine("2 - for exit");

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    switch (result)
                    {
                        case 0:
                            {
                                inputCounter.IncrementBy(incrementValue);
                                Console.WriteLine("Incremented!");
                                break;
                            }
                        case 1:
                            {
                                outputCounter.Increment();
                                Console.WriteLine("InputCounterValue: " + inputCounter.RawValue);
                                Console.WriteLine("OutputCounterValue: " + outputCounter.RawValue);
                                break;
                            }
                        case 2:
                            {
                                process = false;
                                Console.WriteLine("Exiting......");
                                break;
                            }
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input, try again");
                }
            }
        }
    }
}
