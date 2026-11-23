using System;

namespace Amaliy6
{
    class Program
    {
        static int EkubRekursiv(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (b == 0) return a;
            return EkubRekursiv(b, a % b);
        }

        static int EkubIterativ(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int qoldiq = a % b;
                a = b;
                b = qoldiq;
            }
            return a;
        }

        static void Main(string[] args)
        {
            Console.Write("1-sonni kiriting: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("2-sonni kiriting: ");
            int b = int.Parse(Console.ReadLine());

            int rekNatija = EkubRekursiv(a, b);
            int itNatija = EkubIterativ(a, b);

            Console.WriteLine($"EKUB (rekursiv): {rekNatija}");
            Console.WriteLine($"EKUB (iterativ): {itNatija}");
            Console.WriteLine($"Natijalar bir xilmi? {rekNatija == itNatija}");
        }
    }
}
