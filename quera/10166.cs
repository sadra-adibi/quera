using System;

namespace quera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int n = int.Parse(Console.ReadLine());
            string answers = Console.ReadLine();

            int[] keyvoon = { 3, 3, 1, 1, 2, 2 };
            int[] nezam = { 1, 2, 3 };
            int[] shir = { 2, 1, 2, 3 };

            int keyvoonScor = 0;
            int nezamScor = 0;
            int shirScor = 0;
            int maxScor = 0;

            for (int i = 0; i < n; i++)
            {
                int correct = answers[i] - '0';

                if (correct == keyvoon[i % 6])
                    keyvoonScor++;

                if (correct == nezam[i % 3])
                    nezamScor++;

                if (correct == shir[i % 4])
                    shirScor++;
            }

            if (keyvoonScor > maxScor)
                maxScor = keyvoonScor;

            if (nezamScor > maxScor)
                maxScor = nezamScor;

            if (shirScor > maxScor)
                maxScor = shirScor;

            Console.WriteLine(maxScor);

            if (keyvoonScor == maxScor)
                Console.WriteLine("keyvoon");

            if (nezamScor == maxScor)
                Console.WriteLine("nezam");

            if (shirScor == maxScor)
                Console.WriteLine("shir farhad");

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
/*
https://quera.org/problemset/10166

cheat code:

int[] input_numbers = Array.ConvertAll(Console.ReadLine().Split(),int.Parse); // get a line of numbers from console

Console.WriteLine(string.Join(" ", shokolatkor)); // write a line of numbers to console

string[] input = Console.ReadLine().Split(); // get a line if chars form console

*/