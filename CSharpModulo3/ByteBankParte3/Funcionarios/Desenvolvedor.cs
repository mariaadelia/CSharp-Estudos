using System;
namespace ByteBankParte3.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        //Construtor de Desenvolvedor herdando do construtor da classe base
        //Outra forma de passar o vsalor default para o Salário
        public Desenvolvedor(string cpf) : base(3000, cpf)
        {
        }

        //Sobreescrita dos métodos GetBonificacao e AumentarSalario
        public override double GetBonificacao()
        {
            //Regra de Negócio
            return Salario * 0.1;
        }

        public override void AumentarSalario()
        {
            //Regra de Negócio
            Salario *= 1.15;
        }
    }
}
