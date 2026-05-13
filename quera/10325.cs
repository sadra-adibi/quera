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
            int b1 = int.Parse(b[0]);
            int b2 = int.Parse(b[1]);
            int b3 = 0;
            if (b2 > 10)
            {
                Console.Write("Left ");
                b3 = b2 - 9;
            }
            else
            {
                Console.Write("Right ");
                b3 = b2;
            }

            Console.Write(11 - b1 + " ");
            Console.WriteLine(b3);










            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/10325
*/