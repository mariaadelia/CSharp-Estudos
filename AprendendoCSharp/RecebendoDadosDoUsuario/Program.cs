using System;

namespace RecebendoDadosDoUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World! Digite seu nome: ");
            //Para ler a informação digitada pelo usuário
            var nome = Console.ReadLine();

            Console.Write("Digite sua letra favorita: ");
            //Para ler char
            char teste = char.Parse(Console.ReadLine());


            Console.Write("Digite sua idade: ");
            //Para ler número inteiro
            int idade = Convert.ToInt32(Console.ReadLine());


            Console.Write($"Digite seu salário, {nome}: R$");
            //Para ler número double
            double salario = double.Parse(Console.ReadLine());

            //Para mostrar em tela
            Console.WriteLine($"Olá, {nome}! Você tem {idade} anos, seu salário" +
                $"é de R${salario}. Sua letra favorita é: {teste}");
            Console.WriteLine("Olá, " + nome + "! Você tem " + idade + " anos, seu salário" +
                " é de R$" + salario + ". Sua letra favorita é: " + teste);

            Console.ReadLine();
        }
    }
}
