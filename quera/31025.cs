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
            string[] input = Console.ReadLine().Split();

            double n = double.Parse(input[0]);
            int k = int.Parse(input[1]);

            for (int i = 0; i < k; i++)
            {
                n = Math.Floor(n / 2);
            }

            Console.WriteLine((int)n);
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/31025
*/