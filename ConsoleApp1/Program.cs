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
            Console.WriteLine("running in the main thread, id: {0}", Thread.CurrentThread.ManagedThreadId);
            var t1 = new Thread(ThreadMain);
            t1.Start();
            Console.WriteLine("Running in the main thread, id: {0}", Thread.CurrentThread.ManagedThreadId);

            var t2 = new Thread(() => Console.WriteLine("running in a thread, id: {0}", Thread.CurrentThread.ManagedThreadId));
            t2.Start();

            Console.WriteLine("running in the main thread, id: {0}", Thread.CurrentThread.ManagedThreadId);
            Console.ReadKey();
        }

        static void ThreadMain()
        {
            Console.WriteLine("running in the ThreadMain method, id: {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
