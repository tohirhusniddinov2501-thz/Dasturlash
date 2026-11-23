using System;

namespace Amaliy4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nechta talaba balli kiritiladi? ");
            if (!int.TryParse(Console.ReadLine(), out int soni) || soni <= 0)
            {
                Console.WriteLine("Noto'g'ri son kiritildi!");
                return;
            }

            int[] ballar = new int[soni];
            for (int i = 0; i < ballar.Length; i++)
            {
                Console.Write($"{i + 1}-talaba balli: ");
                ballar[i] = int.Parse(Console.ReadLine());
            }

            // 1-vazifa: Ballni qidirish
            Console.Write("Qidirilayotgan ballni kiriting: ");
            int qidiriladigan = int.Parse(Console.ReadLine());

            bool topildi = false;
            for (int i = 0; i < ballar.Length; i++)
            {
                if (ballar[i] == qidiriladigan)
                {
                    Console.WriteLine($"Ball ({qidiriladigan}) {i}-indeksda topildi.");
                    topildi = true;
                }
            }

            if (!topildi)
            {
                Console.WriteLine($"Massivda {qidiriladigan} ball topilmadi.");
            }

            // 2-vazifa: Eng past ballni topib, 0 ga almashtirish
            int minIndex = 0;
            for (int i = 1; i < ballar.Length; i++)
            {
                if (ballar[i] < ballar[minIndex])
                {
                    minIndex = i;
                }
            }

            Console.WriteLine($"Eng past ball ({ballar[minIndex]}) {minIndex}-indeksda edi -> 0 ga almashtirildi.");
            ballar[minIndex] = 0;

            Console.WriteLine("Yangilangan massiv: " + string.Join(", ", ballar));
        }
    }
}
