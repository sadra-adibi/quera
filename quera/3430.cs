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

            char[] input_to_char = input.ToCharArray();

            for (int i = 0; i < input_to_char.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    input_to_char[j] = input[i];
                }

                Console.WriteLine(new string(input_to_char));
            }




            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/3430
*/