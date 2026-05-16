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
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string a = Console.ReadLine();
            int red = 0;
            int yellow = 0;
            int green = 0;
            for (int i = 0; i < 5; i++)
            {
                if (a[i] == 'R') { red++; }
                if (a[i] == 'Y') { yellow++; }
                if (a[i] == 'G') { green++; }
            }
            if (red > 2)
            {
                Console.WriteLine("nakhor lite");
            }
            else
            {
                if (red > 1 && yellow > 1)
                {
                    Console.WriteLine("nakhor lite");
                }
                else
                {
                    if (yellow > 4)
                    {
                        Console.WriteLine("nakhor lite");
                    }
                    else
                    {
                        if (green == 0)
                        {
                            Console.WriteLine("nakhor lite");
                        }
                        else { Console.WriteLine("rahat baash"); }
                    }



                }


            }







            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/20256
*/