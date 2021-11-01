﻿using System;
namespace _04_ByteBank
{
    public class ContaCorrente
    {
        //Inicializando a classe Cliente
        /*public Cliente titular = new Cliente(); - é possível inicializar dessa maneira e 
         assim conseguir acessar o atributo direto, ex: conta.titular.nome*/
        public Cliente titular = new Cliente();
        public int numeroAgencia;
        public int numeroConta;

        /*Para que não seja possível alterar diretamente o saldo da conta, mas sim só através
        de métodos/funções*/
        private double saldoConta;

        //Métod para obter saldo
        public void DefinirSaldo(double saldo)
        {
            if (saldo <= 0)
            {
                //Quero que o valor de saldoConta seja o Default (que é 0)
                return;
            }
            /*Caso seja > 0 o novo valor de saldoConta será o valor de Saldo
             Não precisa usar o this*/
            saldoConta = saldo;
        }

        /*Função para ver o saldo (não preciso de parametro porque só quero ver um atributo
         que está nessa classe, não quero alterar o valor disso*/
        public double VerSaldo()
        {
            //Não preciso usar o this
            return saldoConta;
        }

        //Função para saque
        public string Sacar(double valor)
        {
            if (saldoConta < valor)
            {
                string mensagem = "Valor não autorizado, não há dinheiro" +
                    " suficiente";
                return mensagem;
            }

            saldoConta -= valor;
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

            saldoConta += valorDeposito;
            string mensagemDeposito2 = $"R${valorDeposito} foi depositado com " +
                $"sucesso!";
            return mensagemDeposito2;
        }

        //Função para transferência
        public string Transferir (double valor, ContaCorrente contaTransferencia)
        {
            //Se o saldo da conta que está transferindo, for menor que o valor a ser transferido
            if (saldoConta < valor)
            {
                string mensagem = "Saldo insuficiente";
                return mensagem;
            }

            //Para que a conta da qual estou transferindo, receba o valor
            contaTransferencia.Depositar(valor);
            //Para que o novo saldo da conta seja atualizado(subtraindo o valor que depositei)
            Sacar(valor);

            //Mensagem de quanto foi transferido
            string totalTransferencia = $"O R${valor} foi transferido com sucesso";
            //Para que mostre a mensagem de quanto foi transferido
            return totalTransferencia;
        }

        //Método para cadastrar nova conta corrente para transferência
        public ContaCorrente CadastrarContaCorrente(ContaCorrente conta)
        {
            Console.Write("Digite o nome do titular da conta: ");
            conta.titular.nome = Console.ReadLine();
            Console.Write("Digite o cpf do titular da conta: ");
            conta.titular.cpf = Console.ReadLine();
            Console.Write("Digite o número da agência: ");
            conta.numeroAgencia = int.Parse(Console.ReadLine());
            Console.Write("Digite o número da agência: ");
            conta.numeroConta = int.Parse(Console.ReadLine());

            return conta;
        }
    }
}
