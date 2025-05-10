using WebApplication.Models.Produtos;
using WebApplication.Models.Clientes;
using WebApplication.Models.Empresa;
using WebApplication.Enums;
using WebApplication.Models.SharedValues;

namespace WebApplication.Models.Pedidos
{
    public class Pedido
    {
        public Pedido(string id, decimal frete, decimal precoTotal, DateTime horarioCompra, DadosGeograficos enderecoEntrega, string vendedorId, string clienteId, IEnumerable<PedidoProduto> produtoscomprados)
        {
            Id = string.IsNullOrWhiteSpace(id) ? Guid.NewGuid().ToString("D") : id;
            Frete = frete;
            PrecoTotal = precoTotal;
            HorarioCompra = horarioCompra;
            StatusPedido = StatusPedido.EmProcessamento;
            EnderecoEntrega = enderecoEntrega;
            VendedorId = vendedorId;
            ClienteId = clienteId;
            ProdutosComprados = new List<PedidoProduto>() {};
        }

        public string Id { get; private set; }
        public decimal Frete { get; private set; }
        public decimal PrecoTotal { get; private set; }
        public DateTime HorarioCompra { get; private set; }
        public StatusPedido StatusPedido { get; private set; }
        public DadosGeograficos EnderecoEntrega { get; private set; }

        public string VendedorId { get; private set; }
        public Vendedor? Vendedor { get; private set; }

        public string ClienteId { get; private set; }
        public Cliente? Cliente { get; private set; }

        public IEnumerable<PedidoProduto> ProdutosComprados { get; set; }
    }
}
