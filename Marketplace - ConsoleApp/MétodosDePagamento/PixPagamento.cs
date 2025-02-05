using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace___ConsoleApp.MétodosDePagamento
{
    public class PixPagamento : IProcessarPagamento
    {
        public static string ChavePix = "loja1@loja.com";

        public void ProcessarPagamento()
        {
            Console.WriteLine("Processando pagamento por Pix");
        }
    }
}
