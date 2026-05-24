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

            string[] input = Console.ReadLine().Split();

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            int hour;
            int minute;

            if (a == 0)
            {
                hour = 0;
            }
            else
            {
                hour = 12 - a;
            }

            if (b == 0)
            {
                minute = 0;
            }
            else
            {
                minute = 60 - b;
            }

            Console.WriteLine(hour.ToString("00") + ":" + minute.ToString("00"));

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/2886
*/