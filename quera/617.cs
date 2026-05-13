using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace quera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            long a = long.Parse(Console.ReadLine());
            long b = a;
            long c = 0;
            while (b > 0)
            {
                c = (c * 10) + (b % 10);
                b /= 10;

            }
            if (c == a)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }













            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/617
*/