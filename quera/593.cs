using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
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

            int temp = input;

            int counter = 0;
            bool fag = false;
            int output = 0;

            while (temp > 0)
            {
                counter += temp % 10;
                temp /= 10;
            }

            for (output = input + 1; output < 1119910; output++)
            {
                fag = true;

                for (int j = output - 1; j > 1; j--)
                {
                    if (output % j == 0)
                    {
                        fag = false;
                        break;
                    }
                }

                if (fag)
                {
                    counter--;

                    if (counter == 0)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(output);
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/593
*/