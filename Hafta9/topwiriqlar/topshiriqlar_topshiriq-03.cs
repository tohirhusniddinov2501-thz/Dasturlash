using System;

namespace Topshiriq3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-topshiriq: Son taxmin qilish o'yini (maksimum 7 urinish)
            Console.WriteLine("=== 1. SON TAXMIN QILISH O'YINI (MAX 7 URINISH) ===");
            Random rnd = new Random();
            int yashirinSon = rnd.Next(1, 101);
            int urinishlar = 0;
            int maxUrinish = 7;
            bool topildi = false;

            while (urinishlar < maxUrinish)
            {
                Console.Write($"Urinish {urinishlar + 1}/{maxUrinish} - Taxminingiz: ");
                if (!int.TryParse(Console.ReadLine(), out int taxmin))
                {
                    Console.WriteLine("Iltimos, butun son kiriting!");
                    continue;
                }

                urinishlar++;

                if (taxmin == yashirinSon)
                {
                    Console.WriteLine($"TABRIKLAYMIZ! {urinishlar} ta urinishda topdingiz!");
                    topildi = true;
                    break;
                }
                else if (taxmin > yashirinSon)
                {
                    Console.WriteLine("Kichikroq o'ylang!");
                }
                else
                {
                    Console.WriteLine("Kattaroq o'ylang!");
                }
            }

            if (!topildi)
            {
                Console.WriteLine($"Ishdan chiqdingiz! Yashirin son {yashirinSon} edi.");
            }

            // 2-topshiriq: 1 dan 50 gacha 3 ga bo'linadigan sonlar
            Console.WriteLine();
            Console.WriteLine("=== 2. 1 DAN 50 GACHA 3 GA BO'LINADIGAN SONLAR ===");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();

            // 3-topshiriq (Qo'shimcha): Yulduzcha piramida (ichma-ich for yordamida)
            Console.WriteLine();
            Console.WriteLine("=== 3. YULDUZCHA PIRAMIDA ===");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
