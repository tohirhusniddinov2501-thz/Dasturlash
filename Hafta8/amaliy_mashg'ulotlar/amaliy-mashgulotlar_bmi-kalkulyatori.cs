using System;

namespace Amaliy2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bo'yingizni kiriting (metrda, masalan 1.75): ");
            if (!double.TryParse(Console.ReadLine(), out double boy) || boy <= 0)
            {
                Console.WriteLine("Noto'g'ri bo'y kiritildi!");
                return;
            }

            Console.Write("Vazningizni kiriting (kg): ");
            if (!double.TryParse(Console.ReadLine(), out double vazn) || vazn <= 0)
            {
                Console.WriteLine("Noto'g'ri vazn kiritildi!");
                return;
            }

            double bmi = Math.Round(vazn / Math.Pow(boy, 2), 1);
            Console.WriteLine($"Sizning BMI ko'rsatkichingiz: {bmi}");

            if (bmi < 18.5)
            {
                Console.WriteLine("Toifa: Kam vazn");
            }
            else if (bmi <= 24.9)
            {
                Console.WriteLine("Toifa: Normal");
            }
            else
            {
                Console.WriteLine("Toifa: Ortiqcha vazn");
            }
        }
    }
}
