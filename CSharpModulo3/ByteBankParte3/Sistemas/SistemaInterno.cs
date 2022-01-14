using System;
namespace ByteBankParte3.Sistemas
{
    public class SistemaInterno
    {
        //Método de login
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioautenticado = funcionario.Autenticar(senha);

            if (usuarioautenticado == true)
            {
                Console.WriteLine("Bem-vinde ao sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha inválida");
                return false;
            }
        }
    }
}
