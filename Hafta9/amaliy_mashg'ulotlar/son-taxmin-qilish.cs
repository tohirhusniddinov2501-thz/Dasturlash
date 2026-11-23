using System;

namespace Amaliy3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int yashirinSon = rnd.Next(1, 101);
            int urinishlar = 0;
            int taxmin = 0;

            Console.WriteLine("1 dan 100 gacha son o'yladim. Topishga harakat qiling!");

            while (taxmin != yashirinSon)
            {
                Console.Write("Taxminingiz: ");
                if (!int.TryParse(Console.ReadLine(), out taxmin))
                {
                    Console.WriteLine("Iltimos, butun son kiriting!");
                    continue;
                }

                urinishlar++;

                if (taxmin > yashirinSon)
                {
                    Console.WriteLine("Kichikroq o'ylang!");
                }
                else if (taxmin < yashirinSon)
                {
                    Console.WriteLine("Kattaroq o'ylang!");
                }
            }

            Console.WriteLine($"TABRIKLAYMIZ! {urinishlar} ta urinishda topdingiz!");
        }
    }
}
