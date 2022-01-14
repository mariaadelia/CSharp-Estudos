using System;
namespace ByteBank.Funcionarios
{
    //Herda da Classe Funcionário
    public class Diretor : Funcionario
    {
        //Construtor de Diretor herda do construtor da Classe Base(Funcionario)
        //Defino aqui o salario base dos diretores (10.000)
        public Diretor(string cpf, double salario = 10000) : base(salario, cpf)
        {
        }

        //Sobreescrita do método GetBonificacao e AumentarSalario
        public override double GetBonificacao()
        {
            //Regra de negócio: salario + bonificação normal de um func.
            //como essa bonificação base está lá na classe que herdei, preciso
            //colocar "base." (poderia colocar tbm base.Salario, mas não é necessário

            return Salario + base.GetBonificacao();
        }

        public override void AumentarSalario()
        {
            //Regra de negócio
            Salario *= 1.15;
        }
    }
}
