using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        //Atributo para guardar o valor total das bonificações
        private double _totalBonificacao;

        //Registro de Bonificacao
        public void RegistrarBonificacao(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        /*Exemplo de Sobrecarga de Método
         
        public void RegistrarBonificacao(Diretor diretor)
        {
            _totalBonificacao += diretor.GetBonificacao();
        }        
         
         */

        //Para mostrar o valor total das bonificações
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
