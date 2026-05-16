using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
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
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 7:
                    Console.WriteLine("sara");
                    goto case 6;

                case 6:
                    Console.WriteLine("sarah");
                    goto case 5;

                case 5:
                    Console.WriteLine("stella");
                    goto case 4;

                case 4:
                    Console.WriteLine("sophia");
                    goto case 3;

                case 3:
                    Console.WriteLine("sadie");
                    goto case 2;

                case 2:
                    Console.WriteLine("scarlett");
                    goto default;

                default:
                    Console.WriteLine("sofia");
                    break;
            }


















            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/28947
*/