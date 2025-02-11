﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace___ConsoleApp.Produtos
{
    public class Produto
    {
        public Produto(string id, string fabricante, string nome, CategoriasProduto categoria, int estoque, decimal preco)
        {
            Id = id;
            Fabricante = fabricante;
            Nome = nome;
            Categoria = categoria;
            Estoque = estoque;
            Preco = preco;
        }

        public string Id { get; set; }
        public string Fabricante { get; set; }
        public string Nome { get; set; }
        public CategoriasProduto Categoria { get; set; }
        public int Estoque { get; set; }
        public decimal Preco { get; set; }

        //Simulando fonte de dados obtidos por um banco de dados
        public static List<Produto> GetProdutos()
        {
            var listaProdutos = new List<Produto>()
            {
                new Produto("1", "AMD", "Ryzen 5 9600", CategoriasProduto.Processador, 50, 999.90m),
                new Produto("2", "Intel", "Core i5 14400f", CategoriasProduto.Processador, 100, 959.90m),
                new Produto("3", "MSI", "Mortar B650M", CategoriasProduto.PlacaMae, 40, 769.90m),
                new Produto("4", "Asus", "TUF B660M", CategoriasProduto.PlacaMae, 80, 759.90m),
                new Produto("5", "Nvidia", "RTX 5080", CategoriasProduto.PlacaDeVideo, 100, 11990.90m),
                new Produto("6", "AMD", "Radeon 9070", CategoriasProduto.PlacaDeVideo, 100, 6990.90m),
                new Produto("7", "HyperX", "Fury 16GB DDR5", CategoriasProduto.MemoriaRAM, 150, 399.90m),
                new Produto("8", "Corsair", "Vengeance 16GB DDR5", CategoriasProduto.MemoriaRAM, 150, 439.90m),
                new Produto("9", "Kingston", "M.2 NV2 1TB", CategoriasProduto.Armazenamento, 140, 339.90m),
                new Produto("10", "Samsung", "M.2 990 Evo 1TB", CategoriasProduto.Armazenamento, 110, 839.90m),
                new Produto("11", "Corsair", "CX750 750W", CategoriasProduto.Fonte, 110, 839.90m),
                new Produto("12", "MSI", "MAG A650N 650W", CategoriasProduto.Fonte, 125, 365.90m),
            };
            return listaProdutos;
        } 

        

    }
}
