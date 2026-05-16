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
            bool one_shanbe = false;
            bool two_shanbe = false;
            bool othree_shanbe = false;
            bool four_shanbe = false;
            bool five_shanbe = false;
            bool six_shanbe = false;
            bool seven_shanbe = false;
            int output = 0;
            for (int i = 0; i < 3; i++)
            {
                int a = int.Parse(Console.ReadLine());
                string b = Console.ReadLine();
                string[] bb = b.Split(' ');
                for (int j = 0; j < a; j++)
                {
                    if (bb[j] == "shanbe")
                    {
                        one_shanbe = true;
                    }
                    if (bb[j] == "1shanbe")
                    {
                        two_shanbe = true;
                    }
                    if (bb[j] == "2shanbe")
                    {
                        othree_shanbe = true;
                    }
                    if (bb[j] == "3shanbe")
                    {
                        four_shanbe = true;
                    }
                    if (bb[j] == "4shanbe")
                    {
                        five_shanbe = true;
                    }
                    if (bb[j] == "5shanbe")
                    {
                        six_shanbe = true;
                    }
                    if (bb[j] == "jome")
                    {
                        seven_shanbe = true;
                    }

                }

            }

            if (!one_shanbe)
            {
                output++;
            }
            if (!two_shanbe)
            {
                output++;
            }
            if (!othree_shanbe)
            {
                output++;
            }
            if (!four_shanbe)
            {
                output++;
            }
            if (!five_shanbe)
            {
                output++;
            }
            if (!six_shanbe)
            {
                output++;
            }
            if (!seven_shanbe)
            {
                output++;
            }

            Console.WriteLine(output);









            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/3538
*/