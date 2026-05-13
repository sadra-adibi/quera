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


            if (b[0] == b[2])
            {
                Console.WriteLine("Vertical");
            }
            else
            {

                if (b[1] == b[3])
                {
                    Console.WriteLine("Horizontal");
                }
                else
                {
                    Console.WriteLine("Try again");
                }


            }



















            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/3414
*/