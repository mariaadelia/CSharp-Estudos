using System;

namespace AtividadeImpostoDeRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3800.00;

            if (salario<= 1903.98)
            {
                Console.WriteLine("Não há dedução a ser feita!");
            }
            else if (salario>=1903.99 && salario<=2826.65)
            {
                Console.WriteLine("O IR é de 7,5% e você poderá deduzir R$142,80");
            }
            else if (salario>=2826.66 && salario<=3751.05)
            {
                Console.WriteLine("O IR é de 15% e você poderá deduzir R$354,80");
            }
            else if (salario>=3751.06 && salario<=4664.68)
            {
                Console.WriteLine("O IR é de 22,5% e você poderá deduzir R$636,13");
            }
            else
            {
                Console.WriteLine("O IR é de 27,5% e você poderá deduzir R$869,36");
            }

            Console.ReadLine();
        }
    }
}
