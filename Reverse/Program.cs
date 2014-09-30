using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse
{
    class Program
    {
        static void reverse(ref int num1,ref int num2,ref int num3,ref int num4)
        {
            int temp = num4;
            num4 = num1;
            num1 = temp;
            temp = num2;
            num2 = num3;
            num3 = temp;
        }
        static void Main(string[] args)
        {
            System.Console.WriteLine("Write num 1"); int num1 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Write num 2"); int num2 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Write num 3"); int num3 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("Write num 4"); int num4 = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(num1 + " " + num2 + " " + num3 + " " + num4);
            reverse(ref num1,ref num2,ref num3,ref num4);
            System.Console.WriteLine(num1 + " " + num2 + " " + num3 + " " + num4);
        }
    }
}
