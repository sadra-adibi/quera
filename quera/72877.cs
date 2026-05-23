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
            ///
            string a = Console.ReadLine();
            string[] input = a.Split(' ');

            int ngosfand = int.Parse(input[0]);
            double pashm = double.Parse(input[1]);
            double price = double.Parse(input[2]);
            double totalPrice = pashm * price * ngosfand;
            Console.WriteLine(totalPrice);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/72877
*/