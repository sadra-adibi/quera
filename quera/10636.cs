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

            string[] firstNames = new string[input];

            for (int i = 0; i < input; i++)
            {


                string[] input_s = Console.ReadLine().Split();
                firstNames[i] = input_s[0];


            }

            int maxCount = 0;

            for (int i = 0; i < input; i++)
            {

                int count = 0;
                for (int j = 0; j < input; j++)
                {


                    if (firstNames[i] == firstNames[j])
                    {

                        count++;

                    }

                }

                if (count > maxCount)
                {

                    maxCount = count;


                }
                else
                {

                }
            }

            Console.WriteLine(maxCount);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/10636

cheat code:

int[] input_numbers = Array.ConvertAll(Console.ReadLine().Split(),int.Parse); // get a line of numbers from console

Console.WriteLine(string.Join(" ", shokolatkor)); // write a line of numbers to console

string[] input = Console.ReadLine().Split(); // get a line if chars form console

*/