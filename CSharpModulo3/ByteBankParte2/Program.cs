using System;
using ByteBankParte2.Funcionarios;

namespace ByteBankParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();
            Console.ReadLine();
        }

        //Classe para Bonificação
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            //Iniciando os funcionarios
            Diretor diretor = new Diretor("234.546.543-67");
            diretor.Nome = "Joana";
            Designer designer = new Designer("434.566.577-67");
            designer.Nome = "Vitória";
            GerenteDeConta gerente = new GerenteDeConta("888.596.507-67");
            gerente.Nome = "Alenxandra";
            Auxiliar auxiliar = new Auxiliar("999.88.577-97");
            auxiliar.Nome = "Vitor";
            Desenvolvedor desenvolvedor = new Desenvolvedor("009.566.577-00");
            desenvolvedor.Nome = "Joelma";

            //Registrando as bonificações
            gerenciador.RegistrarBonificacao(diretor);
            gerenciador.RegistrarBonificacao(designer);
            gerenciador.RegistrarBonificacao(gerente);
            gerenciador.RegistrarBonificacao(auxiliar);
            gerenciador.RegistrarBonificacao(desenvolvedor);


            Console.WriteLine($"Nome: {diretor.Nome}");
            Console.WriteLine($"Bonificação: R${diretor.GetBonificacao()}");
            Console.WriteLine($"Nome: {designer.Nome}");
            Console.WriteLine($"Bonificação: R${designer.GetBonificacao()}");
            Console.WriteLine($"Nome: {gerente.Nome}");
            Console.WriteLine($"Bonificação: R${gerente.GetBonificacao()}");
            Console.WriteLine($"Nome: {auxiliar.Nome}");
            Console.WriteLine($"Bonificação: R${auxiliar.GetBonificacao()}");
            Console.WriteLine($"Nome: {desenvolvedor.Nome}");
            Console.WriteLine($"Bonificação: R${desenvolvedor.GetBonificacao()}");

            //Valor total das bonificações           
            Console.WriteLine($"Valor total das bonificações: R${gerenciador.GetTotalBonificacao()}");

        }
    }
}
