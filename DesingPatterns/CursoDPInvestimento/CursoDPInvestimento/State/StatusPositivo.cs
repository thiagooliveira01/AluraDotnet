using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento.State
{
    public class StatusPositivo : IEstadoConta
    {
        public void Depositar(ContaBancaria conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

        public void Sacar(ContaBancaria conta, double valor)
        {
            conta.Saldo -= valor;
            if (conta.Saldo < 0) conta.EstadoAtual = new StatusNegativo();
        }
    }
}
