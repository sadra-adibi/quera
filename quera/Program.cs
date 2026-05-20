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
            int weight = int.Parse(Console.ReadLine());

            float height = float.Parse(Console.ReadLine());

            float BMI = weight / (height * height);

            Console.WriteLine($"{BMI:F2}");
            if (BMI < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (BMI < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (BMI < 30)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obese");
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/3404
*/