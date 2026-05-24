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

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {

                string line = Console.ReadLine();
                string[] words = line.Split(' ');

                for (int j = 0; j < words.Length; j++)
                {




                    string first =
                        words[j][0].ToString().ToUpper();

                    string rest = "";

                    for (int k = 1; k < words[j].Length; k++)
                    {
                        rest += char.ToLower(words[j][k]);
                    }

                    words[j] = first + rest;




                }

                Console.WriteLine(string.Join(" ", words));

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/655
*/