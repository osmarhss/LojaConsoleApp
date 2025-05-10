using Marketplace___ConsoleApp.Usuários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace___ConsoleApp.Models.MétodosDePagamento
{
    public class CartaoCreditoPay : IProcessarPagamento
    {
        public CartaoCreditoPay(string numCartao, string nomeTitular, string dataVencimento, string cvv, string bandeira) 
        {
            NumCartao = numCartao;
            NomeTitular = nomeTitular.ToUpper();
            DataVencimento = dataVencimento;
            CVV = cvv;
            Bandeira = bandeira;
        }

        public string NomePagamento => "Cartão de Crédito";
        public string NumCartao { get; set; }
        public string NomeTitular { get; set; }
        public string DataVencimento { get; set; }
        public string CVV { get; set; }
        public string Bandeira { get; set; }

        public bool ProcessarPagamento(decimal valor) 
        {
            Console.WriteLine($"Processando pagamento por cartão de crédito {valor}");
            return true;
        }
        
    }
}
