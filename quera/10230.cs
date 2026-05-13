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
            string[] input = Console.ReadLine().Split();


            int a, b, c;
            bool ok1 = int.TryParse(input[0], out a);
            bool ok2 = int.TryParse(input[1], out b);
            bool ok3 = int.TryParse(input[2], out c);

            if (ok1 && ok2 && ok3)
            {
                if (
    (0 < a && a < 360) &&
    (0 < b && b < 360) &&
    (0 < c && c < 360) &&
    (a + b + c == 180)
   )
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

            }
            else
            {
                Console.WriteLine("NO");
            }
















            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/10230
*/