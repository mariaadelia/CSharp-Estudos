using System;
namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        //Private = só pode ser acessado por um código da mesma classe
        public static int TotalFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        //Protected = para que apenas essa classe e a classe derivada possam mudar
        //o valor
        public double Salario { get; protected set; }

        //Construtor
        public Funcionario(double salario, string cpf)
        {
            //Incrementando toda vez que for criado um novo funcionário
            TotalFuncionarios++;

            //Propriedade = argumento
            Salario = salario;
            Cpf = cpf;
        }

        //Método virtual =  para que possa ser sobreescrito em outra classe
        public virtual double GetBonificacao()
        {
            //Regra de negócio
            return Salario * 0.10;
        }

        //Método para aumentar o salário
        public virtual void AumentarSalario()
        {
            //Regra de negócio
            Salario *= 1.1;
        }
    }
}
