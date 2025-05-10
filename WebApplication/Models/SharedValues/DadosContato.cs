namespace WebApplication.Models.SharedValues
{
    public class DadosContato
    {
        public DadosContato(string email, string telefone)
        {
            Email = email;
            Telefone = telefone;
        }

        protected string Email { get; set; }
        protected string? Telefone { get; set; }
    }
}
