using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            if(!EventLog.SourceExists("QuoteServer"))
            {
                EventLog.CreateEventSource("QuoteServer","MyNewLog");
                Console.WriteLine("CreateSourceEventLog");
                Console.WriteLine("Exiting, execute again to write a to the log");
                Console.ReadLine();
                return;
            }

            EventLog eventLog = new EventLog();
            eventLog.Source = "QuoteServer";
            eventLog.WriteEntry("Write to event log.");
            Console.WriteLine("Writting to the " + eventLog.Source + " event log source");

            Console.ReadLine();
        }
    }
}
