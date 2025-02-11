using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Marketplace___ConsoleApp.MétodosDePagamento;
using Marketplace___ConsoleApp.Produtos;
using Marketplace___ConsoleApp.Usuários;

namespace Marketplace___ConsoleApp.Pedidos
{
    public class Pedido
    {
        public Pedido(string id, Produto produto, IProcessarPagamento meioDePagamento) 
        {
            Id = id;
            Produto = produto;
            MeioDePagamento = meioDePagamento;
        }
        public string Id { get; set; }
        public Produto Produto { get; set; }
        public IProcessarPagamento MeioDePagamento { get; set; }

        public void ProcessarPedido(Cliente c) 
        {
            MeioDePagamento.ProcessarPagamento(Produto.Preco);
            c.MeusPedidos.Add(this);
        }
        public override string ToString()
        {
            return $"Meu pedido: \b Id: {Id} \b Produto: {Produto.Nome} \b Meio de Pagamento: {MeioDePagamento.NomePagamento}";
        }

    }
}
