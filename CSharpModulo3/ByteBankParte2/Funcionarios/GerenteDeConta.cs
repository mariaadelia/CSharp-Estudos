using System;
namespace ByteBankParte2.Funcionarios
{
    public class GerenteDeConta : Funcionario
    {
        //Construtor de Designer herdando do construtor da classe base
        public GerenteDeConta(string cpf, double salario = 4000) : base(salario, cpf)
        {
        }

        //Sobreescrita dos métodos GetBonificacao e AumentarSalario
        public override double GetBonificacao()
        {
            //Regra de Negócio
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            //Regra de Negócio
            Salario *= 1.05;
        }
    }
}
