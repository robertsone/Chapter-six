using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace squares
{
    class Program
    {
        static int Square(ref int num)
        {
            num = num * num;
            return num;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("enter number: ");
            int num = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(num+","+Square(ref num) + "," + num);
        }
    }
}
