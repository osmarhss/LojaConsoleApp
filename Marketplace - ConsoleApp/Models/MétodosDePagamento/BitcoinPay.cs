using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace___ConsoleApp.Models.MétodosDePagamento
{
    internal class BitcoinPay : IProcessarPagamento
    {
        public string NomePagamento => "Bitcoin";
        public static string EnderecoOnChain = "jf298A3b5ueH938hNj03jG19dh2";
        public static string EnderecoLightning = "iWHjui7yd7qfuqgh7TDYYghd2ajh3H1i75U2yiH";

        public bool ProcessarPagamento(decimal valor) 
        {
            if (valor < 500) 
            {
                Console.WriteLine($"Realize o pagamento para este endereço Lightning {EnderecoLightning} e pressione ENTER");
            }
            else
            {
                Console.WriteLine($"Realize o pagamento para este endereço OnChain {EnderecoOnChain} e pressione ENTER");
            }
            Console.ReadKey();
            Console.WriteLine($"Processando pagamento por Bitcoin no valor de: {valor}");
            return true;
        }
    }
}
