using System;

namespace Amaliy6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Parolni kiriting: ");
            string parol = Console.ReadLine() ?? "";

            bool kattaBor = false;
            bool kichikBor = false;
            bool raqamBor = false;

            foreach (char c in parol)
            {
                if (char.IsUpper(c)) kattaBor = true;
                else if (char.IsLower(c)) kichikBor = true;
                else if (char.IsDigit(c)) raqamBor = true;
            }

            Console.WriteLine($"Uzunlik: {parol.Length}");
            Console.WriteLine($"Katta harf bor: {kattaBor}");
            Console.WriteLine($"Kichik harf bor: {kichikBor}");
            Console.WriteLine($"Raqam bor: {raqamBor}");

            if (kattaBor && kichikBor && raqamBor && parol.Length >= 8)
            {
                Console.WriteLine("Parol KUCHLI!");
            }
            else
            {
                Console.WriteLine("Parol ZAIF!");
            }
        }
    }
}
