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
            // Instead of allocating memory on the heap,
            // the new operator simply calls the appropriate constructor,
            // according to the parameters passed to it, initializing all fields.
            Dimensions point = new Dimensions(3.7, 5.2);

            // It is perfectly aceptible to write: (for a struct, not class)
            //Dimensions point;
            //point.Length = 3.7;
            //point.Width = 5.2;


            Console.WriteLine("Length = " + point.Length);
            Console.WriteLine("Width = " + point.Width);

            Console.WriteLine("Diagonal = " + point.Diagonal);
            Console.ReadLine();
        }
    }
}


struct Dimensions
{
    public double Length;
    public double Width;

    /// <summary>
    /// Not sure how to use this constructor
    /// </summary>
    /// <param name="length"></param>
    /// <param name="width"></param>
    public Dimensions(double length, double width)
    {
        Length = length;
        Width = width;
    }

    /// <summary>
    /// Distance Formula
    /// </summary>
    public double Diagonal
    {
        get
        {
            return Math.Sqrt(Length*Length + Width*Width);
        }
    }
}



/// <summary>
/// Classes are more resource heavy than structs
/// </summary>
//class Dimensions
//{
//    public double Length;
//    public double Width;
//}
