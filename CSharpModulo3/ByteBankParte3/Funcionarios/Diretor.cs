using System;
using ByteBankParte3.Sistemas;

namespace ByteBankParte3.Funcionarios
{
    //Herda da Classe Funcionário
    public class Diretor : FuncionarioAutenticado, IAutenticavel
    {
        //Construtor de Diretor herda do construtor da Classe Base(Funcionario)
        //Defino aqui o salario base dos diretores (5.000)
        public Diretor(string cpf, double salario = 5000) : base(salario, cpf)
        {
        }

        //Sobreescrita dos métodos GetBonificacao e AumentarSalario
        public override double GetBonificacao()
        {
            //Regra de negócio
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            //Regra de negócio
            Salario *= 1.15;
        }
    }
}
