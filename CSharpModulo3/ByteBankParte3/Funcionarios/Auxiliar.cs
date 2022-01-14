using System;
namespace ByteBankParte3.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        //Construtor de Auxiliar herdando do construtor da classe base (salario base é o de funcionário)
        public Auxiliar(string cpf) : base(cpf)
        {
        }

        //Sobreescrita dos métodos GetBonificacao e AumentarSalario
        public override double GetBonificacao()
        {
            //Regra de Negócio
            return Salario * 0.2;
        }

        public override void AumentarSalario()
        {
            //Regra de Negócio
            Salario *= 1.10;
        }
    }
}
