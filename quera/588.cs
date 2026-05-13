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
            string t = Console.ReadLine();
            string[] b = t.Split(' ');

            int max = 0;
            int temp = 0;
            for (int i = 0; i < a; i++)
            {
                temp = int.Parse(b[i]);
                if (temp > max)
                {
                    max = temp;
                }
            }

            Console.WriteLine(max);



            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/588
*/