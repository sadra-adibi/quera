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
            n = n * 2 + 1;
            int middle = n / 2;

            for (int i = 0; i < n; i++)
            {
                int stars;
                int spaces;

                if (i <= middle)
                {
                    stars = 1 + (i * 2);
                }
                else
                {
                    stars = 1 + ((n - 1 - i) * 2);
                }

                spaces = (n - stars) / 2;

                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }

                //for (int j = 0; j < stars; j++)
                //{
                //    Console.Write("*");
                //}

                //for (int j = 0; j < n - stars; j++)
                //{
                //    Console.Write(" ");
                //}

                for (int j = 0; j < stars; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/618
*/