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

            int max_team = 0;
            for (int i = 0; i < 3; i++)
            {
                int laptop = int.Parse(Console.ReadLine());
                int pc = int.Parse(Console.ReadLine());
                if (laptop > pc)
                {
                    max_team += pc;
                }
                else
                {
                    max_team += laptop;
                }
            }
            Console.WriteLine(max_team);
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/80651
*/