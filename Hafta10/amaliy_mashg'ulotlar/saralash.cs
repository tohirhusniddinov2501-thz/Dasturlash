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

            Array.Sort(ballar);
            Console.WriteLine("O'suvchi tartibda:   " + string.Join(", ", ballar));

            Array.Reverse(ballar);
            Console.WriteLine("Kamayuvchi tartibda: " + string.Join(", ", ballar));
        }
    }
}
