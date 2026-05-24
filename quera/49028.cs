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
            int input = int.Parse(Console.ReadLine());
            int pervise_number = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 1; i < input; i++)
            {
                int next_number = int.Parse(Console.ReadLine());
                if (pervise_number != next_number)
                {
                    count++;
                }
                pervise_number = next_number;
            }
            Console.WriteLine(count);
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/49028
*/