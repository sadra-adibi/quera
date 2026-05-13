using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int a = int.Parse(Console.ReadLine());
            int temp = 0;

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= a; j++)
                {
                    temp = i * j;



                    Console.Write(temp);
                    if (j == a) { Console.Write("\n"); } else { Console.Write(" "); }
                }

            }
















            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/3409
*/