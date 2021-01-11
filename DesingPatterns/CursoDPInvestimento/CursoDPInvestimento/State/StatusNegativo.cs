using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento.State
{
    public class StatusNegativo : IEstadoConta
    {
        public void Depositar(ContaBancaria conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0) conta.EstadoAtual = new StatusPositivo();
        }

        public void Sacar(ContaBancaria conta, double valor)
        {
            throw new Exception("Saldo da conta está negativo");
        }
    }
}
