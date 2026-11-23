using System;

namespace Topshiriq5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-topshiriq: Sinf jadvali — har bir fanning sinf bo'yicha o'rtachasi
            Console.WriteLine("=== 1. FANLAR BO'YICHA O'RTACHA BAHOLAR ===");
            int[,] baholar = new int[3, 4]
            {
                { 5, 4, 5, 3 },
                { 4, 4, 3, 5 },
                { 5, 5, 5, 4 }
            };

            int talabalarSoni = baholar.GetLength(0);
            int fanlarSoni = baholar.GetLength(1);

            for (int j = 0; j < fanlarSoni; j++)
            {
                int fanYigindi = 0;
                for (int i = 0; i < talabalarSoni; i++)
                {
                    fanYigindi += baholar[i, j];
                }
                double fanOrtacha = (double)fanYigindi / talabalarSoni;
                Console.WriteLine($"{j + 1}-fan bo'yicha o'rtacha baho: {fanOrtacha:F2}");
            }

            // 2-topshiriq: 3x3 massiv barcha elementlari yig'indisi
            Console.WriteLine();
            Console.WriteLine("=== 2. 3x3 MATRITSA ELEMENTLARI YIG'INDISI ===");
            int[,] matritsa3x3 = new int[3, 3];
            int umumiyYigindi = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"matritsa[{i}, {j}] = ");
                    matritsa3x3[i, j] = int.Parse(Console.ReadLine());
                    umumiyYigindi += matritsa3x3[i, j];
                }
            }

            Console.WriteLine($"3x3 matritsa elementlari yig'indisi: {umumiyYigindi}");

            // 3-topshiriq (Qo'shimcha): 7 kunlik vazifalar va eng ko'p vazifali kun
            Console.WriteLine();
            Console.WriteLine("=== 3. HAFTALIK VAZIFALAR (7 KUN) ===");
            string[] kunNomlari = { "Dushanba", "Seshanba", "Chorshanba", "Payshanba", "Juma", "Shanba", "Yakshanba" };
            string[][] haftalikVazifalar = new string[7][];

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"{kunNomlari[i]} kuni nechta vazifa bor? ");
                int soni = int.Parse(Console.ReadLine());
                haftalikVazifalar[i] = new string[soni];

                for (int j = 0; j < soni; j++)
                {
                    Console.Write($"  {j + 1}-vazifa: ");
                    haftalikVazifalar[i][j] = Console.ReadLine();
                }
            }

            int engKopKunIndex = 0;
            for (int i = 1; i < haftalikVazifalar.Length; i++)
            {
                if (haftalikVazifalar[i].Length > haftalikVazifalar[engKopKunIndex].Length)
                {
                    engKopKunIndex = i;
                }
            }

            Console.WriteLine($"Eng ko'p vazifali kun: {kunNomlari[engKopKunIndex]} ({haftalikVazifalar[engKopKunIndex].Length} ta vazifa)");
        }
    }
}