using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace___ConsoleApp
{
    internal class Cliente
    {
        public Cliente(string nome, string cpf) 
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Cpf = cpf;
        }
        
        public Guid Id { get; private set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }

    }
}
