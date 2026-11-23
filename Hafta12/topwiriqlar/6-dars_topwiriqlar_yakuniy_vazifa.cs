}using System;

namespace Topshiriq6
{
    class Program
    {
        static bool MaxsusBelgiBor(string parol, string maxsusBelgilar = "!@#$%")
        {
            foreach (char c in parol)
            {
                if (maxsusBelgilar.IndexOf(c) >= 0)
                    return true;
            }
            return false;
        }

        static long FaktorialRekursiv(int n)
        {
            if (n <= 1) return 1;
            return n * FaktorialRekursiv(n - 1);
        }

        static long FaktorialIterativ(int n)
        {
            long natija = 1;
            for (int i = 2; i <= n; i++)
            {
                natija *= i;
            }
            return natija;
        }

        static int EngKatta(params int[] sonlar)
        {
            int max = sonlar[0];
            for (int i = 1; i < sonlar.Length; i++)
            {
                if (sonlar[i] > max) max = sonlar[i];
            }
            return max;
        }

        static void Main(string[] args)
        {
            // 1. Maxsus belgili parol tekshiruvchi
            Console.WriteLine("=== 1. PAROL TEKSHIRUVCHI (MAXSUS BELGI BILAN) ===");
            Console.Write("Parolni kiriting: ");
            string parol = Console.ReadLine() ?? "";

            bool katta = false, kichik = false, raqam = false;
            foreach (char c in parol)
            {
                if (char.IsUpper(c)) katta = true;
                else if (char.IsLower(c)) kichik = true;
                else if (char.IsDigit(c)) raqam = true;
            }
            bool maxsus = MaxsusBelgiBor(parol);

            Console.WriteLine($"Maxsus belgi (!@#$%) bor: {maxsus}");
            if (katta && kichik && raqam && maxsus && parol.Length >= 8)
                Console.WriteLine("Natija: KUCHLI parol!");
            else
                Console.WriteLine("Natija: ZAIF parol!");

            // 2. Faktorial: rekursiv va iterativ
            Console.WriteLine();
            Console.WriteLine("=== 2. FAKTORIAL (REKURSIV VS ITERATIV) ===");
            Console.Write("Butun son kiriting (masalan 5): ");
            int n = int.Parse(Console.ReadLine());
            long fRek = FaktorialRekursiv(n);
            long fIt = FaktorialIterativ(n);
            Console.WriteLine($"{n}! (rekursiv) = {fRek}");
            Console.WriteLine($"{n}! (iterativ) = {fIt}");
            Console.WriteLine($"Natijalar bir xilmi? {fRek == fIt}");

            // 3. params bilan eng katta son
            Console.WriteLine();
            Console.WriteLine("=== 3. ENG KATTA SON (PARAMS) ===");
            int engKattaSon = EngKatta(14, 89, 42, 105, 63);
            Console.WriteLine($"Berilgan sonlar ichida eng kattasi: {engKattaSon}");

            // 4. Yakuniy portfolio menyusi
            Console.WriteLine();
            Console.WriteLine("=== 4. SEMESTR PORTFOLIO MENYUSI ===");
            Console.WriteLine("1 - Tezkor BMI hisoblash");
            Console.WriteLine("2 - 1 dan 20 gacha juft sonlar");
            Console.WriteLine("0 - Chiqish");
            Console.Write("Tanlovingiz: ");
            string tanlov = Console.ReadLine();

            if (tanlov == "1")
            {
                Console.Write("Vazn (kg): ");
                double vazn = double.Parse(Console.ReadLine());
                Console.Write("Bo'y (m): ");
                double boy = double.Parse(Console.ReadLine());
                double bmi = Math.Round(vazn / (boy * boy), 1);
                Console.WriteLine($"BMI: {bmi}");
            }
            else if (tanlov == "2")
            {
                for (int i = 2; i <= 20; i += 2)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
