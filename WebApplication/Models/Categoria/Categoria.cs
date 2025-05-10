using WebApplication.Models.Produtos;

namespace WebApplication.Models.Categorias
{
    public class Categoria
    {
        public Categoria(string id, string nome, string imagemUrl, ICollection<Produto> produtos)
        {
            Id = string.IsNullOrWhiteSpace(id) ? Guid.NewGuid().ToString("D") : id;
            Nome = nome;
            ImagemUrl = imagemUrl;
            Produtos = produtos;
        }

        public string Id { get; private set; }
        public string Nome { get; set; }
        public string ImagemUrl { get; set; }
        public ICollection<Produto>? Produtos { get; set; }

    }
}
