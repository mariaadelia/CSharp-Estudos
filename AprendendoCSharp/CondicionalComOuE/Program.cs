using System;

namespace CondicionalComOuE
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 16;
            Boolean acompanhado = true;

            if (idade >= 18 || acompanhado == true)
            {
                Console.WriteLine("Você pode entrar");
            }
            else
            {
                Console.WriteLine("Você não pode entrar");

            }

            if (idade >= 18 && acompanhado == true)
            {
                Console.WriteLine("Você pode entrar");
            }
            else
            {
                Console.WriteLine("Você não pode entrar");

            }


            Console.ReadLine();
        }
    }
}
