using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        public delegate int TakesAWhileDelegate(int data, int ms);

        static void Main(string[] args)
        {
            // Synchronous method call
            // TakesAWhile(1, 3000);

            // asynchronous by using a delegate
            TakesAWhileDelegate dl = TakesAWhile;

            IAsyncResult ar = dl.BeginInvoke(1, 3000, null, null);
            while(true)
            {
                Console.Write(".");
                if(ar.AsyncWaitHandle.WaitOne(50, false))
                {
                    Console.WriteLine("Can get the result now");
                    break;
                }
            }
            int result = dl.EndInvoke(ar);
            Console.WriteLine("result: {0}", result);

            Console.ReadKey();
        }

        static int TakesAWhile(int data, int ms)
        {
            Console.WriteLine("TakesAWhile started");
            Thread.Sleep(ms);
            Console.WriteLine("TakesAWhile completed");
            return ++data;
        }
    }
}
