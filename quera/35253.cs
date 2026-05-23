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

            int number_of_inputs = int.Parse(Console.ReadLine());
            int max = 0;
            int man_pointer = 0;
            string a = Console.ReadLine();
            string[] b = a.Split(' ');

            for (int i = 0; i < number_of_inputs; i++)
            {
                int temp = int.Parse(b[i]);
                if (temp > max)
                {
                    max = temp;
                    man_pointer = i;
                }

            }
            Console.WriteLine(man_pointer + 1);
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/35253
*/