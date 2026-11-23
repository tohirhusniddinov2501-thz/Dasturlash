using System;

namespace Topshiriq4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-topshiriq: Harorat jurnali (7 kun)
            Console.WriteLine("=== 1. HARORAT JURNALI (7 KUN) ===");
            double[] haroratlar = new double[7];
            for (int i = 0; i < haroratlar.Length; i++)
            {
                Console.Write($"{i + 1}-kun harorati (°C): ");
                haroratlar[i] = double.Parse(Console.ReadLine());
            }

            int engIssiqKun = 0;
            int engSovuqKun = 0;
            for (int i = 1; i < haroratlar.Length; i++)
            {
                if (haroratlar[i] > haroratlar[engIssiqKun]) engIssiqKun = i;
                if (haroratlar[i] < haroratlar[engSovuqKun]) engSovuqKun = i;
            }

            Console.WriteLine($"Eng issiq kun: {engIssiqKun + 1}-kun ({haroratlar[engIssiqKun]} °C)");
            Console.WriteLine($"Eng sovuq kun: {engSovuqKun + 1}-kun ({haroratlar[engSovuqKun]} °C)");

            // 2-topshiriq: Massivdagi barcha juft sonlar
            Console.WriteLine();
            Console.WriteLine("=== 2. MASSIVDAGI JUFT SONLAR ===");
            Console.Write("Nechta butun son kiritasiz? ");
            int n = int.Parse(Console.ReadLine());
            int[] sonlar = new int[n];

            for (int i = 0; i < sonlar.Length; i++)
            {
                Console.Write($"{i + 1}-son: ");
                sonlar[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Juft sonlar: ");
            foreach (int s in sonlar)
            {
                if (s % 2 == 0)
                {
                    Console.Write($"{s} ");
                }
            }
            Console.WriteLine();

            // 3-topshiriq (Qo'shimcha): O'rtachadan past ball olganlar soni
            Console.WriteLine();
            Console.WriteLine("=== 3. O'RTACHADAN PAST BALL OLGANLAR SONI ===");
            Console.Write("Nechta talaba bor? ");
            int talabaSoni = int.Parse(Console.ReadLine());
            int[] ballar = new int[talabaSoni];
            int yigindi = 0;

            for (int i = 0; i < ballar.Length; i++)
            {
                Console.Write($"{i + 1}-talaba balli: ");
                ballar[i] = int.Parse(Console.ReadLine());
                yigindi += ballar[i];
            }

            double ortacha = (double)yigindi / ballar.Length;
            int pastBallSoni = 0;
            foreach (int ball in ballar)
            {
                if (ball < ortacha)
                {
                    pastBallSoni++;
                }
            }

            Console.WriteLine($"O'rtacha ball: {ortacha:F2}");
            Console.WriteLine($"O'rtachadan past ball olgan talabalar soni: {pastBallSoni}");
        }
    }
}