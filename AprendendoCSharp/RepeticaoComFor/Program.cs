using System;

namespace RepeticaoComFor
{
    class Program
    {
        static void Main(string[] args)
        {
            double dinheiroGuardado = 2000;

            for (int contador = 1; contador <= 12; contador++)
            {
                dinheiroGuardado += 1000;
                Console.WriteLine("No mês " + contador + ", você terá R$ " +
                    "" + dinheiroGuardado);
            }

            Console.ReadLine();
        }
    }
}
