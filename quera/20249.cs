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

            int number_couunter = input_numbers_line_one[0];
            int andaze_shishe = input_numbers_line_one[1];
            int sum = 0;

            for (int i = 0; i < input_numbers_line_two.Length; i++)
            {
                sum += input_numbers_line_two[i];
            }

            int needed_shishe = sum / andaze_shishe;
            if (sum % andaze_shishe != 0)
            {
                needed_shishe++;
            }
            int shishe_por = number_couunter - needed_shishe;
            Console.WriteLine(shishe_por);


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/20249

cheat code:

int[] input_numbers = Array.ConvertAll(Console.ReadLine().Split(),int.Parse); // get a line of numbers from console

Console.WriteLine(string.Join(" ", shokolatkor)); // write a line of numbers to console

string[] input = Console.ReadLine().Split(); // get a line if chars form console

*/