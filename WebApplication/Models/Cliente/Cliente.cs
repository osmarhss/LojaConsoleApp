using WebApplication.Models.MeiosDePagamento;
using WebApplication.Models.Pedidos;
using WebApplication.Models.SharedValues;
using WebApplication.Models.Usuário;

namespace WebApplication.Models.Clientes
{
    public class Cliente
    {
        public Cliente(string id, string nome, string cpf, string usuarioId, DadosContato dadosContato) 
        {
            Id = string.IsNullOrWhiteSpace(id) ? Guid.NewGuid().ToString("D") : id;
            Nome = nome;
            Cpf = cpf;
            UsuarioId = usuarioId;
            DadosContato = dadosContato;
        }

        public string Id { get; private set; }
        public string Nome { get; private set; }
        public string? Cpf { get; private set; }
        public string UsuarioId { get; private set; }
        public Usuario? Usuario { get; private set; }
        public DadosContato DadosContato { get; private set; }
        public IEnumerable<DadosGeograficos>? MeusEnderecosDeEntrega { get; private set; } = null;
        public IEnumerable<IMetodosPagamento>? MeusMeiosDePagamento { get; private set; }
        public IEnumerable<Pedido>? MeusPedidos { get; private set; }

        public void SalvarCartao(CartaoDeCredito c) 
        {
            if (MeusMeiosDePagamento is null)
                MeusMeiosDePagamento = new List<IMetodosPagamento>();

            MeusMeiosDePagamento = MeusMeiosDePagamento.Append(c);
        }
    }
}
