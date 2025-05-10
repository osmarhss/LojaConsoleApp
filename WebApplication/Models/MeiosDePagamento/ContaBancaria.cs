using WebApplication.Enums;
using WebApplication.Models.Empresa;
using WebApplication.Models.Usuário;

namespace WebApplication.Models.MeiosDePagamento
{
    public class ContaBancaria
    {
        public ContaBancaria(string id, string instituicaoBancaria, TipoContaBancaria tipoConta, string agencia, string numConta, string vendedorId)
        {
            Id = string.IsNullOrWhiteSpace(id) ? Guid.NewGuid().ToString("D") : id;
            InstituicaoBancaria = instituicaoBancaria;
            TipoConta = tipoConta;
            Agencia = agencia;
            NumConta = numConta;
            VendedorId = vendedorId;
        }

        public string Nome => "Conta Bancária";
        public string Id { get; private set; }
        public string InstituicaoBancaria { get; private set; }
        public TipoContaBancaria TipoConta { get; private set; }
        public string Agencia { get; private set; }
        public string NumConta { get; private set; }
        public string VendedorId { get; private set; }
        public Vendedor? Vendedor { get; private set; }

    }
}
