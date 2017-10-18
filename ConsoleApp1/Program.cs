using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initialize MyClass instance with constructor...");
            Console.WriteLine("MyClass myclass = new MyClass(5)...");
            MyClass myclass = new MyClass(5);
            Console.WriteLine("myclass.Number: " + myclass.Number);
            Console.WriteLine("ChangeNumber...");
            ChangeNumber(myclass.Number);
            Console.WriteLine("myclass.Number: " + myclass.Number);
            Console.ReadLine();

            Console.WriteLine("Static test...");
            StaticClass.sNumber = 89;
            Console.WriteLine("StaticNumber.sNumber: " + StaticClass.sNumber);
            Console.WriteLine("ChangeNumber...");
            ChangeNumber(StaticClass.sNumber);
            Console.WriteLine("StaticNumber.sNumber: " + StaticClass.sNumber);
            Console.ReadLine();

            Console.WriteLine("MyClass second = new MyClass(4)...");
            MyClass second = new MyClass(4);
            Console.WriteLine("ChangeNumberWithRef(ref myclass.ChangeNumberWithRef(second)...");
            Console.WriteLine(myclass.ChangeNumberWithRef(ref second));
            Console.WriteLine("myclass.ToString() " + myclass.ToString());

            Console.ReadLine();



        }

        public static int ChangeNumber(int x)
        {
            x = x + 1;
            return x;
        }

        static class StaticClass
        {
            public static int sNumber { get; set; } 

            public static string sString { get; set; }

        }




    }
}
