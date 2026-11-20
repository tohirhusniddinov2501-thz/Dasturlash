using System;

namespace Topshiriq1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-qism: Kengaytirilgan Raqamli ID karta
            Console.Write("Ismingizni kiriting: ");
            string ism = Console.ReadLine();

            Console.Write("Guruhingizni kiriting: ");
            string guruh = Console.ReadLine();

            Console.Write("Yoshingizni kiriting: ");
            string yosh = Console.ReadLine();

            Console.Write("Sevimli rangingizni kiriting: ");
            string sevimliRang = Console.ReadLine();

            Console.Write("Telefon raqamingizni kiriting: ");
            string telefon = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("KENGAYTIRILGAN ID KARTA");
            Console.WriteLine("=======================");
            Console.WriteLine($"Ism:           {ism}");
            Console.WriteLine($"Guruh:         {guruh}");
            Console.WriteLine($"Yosh:          {yosh}");
            Console.WriteLine($"Sevimli rang:  {sevimliRang}");
            Console.WriteLine($"Telefon:       {telefon}");
            Console.WriteLine("=======================");

            // 2-qism: Uy hayvoni profili
            Console.WriteLine();
            Console.Write("Uy hayvoningiz bormi? (true/false): ");
            bool uyHayvoniBormi = bool.Parse(Console.ReadLine());

            Console.Write("Hayvon nomini kiriting: ");
            string hayvonNomi = Console.ReadLine();

            Console.Write("Hayvon turini kiriting (masalan: mushuk, it): ");
            string hayvonTuri = Console.ReadLine();

            Console.Write("Hayvon yoshini kiriting: ");
            int hayvonYoshi = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("UY HAYVONI PROFILI");
            Console.WriteLine("===================");
            Console.WriteLine($"Uy hayvoni bormi: {uyHayvoniBormi}");
            Console.WriteLine($"Nomi:             {hayvonNomi}");
            Console.WriteLine($"Turi:             {hayvonTuri}");
            Console.WriteLine($"Yoshi:            {hayvonYoshi}");
            Console.WriteLine("===================");
        }
    }
}
