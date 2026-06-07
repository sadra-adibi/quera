using System;
using System.Text;

namespace quera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ');

            string output = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    output += names[i] + ": salam " + names[j] + "!\n";
                }
            }

            for (int i = 0; i < n; i++)
            {
                output += names[i] + ": khodafez bacheha!\n";
                for (int j = i + 1; j < n; j++)
                {
                    output += names[j] + ": khodafez " + names[i] + "!\n";
                }
            }

            Console.Write(output);



            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/31021

cheat code:

int[] input_numbers = Array.ConvertAll(Console.ReadLine().Split(),int.Parse); // get a line of numbers from console

Console.WriteLine(string.Join(" ", shokolatkor)); // write a line of numbers to console

string[] input = Console.ReadLine().Split(); // get a line if chars form console

*/