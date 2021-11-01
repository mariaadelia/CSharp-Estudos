using System;
namespace _02_ByteBank
{
    public class ContaCorrente
    {
        public string titular;
        public int numeroAgencia;
        public int numeroConta;
        public double saldoConta;

        //Função para saque
        public string Sacar(double valor)
        {
            if (this.saldoConta < valor)
            {
                string mensagem = "Valor não autorizado, não há dinheiro" +
                    " suficiente";
                return mensagem;
            }

            this.saldoConta -= valor;
            string mensagem2 = $"O novo saldo é de R${saldoConta}";
            return mensagem2;
        }

        //Função para depósito
        public string Depositar (double valorDeposito)
        {
            /*Se o valor <= a 0, não é possível fazer o depósito (pois não existe
             depósito nulo nem negativo*/
            if (valorDeposito <= 0)
            {
                string mensagemDeposito = $"O valor R${valorDeposito} não pode" +
                    $" ser depositado";
                return mensagemDeposito;
            }

            this.saldoConta += valorDeposito;
            string mensagemDeposito2 = $"R${valorDeposito} foi depositado com " +
                $"sucesso!";
            return mensagemDeposito2;
        }

        //Função para transferência
        public string Transferir (double valor, ContaCorrente contaTransferencia)
        {
            //Se o saldo da conta que está transferindo, for menor que o valor a ser transferido
            if (this.saldoConta < valor)
            {
                string mensagem = "Saldo insuficiente";
                return mensagem;
            }

            //Para que a conta da qual estou transferindo, receba o valor
            contaTransferencia.Depositar(valor);
            //Para que o novo saldo da conta seja atualizado(subtraindo o valor que depositei)
            this.Sacar(valor);

            //Mensagem de quanto foi transferido
            string totalTransferencia = $"O R${valor} foi transferido com sucesso";
            //Para que mostre a mensagem de quanto foi transferido
            return totalTransferencia;
        }

        //Método para cadastrar nova conta corrente para transferência
        public ContaCorrente CadastrarContaCorrente(ContaCorrente conta)
        {
            Console.Write("Digite o nome do titular da conta: ");
            conta.titular = Console.ReadLine();
            Console.Write("Digite o número da agência: ");
            conta.numeroAgencia = int.Parse(Console.ReadLine());
            Console.Write("Digite o número da agência: ");
            conta.numeroConta = int.Parse(Console.ReadLine());

            return conta;
        }
    }
}
