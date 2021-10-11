using System;

namespace RepeticaoComWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double dinheiroGuardado = 2000;
            int contador = 1;

            while (contador<=12)
            {
                dinheiroGuardado += 1000;
                Console.WriteLine("No mês " + contador + ", você terá guardado" +
                    "R$ " + dinheiroGuardado);             

                //contador = contador + 1;
                //contador += 1;
                contador++;
            }

            Console.ReadLine();
        }
    }
}
