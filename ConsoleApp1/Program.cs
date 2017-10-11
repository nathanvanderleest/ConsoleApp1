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
        }
    }
}


struct Dimensions
{
    public double Length;
    public double Width;

    public Dimensions(double length, double width)
    {
        Length = length;
        Width = width;
    }

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
