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

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            string result = "";

            for (int i = a + 1; i < b; i++)
            {
                bool isPrime = true;

                if (i < 2)
                {
                    isPrime = false;
                }

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    result += i + ",";
                }
            }

            if (result.Length > 0)
            {
                result = result.TrimEnd(',');
            }

            Console.WriteLine(result);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/649
*/