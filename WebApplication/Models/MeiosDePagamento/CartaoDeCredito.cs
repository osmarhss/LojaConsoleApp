
using WebApplication.Models.Clientes;
using WebApplication.Models.Usuário;

namespace WebApplication.Models.MeiosDePagamento
{
    public class CartaoDeCredito : IMetodosPagamento
    {
        public CartaoDeCredito(string id, string numeroDoCartao, string nomeTitular, string dataVencimento, string cvv, string clienteId)
        {
            Id = string.IsNullOrWhiteSpace(id) ? Guid.NewGuid().ToString("D") : id;
            NumeroDoCartao = numeroDoCartao;
            NomeTitular = nomeTitular;
            DataVencimento = dataVencimento;
            CVV = cvv;
            ClienteId = clienteId;
        }

        public string Nome => "Cartão de Crédito";
        public string Id { get; private set; }
        public string NumeroDoCartao { get; private set; }
        public string NomeTitular { get; private set; }
        public string DataVencimento { get; private set; }
        public string CVV { get; private set; }
        public string ClienteId { get; private set; }
        public Cliente? Cliente { get; private set; }

        public bool ProcessarPagamento(decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}
