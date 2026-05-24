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

            string input = Console.ReadLine();

            int output = 1;

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    output = output * 2;
                }
            }



            Console.WriteLine(output);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/108665
*/