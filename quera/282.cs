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

            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    sum += i;
                }

            }
            if (sum == a) { Console.WriteLine("YES"); }
            else
            {
                Console.WriteLine("NO");
            }


















            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/282
*/