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
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            string[] input = Console.ReadLine().Split();
            long aa = long.Parse(input[0]);
            long bb = long.Parse(input[1]);


            long a = aa;
            long b = bb;


            while (b != 0)
            {


                long temp = b;
                b = a % b;
                a = temp;


            }

            long bmm = a;
            long kmm = (aa * bb) / bmm;



            Console.WriteLine(bmm + " " + kmm);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/590

cheat code:

int[] input_numbers = Array.ConvertAll(Console.ReadLine().Split(),int.Parse); // get a line of numbers from console

Console.WriteLine(string.Join(" ", shokolatkor)); // write a line of numbers to console

string[] input = Console.ReadLine().Split(); // get a line if chars form console

*/