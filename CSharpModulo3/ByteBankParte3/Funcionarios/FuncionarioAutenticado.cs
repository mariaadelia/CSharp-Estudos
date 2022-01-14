using System;
using ByteBankParte3.Sistemas;

namespace ByteBankParte3.Funcionarios
{
    //Deixando abstrata para que não tenha que implementar todos os métodos de Funcionário
    public abstract class FuncionarioAutenticado : Funcionario, IAutenticavel
    {
        //Propriedade de Senha
        public string Senha { get; set; }

        //Construtor
        public FuncionarioAutenticado(double salario, string cpf) : base(salario,cpf)
        {
        }

        //Método Autenticar (da Interface)
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }   
    }
}
