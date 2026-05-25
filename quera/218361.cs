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

            int counter = 0;
            for (int i = 0; i < input_numbers_line_one.Length; i++)
            {
                if (input_numbers_line_one[i] == input_numbers_line_two[i] && input_numbers_line_one[i] == 1)
                {
                    counter++;
                }
            }


            Console.WriteLine(counter);
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/218361

cheat code:

int[] input_numbers = Array.ConvertAll(Console.ReadLine().Split(),int.Parse); // get a line of numbers from console

Console.WriteLine(string.Join(" ", shokolatkor)); // write a line of numbers to console

string[] input = Console.ReadLine().Split(); // get a line if chars form console

*/