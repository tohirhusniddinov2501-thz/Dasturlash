using System;

namespace Amaliy3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qaysi sonning ko'paytirish jadvali kerak? ");
            int son = int.Parse(Console.ReadLine());

            Console.WriteLine($"=== {son} uchun ko'paytirish jadvali ===");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{son} x {i} = {son * i}");
            }

            Console.WriteLine();
            Console.WriteLine("=== 1 dan 10 gacha to'liq 10x10 ko'paytirish jadvali ===");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i}x{j}={i * j}	");
                }
                Console.WriteLine();
            }
        }
    }
}
