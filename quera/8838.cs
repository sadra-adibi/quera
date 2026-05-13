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
            int c = int.Parse(b[0]);
            for (int i = 0; i < c; i++)
            {
                Console.Write("copy of ");
            }
            Console.WriteLine(b[1]);



            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/8838
*/