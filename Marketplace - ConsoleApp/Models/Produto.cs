using Marketplace___ConsoleApp.Produtos;
using Marketplace___ConsoleApp.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace___ConsoleApp.Models
{
    public class Produto
    {
        public Produto(string id, string fabricante, string nome, CategoriasProduto categoria, int estoque, decimal preco, bool emPromocao = false, bool emPreVenda = false)
        {
            Id = id;
            Fabricante = fabricante;
            Nome = nome;
            Categoria = categoria;
            Estoque = estoque;
            Preco = preco;
            HistoricoDePrecos = new List<decimal>() { preco };
            Condicoes = new ProdutoCondicaoEspecial() { EmPreVenda = emPreVenda, EmPromocao = emPromocao};
        }

        public string Id { get; private set; }
        public string Fabricante { get; set; }
        public string Nome { get; set; }
        public CategoriasProduto Categoria { get; set; }
        public int Estoque { get; set; }
        public decimal Preco { get; set; }
        public List<decimal> HistoricoDePrecos { get; set; }
        public ProdutoCondicaoEspecial Condicoes { get; set; }
        public EventHandler<GerarNotificacoesEventArgs<Produto>> NotificarCondicaoEspecialProduto { get; set; }

        public void ProdutoEmPromocao(IEnumerable<Cliente> cs, DateTime dataPromo, decimal preco) 
        {
            if (Condicoes.HistoricoDePromocoes == null)
                Condicoes.HistoricoDePromocoes = new List<DateTime>();

            if (Condicoes.EmPromocao)
            {
                Console.WriteLine("Produto já está em promoção!");
            }
            else
            {
                Condicoes.HistoricoDePromocoes.Add(dataPromo);
                Condicoes.EmPromocao = true;
                Preco = preco;

                if (NotificarCondicaoEspecialProduto != null)
                {
                    NotificarCondicaoEspecialProduto(this, new GerarNotificacoesEventArgs<Produto>() { Clientes = new List<Cliente>(cs), Value = this });
                }
            }
        }

        //Simulando fonte de dados obtidos por um banco de dados
        public static List<Produto> GetProdutos()
        {
            var listaProdutos = new List<Produto>()
            {
                new Produto("1", "AMD", "Ryzen 5 9600", CategoriasProduto.Processador, 50, 999.90m),
                new Produto("2", "INTEL", "Core i5 14400f", CategoriasProduto.Processador, 100, 959.90m),
                new Produto("3", "MSI", "Mortar B650M", CategoriasProduto.PlacaMae, 40, 769.90m),
                new Produto("4", "ASUS", "TUF B660M", CategoriasProduto.PlacaMae, 80, 759.90m),
                new Produto("5", "NVIDIA", "RTX 5080", CategoriasProduto.PlacaDeVideo, 100, 11990.90m),
                new Produto("6", "AMD", "Radeon 9070", CategoriasProduto.PlacaDeVideo, 100, 6990.90m),
                new Produto("7", "HYPERX", "Fury 16GB DDR5", CategoriasProduto.MemoriaRAM, 150, 399.90m),
                new Produto("8", "CORSAIR", "Vengeance 16GB DDR5", CategoriasProduto.MemoriaRAM, 150, 439.90m),
                new Produto("9", "KINGSTON", "M.2 NV2 1TB", CategoriasProduto.Armazenamento, 140, 339.90m),
                new Produto("10", "SAMSUNG", "M.2 990 Evo 1TB", CategoriasProduto.Armazenamento, 110, 839.90m),
                new Produto("11", "CORSAIR", "CX750 750W", CategoriasProduto.Fonte, 110, 839.90m),
                new Produto("12", "MSI", "MAG A650N 650W", CategoriasProduto.Fonte, 125, 365.90m),
            };
            return listaProdutos;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\r\n Fabricante: {Fabricante}\r\n Tipo: {Categoria}\r\n Preco: {Preco}";
        }

    }

    public class ProdutoCondicaoEspecial 
    {
        public bool EmPromocao { get; set; }
        public List<DateTime>? HistoricoDePromocoes { get; set; }
        public bool EmPreVenda { get; set; }
    }
}
