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

            string[] dimensions = Console.ReadLine().Split(' ');
            int n = int.Parse(dimensions[0]);
            int m = int.Parse(dimensions[1]);

            int[,] table = new int[n, m];

            for (int i = 0; i < n; i++)
            {


                string[] row = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {

                    table[i, j] = int.Parse(row[j]);

                }

            }

            int count = 0;


            for (int i = 1; i < n - 1; i++)
            {

                for (int j = 1; j < m - 1; j++)
                {

                    int current = table[i, j];
                    int left = table[i, j - 1];
                    int right = table[i, j + 1];
                    int up = table[i - 1, j];
                    int down = table[i + 1, j];



                    bool case1 = (current > left && current > right) &&
                                (current < up && current < down);

                    bool case2 = (current < left && current < right) &&
                                (current > up && current > down);




                    if (case1 || case2)
                    {

                        count++;

                    }
                }
            }

            Console.WriteLine(count);

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/33023

cheat code:

int[] input_numbers = Array.ConvertAll(Console.ReadLine().Split(),int.Parse); // get a line of numbers from console

Console.WriteLine(string.Join(" ", shokolatkor)); // write a line of numbers to console

string[] input = Console.ReadLine().Split(); // get a line if chars form console

*/