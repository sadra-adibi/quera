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
            int wheel_number = int.Parse(Console.ReadLine()); // get a number from console
            string input_numbers_line_one = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i < wheel_number; i++)
            {
                string input_numbers_line_two = Console.ReadLine();
                for (int j = 0; j < input_numbers_line_two.Length; j++)
                {
                    if (input_numbers_line_two[j] == input_numbers_line_one[i])
                    {
                        if (j > (input_numbers_line_two.Length / 2)) { counter += (input_numbers_line_two.Length - j); }
                        else { counter += j; }
                        break;
                    }


                }



            }

            Console.WriteLine(counter);


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/17902

cheat code:

int[] input_numbers = Array.ConvertAll(Console.ReadLine().Split(),int.Parse); // get a line of numbers from console

Console.WriteLine(string.Join(" ", shokolatkor)); // write a line of numbers to console

string[] input = Console.ReadLine().Split(); // get a line if chars form console

*/