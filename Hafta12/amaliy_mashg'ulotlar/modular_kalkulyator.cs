using System;

namespace Amaliy6
{
    class Program
    {
        static (int yigindi, double ortacha) YigindiVaOrtacha(params int[] sonlar)
        {
            if (sonlar == null || sonlar.Length == 0)
                return (0, 0);

            int yigindi = 0;
            foreach (int s in sonlar)
            {
                yigindi += s;
            }

            double ortacha = (double)yigindi / sonlar.Length;
            return (yigindi, ortacha);
        }

        static void Almashtir(ref int a, ref int b)
        {
            int vaqtinchalik = a;
            a = b;
            b = vaqtinchalik;
        }

        static void MinMax(int[] massiv, out int min, out int max)
        {
            if (massiv == null || massiv.Length == 0)
            {
                min = 0;
                max = 0;
                return;
            }

            min = massiv[0];
            max = massiv[0];

            foreach (int x in massiv)
            {
                if (x < min) min = x;
                if (x > max) max = x;
            }
        }

        static void Main(string[] args)
        {
            // 1. params
            var natija = YigindiVaOrtacha(10, 20, 30, 40);
            Console.WriteLine($"Yig'indi: {natija.yigindi}, O'rtacha: {natija.ortacha}");

            // 2. ref
            int x = 5, y = 12;
            Console.WriteLine($"Almashtirishdan oldin: x = {x}, y = {y}");
            Almashtir(ref x, ref y);
            Console.WriteLine($"Almashtirishdan keyin: x = {x}, y = {y}");

            // 3. out
            int[] baholar = { 78, 95, 64, 88, 91 };
            MinMax(baholar, out int minBall, out int maxBall);
            Console.WriteLine($"Minimal ball: {minBall}, Maksimal ball: {maxBall}");
        }
    }
}
