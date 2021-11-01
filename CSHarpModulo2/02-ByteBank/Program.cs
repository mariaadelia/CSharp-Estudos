using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando a classe
            ContaCorrente contaCorrente1 = new ContaCorrente();

            //Recebendo o saldo em conta
            Console.Write("Digite o saldo em conta: R$");
            contaCorrente1.saldoConta = double.Parse(Console.ReadLine());
            Console.WriteLine("*****************************************");

            //Opção de saque, consulta de saldo e depósito
            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("1 - Depósito");
            Console.WriteLine("2 - Saque");
            Console.WriteLine("3 - Consulta de saldo");
            Console.WriteLine("4 - Fazer transferência");
            Console.WriteLine("5 - Para sair");
            int opcao = int.Parse(Console.ReadLine());

            do
            {
                switch (opcao)
                {
                    //Depósito
                    case 1:
                        {
                            Console.Write("Digite o valor a ser depositado: R$");
                            string deposito = contaCorrente1.Depositar(double.Parse(Console.ReadLine()));
                            Console.WriteLine(deposito);
                            Console.WriteLine("*****************************************");
                            break;
                        }

                    //Saque
                    case 2:
                        {
                            Console.Write("Digite o valor que deseja sacar: R$");
                            //Coloco string aqui porque quero receber a mensagem string que escrevi lá na função
                            string resultadoSaque = contaCorrente1.Sacar(double.Parse(Console.ReadLine()));
                            Console.WriteLine(resultadoSaque);
                            Console.WriteLine("*****************************************");
                            break;
                        }

                    //Consultar o saldo
                    case 3:
                        {
                            Console.WriteLine($"Seu saldo é de: R${contaCorrente1.saldoConta}");
                            Console.WriteLine("*****************************************");
                            break;
                        }

                    //Fazer transferência
                    case 4:
                        {
                            Console.WriteLine("*****************************************");

                            //Inicializando uma nova conta para transferência
                            ContaCorrente novaConta = new ContaCorrente();
                            novaConta.CadastrarContaCorrente(novaConta);

                            //Valor da transferência
                            Console.Write("Digite o valor a ser transferido: R$");
                            string transferencia = contaCorrente1.Transferir((double.Parse(Console.ReadLine())),novaConta);

                            //Mostrar as mensagens finais
                            Console.WriteLine(transferencia);
                            Console.WriteLine("*****************************************");
                            break;
                        }

                    //Sair
                    case 5:
                        {
                            break;
                        }

                    //Opção inválida
                    default:
                        {
                            Console.WriteLine("Opção inválida, escolha novamente!");
                            Console.WriteLine("*****************************************");
                            break;
                        }
                }

                //Caso a pessoa digite para sair(5) de primeira:
                if (opcao == 5)
                {
                    break;
                }

                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("1 - Depósito");
                Console.WriteLine("2 - Saque");
                Console.WriteLine("3 - Consulta de saldo");
                Console.WriteLine("4 - Fazer transferência");
                Console.WriteLine("5 - Para sair");
                opcao = int.Parse(Console.ReadLine());

            } while (opcao != 5);
        }
    }
}
