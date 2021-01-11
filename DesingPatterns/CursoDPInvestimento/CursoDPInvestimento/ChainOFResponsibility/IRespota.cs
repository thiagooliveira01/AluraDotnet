using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento.ChainOFResponsibility
{
    public interface IRespota
    {
        public string Responde(ContaBancaria contaBancaria, Formato formato);
        IRespota Proximo { get; set; }
    }
}
