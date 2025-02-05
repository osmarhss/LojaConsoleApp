using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace___ConsoleApp.MétodosDePagamento
{
    public class CartaoCredito : IProcessarPagamento
    {
        public CartaoCredito(string numCartao, string nomeTitular, string dataVencimento, string cvv) 
        {
            NumCartao = numCartao;
            NomeTitular = nomeTitular.ToUpper();
            DataVencimento = dataVencimento;
            CVV = cvv;
        }

        public string NumCartao { get; set; }
        public string NomeTitular { get; set; }
        public string DataVencimento { get; set; }
        public string CVV { get; set; }

        public void ProcessarPagamento() 
        {
            Console.WriteLine("Processando pagamento por cartão de crédito");
        }
    }
}
