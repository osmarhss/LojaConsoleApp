using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace___ConsoleApp.Models
{
    public enum StatusPedido
    {
        EmProcessamento = 1,
        PagamentoAceito,
        PagamentoRecusado,
        EmTrânsito,
        Concluída,
        Cancelada,
        Reembolsada
    }
}
