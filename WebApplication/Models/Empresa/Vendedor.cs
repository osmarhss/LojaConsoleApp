using WebApplication.Models.MeiosDePagamento;
using WebApplication.Models.Produtos;
using WebApplication.Models.Usuário;

namespace WebApplication.Models.Empresa
{
    public class Vendedor
    {
        public Vendedor(string id, string cnpj)
        {
            Id = string.IsNullOrWhiteSpace(id) ? Guid.NewGuid().ToString("D") : id;
            CNPJ = cnpj;
        }

        public string Id { get; private set; }
        public string CNPJ { get; private set; }
        public ContaBancaria? ContaBancaria { get; private set; }
        public ICollection<Produto>? MeusProdutos { get; private set; }
    }
}
