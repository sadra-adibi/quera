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

            int[] input_numbers_line_one = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // get a line of numbers from console
            int[] input_numbers_line_two = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // get a line of numbers from console

            bool it_fits = true;

            if (input_numbers_line_one[0] < input_numbers_line_two[0] || input_numbers_line_one[1] < input_numbers_line_two[1])
            {
                it_fits = false;
            }

            if (it_fits)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/3107

cheat code:

int[] input_numbers = Array.ConvertAll(Console.ReadLine().Split(),int.Parse); // get a line of numbers from console

Console.WriteLine(string.Join(" ", shokolatkor)); // write a line of numbers to console

string[] input = Console.ReadLine().Split(); // get a line if chars form console

*/