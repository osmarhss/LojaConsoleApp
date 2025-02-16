using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace___ConsoleApp.Usuários
{
    public class ClienteReduzido
    {
        public string Nome { get; set;}
        public string CPF { get; set; }
        public DadosContato DadosContato { get; set; }
        public DadosGeograficos DadosGeograficos { get; set; }
    }
}
