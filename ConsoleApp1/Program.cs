using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Background Threads
            var t1 = new Thread(ThreadMain) { Name = "MyNewThread", IsBackground = true };
            t1.Start();

            Console.WriteLine("Main thread ending now.");
            Thread.Sleep(500);
        }

        static void ThreadMain()
        {
            Console.WriteLine("Thread {0} Started.", Thread.CurrentThread.Name);
            Thread.Sleep(3000);
            Console.WriteLine("Thread {0} Completed.", Thread.CurrentThread.Name);
        }
    }
}
