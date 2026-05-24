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

            string temp = Console.ReadLine();
            string[] input = temp.Split(' ');
            int botri = int.Parse(input[0]);
            int maye = int.Parse(input[1]);
            int hagm = 0;

            for (int i = 0; i < botri; i++)
            {
                hagm += int.Parse(Console.ReadLine());

            }
            if (hagm >= maye)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/49535
*/