using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
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
            int t = int.Parse(Console.ReadLine());
            string a = Console.ReadLine();

            string aa = Console.ReadLine();

            int f = 0;
            for (int i = 0; i < t; i++)
            {
                if (a[i] != aa[i])
                {
                    f++;
                }


            }
            Console.WriteLine(f);













            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/2659
*/