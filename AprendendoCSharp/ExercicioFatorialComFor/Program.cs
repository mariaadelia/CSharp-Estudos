using System;

namespace ExercicioFatorialComFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;

            for (int i = 1; i <= 10; i++)
            {
                fatorial *= i;
                Console.WriteLine("O fatorial de " + i + ": " + fatorial);
            }

            Console.ReadLine();
        }
    }
}
