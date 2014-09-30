using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exponents
{
    class Program
    {
        static int Cube(int num)
        {
            return num * num * num;
        }
        static int Square(int num)
        {
            return num * num;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("enter number: ");
            int num = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(Square(num) + " , " + Cube(num));
        }
    }
}
