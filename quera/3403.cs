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
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            double sum = a + b + c + d;

            double average = sum / 4;

            double product = a * b * c * d;

            double max = Math.Max(Math.Max(a, b), Math.Max(c, d));

            double min = Math.Min(Math.Min(a, b), Math.Min(c, d));

            Console.WriteLine($"Sum : {sum:F6}");

            Console.WriteLine($"Average : {average:F6}");

            Console.WriteLine($"Product : {product:F6}");

            Console.WriteLine($"MAX : {max:F6}");

            Console.WriteLine($"MIN : {min:F6}");


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/3403
*/