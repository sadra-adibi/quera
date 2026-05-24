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

            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            int current = 1;

            int count = 0;

            do
            {
                current = current + k;

                while (current > n)
                {
                    current -= n;
                }

                count++;

            } while (current != 1);

            Console.WriteLine(count);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/34081
*/