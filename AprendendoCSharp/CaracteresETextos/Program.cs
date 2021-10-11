using System;

namespace CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Char
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)78;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 2);
            Console.WriteLine(primeiraLetra);
            //

            //String
            //Deixei dessa forma para que o espaço não deixasse a lista estranha
            string lista = @"Lista:
a
b
c";
            Console.WriteLine(lista);

            Console.ReadLine();
        }
    }
}
