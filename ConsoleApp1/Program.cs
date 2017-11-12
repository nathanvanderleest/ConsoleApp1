using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

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

            dl.BeginInvoke(1, 2000, TakesAWhileCompleted, dl);
            for(int i = 0; i < 100; i++)
            {
                Console.Write(".");
                Thread.Sleep(50);
            }

            Console.ReadKey();
        }

        static void TakesAWhileCompleted(IAsyncResult ar)
        {
            if (ar == null) throw new ArgumentNullException("ar");

            TakesAWhileDelegate dl = ar.AsyncState as TakesAWhileDelegate;
            Trace.Assert(dl != null, "Invaild object type");

            int result = dl.EndInvoke(ar);
            Console.WriteLine("result: {0}", result);
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
