using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
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
            int counter = 0;
            int sum = 0;
            for (int i = input; i != 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        sum = sum + j;
                    }
                }
            }
            Console.WriteLine(counter + " " + sum);
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/33045
*/