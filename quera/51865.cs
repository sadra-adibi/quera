using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace quera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int X = int.Parse(Console.ReadLine());  // current grade
            int N = int.Parse(Console.ReadLine());  // days traveling

            int finalGrade;

            if (N == 7)
            {
                finalGrade = X;  // Exactly 7 days → same grade
            }
            else if (N == 0)
            {
                finalGrade = 20;  // Doesn't travel → 20
            }
            else
            {
                // For any other days (1-6 or 8-100)
                finalGrade = X - N;
                if (finalGrade < 0)
                {
                    finalGrade = 0;
                }
            }

            Console.WriteLine(finalGrade);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/51865
*/