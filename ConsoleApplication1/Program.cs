using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void letters (string letter1,string letter2,string letter3)
        {
            System.Console.WriteLine("** " + letter1 + ". " + letter2 + ". " + letter3 + ". **");
        }
        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.Write("First letter: "); string L1 = System.Console.ReadLine();
                System.Console.Write("Second letter: "); string L2 = System.Console.ReadLine();
                System.Console.Write("Last letter: "); string L3 = System.Console.ReadLine();
                letters(L1, L2, L3);
            }
        }
    }
}
