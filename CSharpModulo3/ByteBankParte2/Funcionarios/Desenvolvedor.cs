using System;
namespace ByteBankParte2.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        //Construtor de Desenvolvedor herdando do construtor da classe base
        public Desenvolvedor(string cpf, double salario = 3000) : base(salario, cpf)
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
