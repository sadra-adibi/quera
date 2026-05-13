using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int aa = 0;
            int bb = 0;
            int aaa = a;
            int bbb = b;

            for (int i = 0; i < 3; i++)
            {
                aa = (aa * 10) + (a % 10);
                a = a / 10;
                bb = (bb * 10) + (b % 10);
                b = b / 10;

            }

            if (aa > bb)
            {
                Console.WriteLine(bbb + " < " + aaa);
            }
            else
            {
                if (bb > aa)
                {
                    Console.WriteLine(aaa + " < " + bbb);
                }
                else
                { Console.WriteLine(bbb + " = " + aaa); }

            }




















            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/3406
*/