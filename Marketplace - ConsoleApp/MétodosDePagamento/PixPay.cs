using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace___ConsoleApp.MétodosDePagamento
{
    public class PixPay : IProcessarPagamento
    {
        public string NomePagamento => "Pix";
        public static string ChavePix = "loja1@loja.com";

        public bool ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Processando pagamento por Pix no valor de: {valor}");
            return true;
        }
    }
}
