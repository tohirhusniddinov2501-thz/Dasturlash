using System;

namespace Amaliy5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] baholar = new int[3, 4]
            {
                { 5, 4, 5, 3 }, // 1-talaba
                { 4, 4, 3, 5 }, // 2-talaba
                { 5, 5, 5, 4 }  // 3-talaba
            };

            int talabalarSoni = baholar.GetLength(0);
            int fanlarSoni = baholar.GetLength(1);

            for (int i = 0; i < talabalarSoni; i++)
            {
                int yigindi = 0;
                for (int j = 0; j < fanlarSoni; j++)
                {
                    yigindi += baholar[i, j];
                }

                double ortacha = (double)yigindi / fanlarSoni;
                Console.WriteLine($"{i + 1}-talaba o'rtachasi: {ortacha:F2}");
            }
        }
    }
}
