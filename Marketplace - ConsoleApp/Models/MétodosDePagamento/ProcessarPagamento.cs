using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace___ConsoleApp.Models.MétodosDePagamento
{
    public interface IProcessarPagamento
    {
        public string NomePagamento { get; }
        public bool ProcessarPagamento(decimal valor);
    }
}
