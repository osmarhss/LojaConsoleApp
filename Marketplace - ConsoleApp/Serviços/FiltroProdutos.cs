using Marketplace___ConsoleApp.Models;
using Marketplace___ConsoleApp.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace___ConsoleApp.Serviços
{
    public class FiltroProdutos
    {
        public static IEnumerable<Produto> ObterPrecoFiltrado(List<Produto> p, decimal[] preco) 
        {
            var lista = p.Where(p => p.Preco >= preco[0] && p.Preco <= preco[1]);
            return lista;
        }
        public static IEnumerable<Produto> ObterMarcaFiltrada(List<Produto> p, string fabricante)
        {
            var lista = p.Where(p => p.Fabricante.Contains(fabricante.ToUpper()));
            return lista;
        }
        public static IEnumerable<Produto> ObterPeloNome(List<Produto> p, string nome) 
        {
            var lista = p.Where(p => p.Nome.Contains(nome));
            return lista;
        }
        public static IEnumerable<Produto> ObterPelaCategoria(List<Produto> p, CategoriasProduto c) 
        {
            var lista = p.Where(p => p.Categoria.Equals(c));
            return lista;
        }
    }
}
