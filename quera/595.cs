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
            int input = int.Parse(Console.ReadLine());



            int[,] matris_2D = new int[input, input];
            for (int i = 0; i < input; i++)
            {
                matris_2D[i, 0] = 1;
                matris_2D[i, i] = 1;



                for (int j = 1; j < i; j++)
                {
                    matris_2D[i, j] = matris_2D[i - 1, j - 1] + matris_2D[i - 1, j];
                }



            }

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j <= i; j++)
                {



                    Console.Write(matris_2D[i, j]);

                    if (j != i)
                    {
                        // tahe khat nazar 
                        Console.Write(" ");
                    }



                }

                Console.WriteLine();

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/595
*/