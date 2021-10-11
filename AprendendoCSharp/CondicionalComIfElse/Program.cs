using System;

namespace CondicionalComIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 16;
            Boolean acompanhado = false;

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade, pode entrar");
            }
            else
            {
                if(acompanhado == true)
                {
                    Console.WriteLine("Você não é maior de idade, mas está" +
                        " acompanhado, pode entrar");
                }
                else
                {
                    Console.WriteLine("Você não é maior de idade, nem está acompanhado." +
                        "Desculpe, mas você não pode entrar");
                }
            }

            Console.ReadLine();
        }
    }
}
