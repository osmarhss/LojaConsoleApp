using WebApplication.Models.MeiosDePagamento;
using WebApplication.Models.Usuário;

namespace WebApplication.Models.SharedValues
{
    public class MeusDadosPagamento
    {
        public string UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public Pix ChavePix { get; set; }
        public IEnumerable<CartaoDeCredito> MeusCartoes { get; set; }
    }
}
