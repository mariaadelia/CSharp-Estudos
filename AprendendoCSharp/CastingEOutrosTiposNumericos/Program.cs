using System;

namespace CastingEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1589.56;
            //Fazendo o casting de double para inteiro(com variável)
            int salarioCasting = (int)salario;

            Console.WriteLine("Sem o casting: " + salario);
            Console.WriteLine("Casting de double para int (com variável): " + salarioCasting);

            //Fazendo o casting de double para inteiro (direto com números)
            int testeCasting = (int)1456.89;

            Console.WriteLine("Sem o casting: " + 1456.89);
            Console.WriteLine("Casting de double para int (direto com número): " + testeCasting);

            //Int = para números inteiros de até 1bi
            int testeInt = 1000000000;
            Console.WriteLine("Inteiro: " + testeInt);

            //Long = para números inteiros acima de 1bi
            long testeLong = 1000000000000;
            Console.WriteLine("Long: " + testeLong);

            //Short = para números inteiros de até 32mil
            short testeShort = 32000;
            Console.WriteLine("Short: " + testeShort);

            //Float = para números reais sem muitas casas depois da vírgula
            float testeFloat = 2.56f;
            Console.WriteLine("Float: " + testeFloat);

            Console.ReadLine();
        }
    }
}
