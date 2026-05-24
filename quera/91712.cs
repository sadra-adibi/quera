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

            string temp = Console.ReadLine();
            string[] b = temp.Split(' ');
            int mosh = int.Parse(b[0]);
            int sorakh = int.Parse(b[1]);
            for (int i = 0; i < 2; i++)
            {
                if (mosh == sorakh && i == 0) { Console.Write("Saal Noo Mobarak!"); break; }
                if (mosh > sorakh) { Console.Write("L"); mosh--; }
                if (mosh < sorakh) { Console.Write("R"); mosh++; }
            }
            Console.WriteLine();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/91712
*/