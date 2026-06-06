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



            string[] firstLine = Console.ReadLine().Split(' ');
            int number_of_input = int.Parse(firstLine[0]);
            string t = firstLine[1];

            // hashser = > save the input if and only if it not been saved before
            HashSet<char> good_code = new HashSet<char>(t);

            for (int i = 0; i < number_of_input; i++)
            {

                string s = Console.ReadLine();
                HashSet<char> test_code = new HashSet<char>(s);


                if (good_code.SetEquals(test_code))
                {

                    Console.WriteLine("Yes");

                }
                else
                {

                    Console.WriteLine("No");

                }

            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/10327

cheat code:

int[] input_numbers = Array.ConvertAll(Console.ReadLine().Split(),int.Parse); // get a line of numbers from console

Console.WriteLine(string.Join(" ", shokolatkor)); // write a line of numbers to console

string[] input = Console.ReadLine().Split(); // get a line if chars form console

*/