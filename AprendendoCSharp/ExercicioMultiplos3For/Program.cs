using System;

namespace ExercicioMultiplos3For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contador = 1; contador <= 100; contador++)
            {
                if (contador % 3 == 0)
                {
                    Console.Write(contador + " ");
                }
            }

            /*Forma mais simples:
             for (int i = 3; i < 100; i += 3 )
             {
                Console.WriteLine(i);
             }
             
             
             */

            Console.ReadLine();
        }
    }
}
