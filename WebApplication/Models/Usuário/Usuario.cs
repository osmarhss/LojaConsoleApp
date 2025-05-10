using System.Text.RegularExpressions;
using WebApplication.Enums;

namespace WebApplication.Models.Usuário
{
    public class Usuario
    {
        public Usuario(string id, string email, string senha, int tipoUsuario)
        {
            Id = string.IsNullOrWhiteSpace(id) ? Guid.NewGuid().ToString("D") : id;
            Email = email;
            Senha = senha;
            TipoUsuario = (TipoUsuario)tipoUsuario;
        }
        public string Id { get; private set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoUsuario TipoUsuario { get; private set; }

    }
}
