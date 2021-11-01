using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para visualizar a contagem de quantas contas correntes tem
            Console.WriteLine(ContaCorrente.TotalDeContasCorrentes);
            ContaCorrente contaCorrente1 = new ContaCorrente(012, 2345678);
            Console.WriteLine(ContaCorrente.TotalDeContasCorrentes);
            /*Para testar um valor default no nome
             contaCorrente1.Titular = new Cliente();
             Console.WriteLine(contaCorrente1.Titular.Nome);*/

            //Para visualizar a contagem de quantas contas correntes tem
            ContaCorrente contaCorrente2 = new ContaCorrente(012, 4952349);
            Console.WriteLine(ContaCorrente.TotalDeContasCorrentes);

            //Para visualizar a contagem de quantas contas correntes tem            
            ContaCorrente contaCorrente3 = new ContaCorrente(014, 4234249);
            Console.WriteLine(ContaCorrente.TotalDeContasCorrentes);

            Console.ReadLine();
        }
    }
}
