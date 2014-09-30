using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace area
{
    class Program
    {
        static void area(int L,int W)
        {
            System.Console.WriteLine(L * W);
        }
        static void area(int L,double W)
        {
            System.Console.WriteLine(L * W);
        }
        static void area(double L, double W)
        {
            System.Console.WriteLine(L * W);
        }
        static void Main(string[] args)
        {
            System.Console.Write("What is the length:");
            double L = Convert.ToDouble(System.Console.ReadLine());
            System.Console.Write("What is the width:");
            double W = Convert.ToDouble(System.Console.ReadLine());

            if (L % 1 == 0 && W % 1 == 0)
            {
                int l = Convert.ToInt32(L);
                int w = Convert.ToInt32(W);
                area(l, w);
            }
            else if (L % 1 == 0 && W % 1 != 0)
            {
                int l = Convert.ToInt32(L);
                area(l, W);
            }
            else if (L % 1 != 0 && W % 1 == 0)
            {
                int w = Convert.ToInt32(W);
                area(w, L);
            }
            else
            {
                area(L, W);
            }
        }
    }
}
