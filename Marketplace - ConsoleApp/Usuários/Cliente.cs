using Marketplace___ConsoleApp.MétodosDePagamento;
using Marketplace___ConsoleApp.Produtos;
using Marketplace___ConsoleApp.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Marketplace___ConsoleApp.Usuários
{
    public class Cliente
    {
        public Cliente(string id, string nome, string cpf, string email, string telefone, string logradouro, string numeroPropriedade, string complemento, string cidade, string estado, string pais)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            DadosParaContato = new DadosContato(email, telefone);
            DadosGeograficos = new DadosGeograficos(logradouro, numeroPropriedade, complemento, cidade, estado, pais);
            DadosFinanceiros = new DadosFinanceiros() { MeusCartoes = new List<CartaoCreditoPay>() };
            ListaDeDesejos = new List<Produto>();
            MeusPedidos = new List<Pedido>();
        }

        public string Id { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DadosContato DadosParaContato { get; set; }
        public DadosGeograficos DadosGeograficos { get; set; }
        public DadosFinanceiros DadosFinanceiros { get; set; }
        public List<Produto> ListaDeDesejos { get; set; }
        public List<Pedido> MeusPedidos { get; set; }

    }

    public class DadosContato
    {
        public DadosContato(string email, string telefone)
        {
            Email = email;
            Telefone = telefone;
        }

        public string Email { get; set; }
        public string Telefone { get; set; }
        public string? X { get; set; }
        public string? Meta { get; set; }
    }

    public class DadosGeograficos
    {
        public DadosGeograficos(string logradouro, string numeroPropriedade, string? complemento, string cidade, string estado, string pais)
        {
            Logradouro = logradouro;
            NumeroPropriedade = numeroPropriedade;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
        }

        public string Logradouro { get; set; }
        public string NumeroPropriedade { get; set; }
        public string? Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }

    public class DadosFinanceiros 
    {
        public string? ChavePixReembolso { get; set; }
        public List<CartaoCreditoPay>? MeusCartoes { get; set; }
    }

    public static class ClienteExtensions 
    {
        public static ClienteReduzido ToClienteReduzido(this Cliente c) => 
            new ClienteReduzido()
            {
                Nome = c.Nome,
                CPF = c.Cpf,
                DadosContato = c.DadosParaContato,
                DadosGeograficos = c.DadosGeograficos
            };
    }
}
