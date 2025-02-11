﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace___ConsoleApp.MétodosDePagamento
{
    public interface IProcessarPagamento
    {
        public string NomePagamento { get; }
        public void ProcessarPagamento(decimal valor);
    }
}
