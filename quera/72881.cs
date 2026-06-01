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
            double[] input_numbers = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);// get a line of numbers from console

            if (input_numbers[1] * input_numbers[0] <= input_numbers[2])
            {
                Console.WriteLine("Kafie!");
            }
            else
            {
                Console.WriteLine("Na! yeki bayad bere sabzi bekhare");
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/72881

cheat code:

int[] input_numbers = Array.ConvertAll(Console.ReadLine().Split(),int.Parse); // get a line of numbers from console

Console.WriteLine(string.Join(" ", shokolatkor)); // write a line of numbers to console

string[] input = Console.ReadLine().Split(); // get a line if chars form console

*/