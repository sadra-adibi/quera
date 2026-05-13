using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int temp = int.Parse(Console.ReadLine());


            if (temp < 0)
            { Console.WriteLine("Ice"); }
            else
            {


                if (temp > 100)
                { Console.WriteLine("Steam"); }
                else { Console.WriteLine("Water"); }
            }









            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/3429
*/