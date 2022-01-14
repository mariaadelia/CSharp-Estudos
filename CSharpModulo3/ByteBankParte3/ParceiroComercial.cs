using System;
using ByteBankParte3.Sistemas;

namespace ByteBankParte3
{
    //Implementado a interface
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public string Cnpj { get; set; }
        public string NomeEmpresa { get; set; }

        //Construtor
        public ParceiroComercial(string cnpj)
        {
            //Propriedade = argumento
            Cnpj = cnpj;
        }

        //Método da Interface
        public bool Autenticar(string senha)
        {
            //Verifciando se a senha(argumento) é igual a Senha(propriedade) (retornando true ou false)
            return Senha == senha;
        }
    }
}
