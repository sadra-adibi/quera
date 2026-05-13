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
            string[] a = new string[1000];
            int count = 0;
            for (int i = 0; i < 1000; i++)
            {
                a[i] = Console.ReadLine();
                int test = int.Parse(a[i]);
                if (test == 0)
                {
                    break;
                }
                count++;
            }

            for (int i = count - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }


















            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/3405
*/