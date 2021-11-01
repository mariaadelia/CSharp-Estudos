using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando a classe
            ContaCorrente contaCorrente1 = new ContaCorrente();
            ContaCorrente contaCorrente2 = new ContaCorrente();

            //Definindo valores para a classe instanciada
            contaCorrente1.titular = "Joanna da Silva";
            contaCorrente1.numeroAgencia = 896;
            contaCorrente1.numeroConta = 89645789;
            contaCorrente1.saldoConta = 5000;

            /*Teste para ver o tipo de referência (mesmo tendo os mesmos valores, essas
             variáveis estão em locais diferentes, por isso, ao serem comparados se são
            iguais, a resposta será False*/
            contaCorrente2.titular = "Joanna da Silva";
            contaCorrente2.numeroAgencia = 896;
            contaCorrente2.numeroConta = 89645789;
            contaCorrente2.saldoConta = 5000;
            //O teste de true ou false
            Console.WriteLine($"O teste: {contaCorrente1 == contaCorrente2}");

            //Aumentando o saldo da contaCorrente1
            contaCorrente1.saldoConta += 3000;

            Console.WriteLine($"Titular da conta: {contaCorrente1.titular}");
            Console.WriteLine($"Número da agência: {contaCorrente1.numeroAgencia}");
            Console.WriteLine($"Número da conta: {contaCorrente1.numeroConta}");
            Console.WriteLine($"Saldo da conta: {contaCorrente1.saldoConta}");

            Console.ReadLine();
        }
    }
}
