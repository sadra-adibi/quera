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

            int[] input_numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // get a line of numbers from console
            int[] shokolatkor = new int[4];
            int counter = 0;

            for (int i = 0; i < 200; i = i + 2, i = i % 4)
            {
                if (input_numbers[i] == 0)
                {
                    break;
                }
                else
                {
                    input_numbers[i]--;
                    shokolatkor[counter]++;
                    counter++;
                    counter %= 4;

                }
                if (input_numbers[i] == 0)
                {
                    break;
                }

            }
            Console.WriteLine(string.Join(" ", shokolatkor));
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/10326

cheat code:

int[] input_numbers = Array.ConvertAll(Console.ReadLine().Split(),int.Parse); // get a line of numbers from console

Console.WriteLine(string.Join(" ", shokolatkor)); // write a line of numbers to console

string[] input = Console.ReadLine().Split(); // get a line if chars form console

*/