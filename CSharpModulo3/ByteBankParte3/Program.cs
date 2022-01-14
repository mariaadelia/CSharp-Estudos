using System;
using ByteBankParte3.Funcionarios;
using ByteBankParte3.Sistemas;

namespace ByteBankParte3
{
    class Program
    {
        static void Main(string[] args)
        {
            UsarSistema();
            Console.ReadLine();
        }

        //Classe para acessar o Sistema Interno
        public static void UsarSistema()
        {
            //Inicializando SistemaInterno
            SistemaInterno sistemaInterno = new SistemaInterno();

            //Inicializando as classes autenticáveis (que implementam a IAutenticavel)
            Diretor diretor = new Diretor("234.546.543-67");
            diretor.Nome = "Joana";
            diretor.Senha = "TesteTeste1234@";

            GerenteDeConta gerenteDeConta = new GerenteDeConta("567.666.543-67");
            gerenteDeConta.Nome = "Vitória";
            gerenteDeConta.Senha = "234@TesteTeste1";

            ParceiroComercial parceiroComercial = new ParceiroComercial("53.136.160/0001-29");
            parceiroComercial.NomeEmpresa = "Banco TesteByte";
            parceiroComercial.Senha = "234@teT1";

            //Acesso ao Sistema (senha incorreta)
            //sistemaInterno.Logar(diretor, "T4@");
            //sistemaInterno.Logar(gerenteDeConta, "234@T1");
            //sistemaInterno.Logar(parceiroComercial, "21");

            //Acesso ao Sistema (senha correta)
            sistemaInterno.Logar(diretor, "TesteTeste1234@");
            sistemaInterno.Logar(gerenteDeConta, "234@TesteTeste1");
            sistemaInterno.Logar(parceiroComercial, "234@teT1");


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
