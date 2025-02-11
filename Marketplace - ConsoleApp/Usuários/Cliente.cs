using Marketplace___ConsoleApp.MétodosDePagamento;
using Marketplace___ConsoleApp.Produtos;
using Marketplace___ConsoleApp.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace___ConsoleApp.Usuários
{
    public class Cliente
    {
        public Cliente(string id, string nome, string cpf)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            MeusCartoes = new List<CartaoCreditoPay>();
            ListaDeDesejos = new List<Produto>();
            MeusPedidos = new List<Pedido>();
        }

        public string? Id { get; private set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public List<CartaoCreditoPay> MeusCartoes { get; set; }
        public List<Produto> ListaDeDesejos { get; set; }
        public List<Pedido> MeusPedidos { get; set; }

    }
}
