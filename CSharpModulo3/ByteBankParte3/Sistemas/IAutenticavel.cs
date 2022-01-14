using System;
namespace ByteBankParte3.Sistemas
{
    //Interface
    public interface IAutenticavel
    {
        //Método de autenticação da senha
        bool Autenticar(string senha);
    }
}
