using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (
                a * a == (b * b) + (c * c) ||
                b * b == (a * a) + (c * c) ||
                c * c == (a * a) + (b * b)
                )
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
https://quera.org/problemset/280
*/