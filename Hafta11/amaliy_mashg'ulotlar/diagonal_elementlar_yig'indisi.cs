using System;

namespace Amaliy5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matritsa = new int[4, 4]
            {
                { 10,  2,  3,  4 },
                {  5, 20,  7,  8 },
                {  9, 10, 30, 12 },
                { 13, 14, 15, 40 }
            };

            int diagonalYigindi = 0;
            for (int i = 0; i < matritsa.GetLength(0); i++)
            {
                diagonalYigindi += matritsa[i, i];
            }

            Console.WriteLine($"Bosh diagonal elementlari yig'indisi: {diagonalYigindi}");
        }
    }
}
