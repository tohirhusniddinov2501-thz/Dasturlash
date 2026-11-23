using System;

namespace Amaliy5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] vazifalar = new string[2][];
            vazifalar[0] = new string[] { "Matematika", "Dasturlash" };
            vazifalar[1] = new string[] { "Fizika" };

            for (int i = 0; i < vazifalar.Length; i++)
            {
                Console.WriteLine($"Kun {i + 1}: {vazifalar[i].Length} ta vazifa");
                foreach (string vazifa in vazifalar[i])
                {
                    Console.WriteLine($"  - {vazifa}");
                }
            }
        }
    }
