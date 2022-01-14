using System;
namespace ByteBankParte2.Funcionarios
{
    //Transformando a classe em abstract
    public abstract class Funcionario
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

        //Sobrecarga do construtor passando um valor base de salário
        public Funcionario(string cpf) : this(2000, cpf)
        {
        }


        //Métodos abstracts (GetBonificação e AumentarSalário)
        public abstract double GetBonificacao();
        public abstract void AumentarSalario();
    }
}
