using Marketplace___ConsoleApp.Pedidos;
using Marketplace___ConsoleApp.Produtos;
using Marketplace___ConsoleApp.Usuários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace___ConsoleApp.Notificações
{
    public class GerarNotificacoes<T>
    {
        public void PorEmail(object? sender, GerarNotificacoesEventArgs<T> e)
        {
            Console.WriteLine($"Enviando para: {e.Cliente!.DadosParaContato.Email}");
            Console.WriteLine($"Olá, {e.Cliente.Nome}!");

            if (e.Value is Pedido pedido)
            {
                if (pedido.Status == StatusPedido.PagamentoAceito)
                {
                    Console.WriteLine("O pagamento do seu pedido foi aprovado");
                }
                else 
                {
                    Console.WriteLine("O pagamento do seu pedido foi recusado");
                }

                Console.WriteLine($"\t Dados do pedido: \t");
                Console.WriteLine(pedido.ToString());
            }
            
            if (e.Value is Produto produto) 
            {
                if(produto.Condicoes.EmPreVenda)
                    Console.WriteLine($"O produto: {produto.Fabricante} {produto.Nome} entrou em pré-venda!");

                if (e.Clientes != null)
                {
                    var clientesInteressados = e.Clientes.Where(p => p.ListaDeDesejos.Contains(produto));
                    // Simular algo que enviasse apenas para os clientes na coleção criada
                    Console.WriteLine("Um produto da sua lista de desejos entrou em promoção!");
                }
            }
        }
    }

    public class GerarNotificacoesEventArgs<T> : EventArgs 
    {
        public Cliente? Cliente { get; set; }
        public List<Cliente>? Clientes { get; set; }
        public T? Value { get; set; }
    }
}
