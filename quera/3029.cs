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

            string[] first = Console.ReadLine().Split();
            string[] second = Console.ReadLine().Split();

            int x = int.Parse(first[0]);
            int y = int.Parse(first[1]);

            int x1 = int.Parse(second[0]);
            int y1 = int.Parse(second[1]);

            int sa = x1 - x;

            if (sa > 0)
            {
                Console.WriteLine("Right");
            }
            else
            {
                Console.WriteLine("Left");
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/3029
*/