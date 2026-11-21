using System;

namespace Amaliy2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nechta taom: ");
            int miqdor = int.Parse(Console.ReadLine());

            Console.Write("Taom narxini kiriting: ");
            double narx = double.Parse(Console.ReadLine());

            double taomlarNarxi = Math.Round(narx * miqdor, 2);
            double xizmatHaqi = Math.Round(taomlarNarxi * 0.10, 2);
            double jamiTolov = Math.Round(taomlarNarxi + xizmatHaqi, 2);

            Console.WriteLine();
            Console.WriteLine($"Taomlar narxi:     {taomlarNarxi} so'm");
            Console.WriteLine($"Xizmat haqi (10%): {xizmatHaqi} so'm");
            Console.WriteLine($"JAMI TO'LOV:       {jamiTolov} so'm");
        }
    }
}
