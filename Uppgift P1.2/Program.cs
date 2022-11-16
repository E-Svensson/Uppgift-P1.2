using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många sidor kommer tärningarna ha?: "); int sidor = int.Parse(Console.ReadLine());
            Console.Write("Hur många tärnignar kommer slås?: "); int antal = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] tal = new int[antal];

            for (int i = 0; i < tal.Length; i++)
            {
                Random random = new Random();
                tal[i] = random.Next(1, sidor+1);
                Console.WriteLine($"Tärningen slog {tal[i]}.");
            }

            Console.WriteLine();
            int Summa = tal.Sum();
            float Medelvärde = Summa / antal;

            Console.WriteLine($"Du slog totalt {Summa} och fick ett medelvärde på {Medelvärde}.");
        }
    }
}
