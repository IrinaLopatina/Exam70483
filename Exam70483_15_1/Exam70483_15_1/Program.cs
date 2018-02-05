using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Exam70483_15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceName = "Exam70483_15_1";
            string logName = "Application";
            string machineName = "."; // . means local mashine
            if (!EventLog.SourceExists(sourceName, machineName))
            {
                EventLog.CreateEventSource(sourceName, logName);
            }

            //Creating log
            EventLog log = new EventLog
            {
                Source = sourceName,
                Log = logName,
                MachineName = machineName
            };

            //Specify the EventLog trace listener
            EventLogTraceListener eventLogListener = new EventLogTraceListener
            {
                //Specify the target to listener
                EventLog = log
            };

            TraceSource trace = new TraceSource("Exam70483_15_1 trace", SourceLevels.All);//??
            trace.Listeners.Clear();
            trace.Listeners.Add(eventLogListener);

            try
            {
                trace.TraceEvent(TraceEventType.Start, 0, "Tracing start to Event Log");
                int num1 = 10;
                int num2 = 0;

                if (num1.GetType() == typeof(int) && num2.GetType() == typeof(int))
                {
                    trace.TraceEvent(TraceEventType.Information, 1, "Numbers are valid");
                    //trace.TraceInformation("Numbers are valid");
                }

                //if (num2 < 1)
                //{
                //    num2 = num1;
                //    trace.TraceInformation("num2 has been changed due to 0 value");
                //}

                int result = num1 / num2;
              
            }
            catch (Exception ex)
            {
                trace.TraceEvent(TraceEventType.Critical, 2, ex.Message);
            }
            finally
            {
                trace.TraceEvent(TraceEventType.Stop, 3, "Tracing stop to Event Log");
                trace.Flush();
                trace.Close();
            }
        }
    }
}
