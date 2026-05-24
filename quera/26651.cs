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
            string[] a = Console.ReadLine().Split();
            string[] b = Console.ReadLine().Split();
            int sum = 0;

            for (int i = 0; i < n; i++)
            {


                int ai = int.Parse(a[i]);
                int bi = int.Parse(b[i]);
                sum += ai * bi;


            }

            Console.WriteLine(sum);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/26651
*/