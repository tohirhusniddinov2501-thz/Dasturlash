using System;

namespace Topshiriq2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-topshiriq: Oddiy kalkulyator (switch)
            Console.WriteLine("=== 1. ODDIY KALKULYATOR ===");
            Console.Write("1-sonni kiriting: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Amalni kiriting (+, -, *, /): ");
            string amal = Console.ReadLine();

            Console.Write("2-sonni kiriting: ");
            double b = double.Parse(Console.ReadLine());

            switch (amal)
            {
                case "+":
                    Console.WriteLine($"Natija: {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"Natija: {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"Natija: {a * b}");
                    break;
                case "/":
                    if (b != 0)
                        Console.WriteLine($"Natija: {a / b}");
                    else
                        Console.WriteLine("Xato: Nolga bo'lish mumkin emas!");
                    break;
                default:
                    Console.WriteLine("Noto'g'ri amal kiritildi!");
                    break;
            }

            // 2-topshiriq: Baho aniqlovchi (100 ballik -> 5 baholik)
            Console.WriteLine();
            Console.WriteLine("=== 2. BAHO ANIQOVCHI ===");
            Console.Write("Ballni kiriting (0-100): ");
            if (int.TryParse(Console.ReadLine(), out int ball) && ball >= 0 && ball <= 100)
            {
                int baho;
                if (ball >= 86) baho = 5;
                else if (ball >= 71) baho = 4;
                else if (ball >= 56) baho = 3;
                else baho = 2;

                Console.WriteLine($"Sizning bahoingiz: {baho}");
            }
            else
            {
                Console.WriteLine("Noto'g'ri ball kiritildi!");
            }

            // 3-topshiriq (Qo'shimcha): Chegirma kodli restoran hisob-kitobi
            Console.WriteLine();
            Console.WriteLine("=== 3. RESTORAN HISOB-KITOBI (CHEGIRMA BILAN) ===");
            Console.Write("Nechta taom: ");
            int miqdor = int.Parse(Console.ReadLine());

            Console.Write("Taom narxini kiriting: ");
            double narx = double.Parse(Console.ReadLine());

            Console.Write("Chegirma kodini kiriting (bo'lmasa Enter): ");
            string kod = Console.ReadLine();

            double taomlarNarxi = narx * miqdor;
            double chegirma = (kod == "STUDENT10") ? taomlarNarxi * 0.10 : 0;
            double chegirmadanKeyin = taomlarNarxi - chegirma;
            double xizmatHaqi = chegirmadanKeyin * 0.10;
            double jami = Math.Round(chegirmadanKeyin + xizmatHaqi, 2);

            Console.WriteLine($"Taomlar narxi:     {taomlarNarxi} so'm");
            Console.WriteLine($"Chegirma (10%):    -{chegirma} so'm");
            Console.WriteLine($"Xizmat haqi (10%): {xizmatHaqi} so'm");
            Console.WriteLine($"JAMI TO'LOV:       {jami} so'm");
        }
    }
}
