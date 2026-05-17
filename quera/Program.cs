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
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string a = Console.ReadLine();
            Console.WriteLine(a);
            char[] aa = a.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    aa[j] = aa[j + 1];

                }
                Console.WriteLine(aa);
            }


            




            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/72874
*/