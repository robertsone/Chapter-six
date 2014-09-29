using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter_six
{
    class Program
    {
        public static int question(string prompt)
        {
            System.Console.Write(prompt);
            int responce = Convert.ToInt32(System.Console.ReadLine());
            return responce;
        }
        public static void InchesToFeet(int inches,int feet,int yards)
        {
            if (inches >= 12)
            {
                feet += inches / 12;
                inches = inches % 12;
            }
            if (feet >= 3)
            {
                yards += feet / 3;
                feet = feet % 3;
            }
            System.Console.WriteLine(inches + " Inches " + feet + " Feet " + yards + " Yards");
        }
        static void Main(string[] args)
        {
            int inches=question("How many inches:");
            int feet = question("How many feet:");
            int yards = question("How many yards:");
            InchesToFeet(inches, feet, yards);
        }
    }
}
