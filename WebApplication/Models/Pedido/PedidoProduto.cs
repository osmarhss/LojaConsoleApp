using WebApplication.Models.Produtos;

namespace WebApplication.Models.Pedidos
{
    public class PedidoProduto
    {
        public PedidoProduto(string id, string pedidoId, string produtoId, int quantidade)
        {
            Id = string.IsNullOrWhiteSpace(id) ? Guid.NewGuid().ToString("D") : id;
            PedidoId = pedidoId;
            ProdutoId = produtoId;
            Quantidade = quantidade;
        }

        public string Id { get; private set; }
        public string PedidoId { get; private set; }
        public Pedido? Pedido { get; private set; }
        public string ProdutoId { get; private set; }
        public Produto? Produto { get; private set; }
        public int Quantidade { get; set; }

    }
}
