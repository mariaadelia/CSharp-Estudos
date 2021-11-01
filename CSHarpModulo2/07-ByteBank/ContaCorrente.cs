using System;
namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        //Para obter o número total de contas correntes
        public static int TotalDeContasCorrentes { get; private set; }

        //campo
        private int _numeroAgencia;
        //Propriedade
        public int NumeroAgencia
        {
            get
            {
                return _numeroAgencia;
            }
            set
            {
                if (value <=0)
                {
                    //Para dar erro e não permitir que o programa continue
                    throw new ArgumentException("O número da agência não pode ser menor ou " +
                        "igual a zero");
                }
                _numeroAgencia = value;
            }
        }

        //campo
        private int _numeroConta;
        //Propriedade
        public int NumeroConta
        {
            get { return _numeroConta;}
            set
            {
                if (value <= 0)
                {
                    //Para dar erro e não permitir que o programa continue
                    throw new ArgumentException("O número da conta não pode ser menor ou " +
                        "igual a zero");
                }
                _numeroConta = value;
            }

        }

        /*Para que não seja possível alterar diretamente o saldo da conta, mas sim só através
        de métodos/funções*/
        private double _saldoConta;

        //Get e Set de SaldoConta(com a regra específica de negócio
        public double SaldoConta
        {
            get
            {
                return _saldoConta;
            }
            set
            {
                if (value <= 0)
                {
                    //Quero que o valor local (representado pelo value) de saldoConta seja o Default (que é 0)
                    return;
                }
                //Caso seja > 0 o novo valor de saldoConta será o valor local (representado pelo value)
                _saldoConta = value;
            }
        }

        //Constructor
        public ContaCorrente(int agencia, int conta)
        {
            NumeroAgencia = agencia;
            NumeroConta = conta;

            //Para somar mais um na quantidade de contas correntes
            TotalDeContasCorrentes++;
        }

        //Função para saque
        public string Sacar(double valor)
        {
            if (_saldoConta < valor)
            {
                string mensagem = "Valor não autorizado, não há dinheiro" +
                    " suficiente";
                return mensagem;
            }

            _saldoConta -= valor;
            string mensagem2 = $"O novo saldo é de R${_saldoConta}";
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

            _saldoConta += valorDeposito;
            string mensagemDeposito2 = $"R${valorDeposito} foi depositado com " +
                $"sucesso!";
            return mensagemDeposito2;
        }

        //Função para transferência
        public string Transferir (double valor, ContaCorrente contaTransferencia)
        {
            //Se o saldo da conta que está transferindo, for menor que o valor a ser transferido
            if (_saldoConta < valor)
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
            //Para que possa acessar as propriedades de cliente
            conta.Titular = new Cliente();

            Console.Write("Digite o nome do titular da conta: ");
            conta.Titular.Nome = Console.ReadLine();
            Console.Write("Digite o cpf do titular da conta: ");
            conta.Titular.Cpf = Console.ReadLine();   
            return conta;
        }
    }
}
