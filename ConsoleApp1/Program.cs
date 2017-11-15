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
            // passing data to a thread using a struct
            var d = new Data { message = "Info" };
            var t2 = new Thread(ThreadMainPassingParameters);
            t2.Start(d);

            // Passing data to a thread using a class
            MyThread myThread = new MyThread("Info");
            var t3 = new Thread(myThread.ThreadMain);
            t3.Start();

            Console.ReadKey();
        }

        static void ThreadMainPassingParameters(object o)
        {
            Data d = (Data)o;
            Console.WriteLine("running in a thread, received {0}. Which came from a struct", d.message);
        }

        struct Data
        {
            public string message;
        }

        class MyThread
        {
            private string data;

            public MyThread(string d)
            {
                this.data = d;
            }

            public void ThreadMain()
            {
                Console.WriteLine("running in a thread, data: {0}. This is using a class", this.data);
            }

        }


    }
}
