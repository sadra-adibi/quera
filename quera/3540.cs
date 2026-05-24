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

            string temp = Console.ReadLine();
            string[] b = temp.Split(' ');
            int fasele = int.Parse(b[0]);
            int tol = int.Parse(b[1]);
            int count_tol = 0;
            int arz = int.Parse(b[2]);
            int count_arz = 0;
            bool flag = false;
            for (int i = 0; i < tol; i++)
            {
                if (fasele % tol == 0)
                {
                    count_tol = fasele / tol;
                    flag = true;
                    break;
                }
                else
                {
                    if (fasele > arz)
                    {
                        count_arz++;
                        fasele -= arz;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine(count_tol + " " + count_arz);
            }
            else { Console.WriteLine("-1"); }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/3540
*/