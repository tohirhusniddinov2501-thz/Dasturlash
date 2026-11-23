using System;

namespace Amaliy3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Buzilgan kod namunasi (cheksiz siklga tushib qoladi):
            // int i = 1;
            // while (i <= 5)
            // {
            //     Console.WriteLine(i);
            //     // Xato: i++ unutilgan, shart (i <= 5) hech qachon FALSE bo'lmaydi
            // }

            // Tuzatilgan versiya (F9 bilan breakpoint qo'yib, F10 bilan kuzating):
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine($"Qadam: {i}");
                i++;
            }
        }
    }
}
