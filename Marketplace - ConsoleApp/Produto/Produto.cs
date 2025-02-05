using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace___ConsoleApp.Produto
{
    internal class Produto
    {

        public string Id { get; set; }
        public string Nome { get; set; }
        public CategoriasProduto Categoria { get; set; }
        public int Estoque { get; set; }



    }
}
