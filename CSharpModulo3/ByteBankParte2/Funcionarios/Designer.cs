using System;
namespace ByteBankParte2.Funcionarios
{
    public class Designer : Funcionario
    {
        //Construtor de Designer herdando do construtor da classe base
        public Designer(string cpf, double salario = 3000) : base(salario, cpf)
        {
        }

        //Sobreescrita dos métodos GetBonificacao e AumentarSalario
        public override double GetBonificacao()
        {
            //Regra de Negócio
            return Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            //Regra de Negócio
            Salario *= 1.11;
        }
    }
}
