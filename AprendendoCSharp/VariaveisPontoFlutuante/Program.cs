using System;

namespace VariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            //Divisão que  irá aparecer o resto (porque um dos números tem o ponto flutuante)
            double valor = 15.0 / 2;

            //Divisão que não irá aparecer o resto (porque não tem o ponto flutuante)
            double valor2 = 15 / 2;

            Console.WriteLine("Colocando o ponto flutuante: 15/2.0 ou 15.0/2 = "+ valor);
            Console.WriteLine("Não colocando o ponto flutuante: 15/2 = " + valor2);

            Console.ReadLine();
        }
    }
}
