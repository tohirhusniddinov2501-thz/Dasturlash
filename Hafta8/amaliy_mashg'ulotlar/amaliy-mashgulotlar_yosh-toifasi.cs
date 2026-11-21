using System;

namespace Amaliy2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yoshingizni kiriting: ");
            string kiritma = Console.ReadLine();

            if (!int.TryParse(kiritma, out int yosh) || yosh < 0)
            {
                Console.WriteLine("Noto'g'ri son kiritildi!");
                return;
            }

            if (yosh <= 12)
            {
                Console.WriteLine("Toifa: Bola");
            }
            else if (yosh <= 17)
            {
                Console.WriteLine("Toifa: O'smir");
            }
            else if (yosh <= 59)
            {
                Console.WriteLine("Toifa: Kattalar");
            }
            else
            {
                Console.WriteLine("Toifa: Keksa");
            }
        }
    }
}
