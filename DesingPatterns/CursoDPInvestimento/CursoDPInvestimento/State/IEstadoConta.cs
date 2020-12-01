using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento.State
{
    public interface IEstadoConta
    {
        public void Sacar(ContaBancaria conta, double valor);
        public void Depositar(ContaBancaria conta, double valor);
    }
}
