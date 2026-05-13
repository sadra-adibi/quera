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
            string a = Console.ReadLine();
            string[] b = a.Split(' ');

            int[] g = { 1, 1, 2, 2, 2, 8 };

            for (int i = 0; i < 6; i++)
            {
                int s = int.Parse(b[i]);

                int temp = g[i] - s;
                if (i < 5)
                {
                    Console.Write(temp + " ");
                }
                else
                {
                    Console.WriteLine(temp);
                }

            }



            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/2636
*/