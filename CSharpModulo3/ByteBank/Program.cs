using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            //Por ser set private, só posso acessar essa propriedade com: NomeDaClasse.Propriedade
            Console.WriteLine($"Total de funcionários: {Funcionario.TotalFuncionarios}");
            Console.WriteLine($"Valor total das bonificações: R${gerenciador.GetTotalBonificacao()}");

            Funcionario funcionario1 = new Funcionario(4000, "00976834566");
            funcionario1.Nome = "Carlos José";

            //Método de aumentar salário
            funcionario1.AumentarSalario();

            //Registrar a bonificacao
            gerenciador.RegistrarBonificacao(funcionario1);

            Console.WriteLine($"O novo salário de {funcionario1.Nome}" +
                $" é de R${funcionario1.Salario}. Sua nova bonificação é de" +
                $" R${funcionario1.GetBonificacao()}");

            //Diretor 1 ganhará o valor incial de diretor (10.000)
            Diretor diretor1 = new Diretor("45663547898");
            diretor1.Nome = "Cecília Oliveira";

            //Método de aumentar salário
            diretor1.AumentarSalario();

            //Registrar a bonificacao
            gerenciador.RegistrarBonificacao(diretor1);

            Console.WriteLine($"O novo salário de {diretor1.Nome}" +
                $" é de R${diretor1.Salario}. Sua nova bonificação é de" +
                $" R${diretor1.GetBonificacao()}");

            //Por ser set private, só posso acessar essa propriedade com: NomeDaClasse.Propriedade
            Console.WriteLine($"Total de funcionários: {Funcionario.TotalFuncionarios}");
            Console.WriteLine($"Valor total das bonificações: R${gerenciador.GetTotalBonificacao()}");

            Console.ReadLine();
        }
    }
}
