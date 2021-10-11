using System;

namespace ExercicioForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contador = 1; contador <= 10; contador++)
            {
                for (int i = 1; i <= contador; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            /*Uma forma diferente de fazer o código anterior (usando o Break):
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if(contadorColuna >= contadorLinha)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
            */

            Console.ReadLine();
        }
    }
}
