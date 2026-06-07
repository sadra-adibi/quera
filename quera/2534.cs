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

            int input = int.Parse(Console.ReadLine());

            int[] heights = new int[input];
            long sum = 0;

            for (int i = 0; i < input; i++)
            {
                heights[i] = int.Parse(Console.ReadLine());
                sum += heights[i];
            }

            long average = sum / input;
            long mov = 0;

            for (int i = 0; i < input; i++)
            {
                if (heights[i] > average)
                {
                    mov += heights[i] - average;
                }
            }

            Console.WriteLine(mov);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/2534

cheat code:

int[] input_numbers = Array.ConvertAll(Console.ReadLine().Split(),int.Parse); // get a line of numbers from console

Console.WriteLine(string.Join(" ", shokolatkor)); // write a line of numbers to console

string[] input = Console.ReadLine().Split(); // get a line if chars form console

*/