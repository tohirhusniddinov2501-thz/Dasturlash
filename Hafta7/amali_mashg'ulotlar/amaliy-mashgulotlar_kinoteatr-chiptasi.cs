using System;

namespace Amaliy1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kino nomini kiriting: ");
            string kinoNomi = Console.ReadLine();

            Console.Write("Tomoshabin yoshini kiriting: ");
            string yosh = Console.ReadLine();

            Console.Write("O'rindiq raqamini kiriting: ");
            string orindiqRaqami = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("KINOTEATR CHIPTASI");
            Console.WriteLine("==================");
            Console.WriteLine($"Kino:    {kinoNomi}");
            Console.WriteLine($"Yosh:    {yosh}");
            Console.WriteLine($"O'rindiq:{orindiqRaqami}");
            Console.WriteLine("==================");
        }
    }
}
