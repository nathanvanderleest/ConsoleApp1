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
            TestMethod(3, 9);
            TestMethod(notOptionalNumber: 9);
            System.Console.ReadLine();
        }

        #region Documentation
        /// <summary>
        /// Optional Arguments
        /// </summary>
        #endregion
        public static void TestMethod(int notOptionalNumber, int optionalNumber = 10)
        {
            System.Console.WriteLine("Optional Number: " + optionalNumber + ", Not Optional Number: " + notOptionalNumber);
        }

    }
}
