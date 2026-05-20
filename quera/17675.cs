using System;

public class Class1
{
	public Class1()
	{
	}
}
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
            int input_number = int.Parse(Console.ReadLine());
            int small_fibo = 1;
            int large_fibo = 2;

            for (int i = 1; i <= input_number; i++)
            {
                if (i == small_fibo)
                {
                    Console.Write("+");
                    int temp = small_fibo;
                    small_fibo = large_fibo;
                    large_fibo = small_fibo + temp;
                }
                else
                {
                    Console.Write("-");
                }
            }

            Console.Write("\n");



            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/17675
*/