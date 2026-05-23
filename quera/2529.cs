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
            int n = int.Parse(Console.ReadLine());

            int output = 0;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int different = 0;
                for (int j = 0; j < name.Length; j++)
                {
                    bool exists = false;

                    for (int k = 0; k < j; k++)
                    {
                        if (name[j] == name[k])
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (exists == false)
                    {
                        different++;
                    }
                }

                if (different > output)
                {
                    output = different;
                }
            }

            Console.WriteLine(output);
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/2529
*/