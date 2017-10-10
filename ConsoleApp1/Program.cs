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
            MyClass myclass = new MyClass(5);
            Console.WriteLine("myclass.Number: " + myclass.Number);
            Console.ReadLine();
        }
    }
}
