using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace quera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int n = int.Parse(Console.ReadLine());

            string[] words = Console.ReadLine().Split(' ');

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(words[i]);

                if (i > 0)
                    Console.Write(" ");
                else
                    Console.Write("\n");
            }



            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/3408
*/