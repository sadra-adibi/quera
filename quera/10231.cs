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

            bool flag = false;
            string output = "";

            for (int i = 1; i <= 5; i++)
            {
                string s = Console.ReadLine();

                if (s.Contains("MOLANA") || s.Contains("HAFEZ"))
                {
                    output += i + " ";
                    flag = true;
                }
            }

            if (flag)
            {
                Console.WriteLine(output.Trim());
            }
            else
            {
                Console.WriteLine("NOT FOUND!");
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/10231
*/