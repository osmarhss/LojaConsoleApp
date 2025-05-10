namespace WebApplication.Models.Produtos
{
    public class HistoricoPreco
    {
        public HistoricoPreco(string id, decimal preco, DateTime data, string produtoId)
        {
            Id = string.IsNullOrWhiteSpace(id) ? Guid.NewGuid().ToString("D") : id;
            Preco = preco;
            Data = data;
            ProdutoId = produtoId;
        }

        public string Id { get; private set; }
        public decimal Preco { get; private set; }
        public DateTime Data { get; private set; }
        public string ProdutoId { get; private set; }
        public Produto? Produto { get; private set; }

    }
}
