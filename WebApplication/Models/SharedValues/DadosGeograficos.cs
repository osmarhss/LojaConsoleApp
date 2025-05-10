namespace WebApplication.Models.SharedValues
{
    public class DadosGeograficos
    {
        public DadosGeograficos(string logradouro, string bairro, string cidade, string uF)
        {
            Id = Guid.NewGuid().ToString("D");
            Logradouro = logradouro;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
        }

        protected string Id { get; private set; }
        protected string Logradouro { get; set; }
        protected string Bairro { get; set; }
        protected string Cidade { get; set; }
        protected string UF { get; set; }

    }
}
