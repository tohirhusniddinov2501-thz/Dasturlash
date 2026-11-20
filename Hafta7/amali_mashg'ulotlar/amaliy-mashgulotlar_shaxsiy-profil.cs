using System;

namespace Amaliy1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ismingizni kiriting: ");
            string ism = Console.ReadLine();

            Console.Write("Sevimli faningizni kiriting: ");
            string sevimliFan = Console.ReadLine();

            Console.Write("Yoshingizni kiriting: ");
            int yosh = int.Parse(Console.ReadLine());

            Console.Write("Bo'yingizni kiriting (metrda, masalan 1.75): ");
            double boy = double.Parse(Console.ReadLine());

            Console.Write("Sport bilan shug'ullanasizmi? (true/false): ");
            bool sport = bool.Parse(Console.ReadLine());

            Console.Write("Ismingizning bosh harfini kiriting: ");
            char boshHarf = char.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("SHAXSIY PROFIL KARTASI");
            Console.WriteLine("======================");
            Console.WriteLine($"Bosh harf:   {boshHarf}");
            Console.WriteLine($"Ism:         {ism}");
            Console.WriteLine($"Yosh:        {yosh}");
            Console.WriteLine($"Bo'y:        {boy} m");
            Console.WriteLine($"Sevimli fan: {sevimliFan}");
            Console.WriteLine($"Sport:       {sport}");
            Console.WriteLine("======================");
        }
    }
}
