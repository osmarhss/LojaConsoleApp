using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Marketplace___ConsoleApp.MétodosDePagamento;
using Marketplace___ConsoleApp.Notificações;
using Marketplace___ConsoleApp.Produtos;
using Marketplace___ConsoleApp.Usuários;

namespace Marketplace___ConsoleApp.Pedidos
{
    public class Pedido
    {
        public Pedido(string id, decimal frete, Produto produto, IProcessarPagamento meioDePagamento, ClienteReduzido comprador)
        {
            Id = id;
            Frete = frete;
            ValorTotal = produto.Preco + frete;
            Status = StatusPedido.EmProcessamento;
            Produto = produto;
            MeioDePagamento = meioDePagamento;
            PedidoTime = new StatusPedidoData(DateTime.Now);
            Comprador = comprador;
        }

        public string Id { get; private set; }
        public decimal Frete { get; set; }
        public decimal ValorTotal { get; set; }
        public StatusPedido Status { get; set; }
        public Produto Produto { get; set; }
        public IProcessarPagamento MeioDePagamento { get; set; }
        public StatusPedidoData PedidoTime { get; set; }
        public EventHandler<GerarNotificacoesEventArgs<Pedido>>? NotificarAoCriarPedido { get; set; }
        public ClienteReduzido Comprador { get; set; }

        public string ProcessarPedido(Cliente c) 
        {
            string response;
            Produto.Estoque -= 1;
            c.MeusPedidos.Add(this);

            if (MeioDePagamento.ProcessarPagamento(Produto.Preco))
            {
                Status = StatusPedido.PagamentoAceito;
                response = "Pedido efetuado com sucesso";
            }
            else 
            {
                Status = StatusPedido.PagamentoRecusado;
                response = "Pedido recusado, o pagamento não foi processado";
            }
            
            if (NotificarAoCriarPedido != null)           
                NotificarAoCriarPedido(this, new GerarNotificacoesEventArgs<Pedido>() { Cliente = c, Value = this });
           
            return response;

        }
        public string PedidoEmTransito(Cliente c) 
        {
            Status = StatusPedido.EmTrânsito;
            return $"Encaminhado para {c.DadosGeograficos.Logradouro}, {c.DadosGeograficos.NumeroPropriedade}, {c.DadosGeograficos.Complemento ?? ""} - {c.DadosGeograficos.Estado}, {c.DadosGeograficos.Pais}.";
        }
        public string CancelarPedidoPorUsuario(Cliente c) 
        {
            string res;
            PedidoTime.SolicitacaoCancelamentoPedido = DateTime.Now;

            if (Status == StatusPedido.EmTrânsito)
            {
                Status = StatusPedido.Cancelada;
                Produto.Estoque += 1;
                PedidoTime.PedidoCancelado = DateTime.Now;

                if (c.DadosFinanceiros.ChavePixReembolso != null)
                {
                    res = $"Realizando a transferência de: {Produto.Preco} para a chave Pix: {c.DadosFinanceiros.ChavePixReembolso}";
                    Status = StatusPedido.Reembolsada;
                }
                else
                {
                    res = "Informe uma chave Pix para o reemobolso ser efetuado.";
                }
            }
            else 
            {
                res = "O pedido não pôde ser cancelado";
            }

            return res;
        }

        public string GerarComprovanteTXT(Cliente c) 
        {
            string downloadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            try
            {
                File.WriteAllText(downloadPath + $"comprovante{Id}.txt", $"Comprovante de pagamento: {Environment.NewLine + c.ToString() + Environment.NewLine + this.ToString()}");
                return "Comprovante salvo com sucesso!";
            }
            catch (Exception e) 
            {
                return e.Message;
            }
        }
        public override string ToString()
        {
            return $"Meu pedido: \n Id: {Id} \r\n Produto: {Produto.Nome} \n Meio de Pagamento: {MeioDePagamento.NomePagamento}";
        }

    }

    public class StatusPedidoData 
    {
        public StatusPedidoData(DateTime pedidoCriado)
        {
            PedidoCriado = pedidoCriado;
        }

        public DateTime PedidoCriado { get; set; }
        public DateTime? SolicitacaoCancelamentoPedido { get; set; }
        public DateTime? PedidoCancelado { get; set; }
    }
}
