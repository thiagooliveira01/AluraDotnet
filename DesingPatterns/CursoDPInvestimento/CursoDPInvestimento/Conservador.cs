using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento
{
    public class Conservador : Investimento
    {
        public double Investir(ContaBancaria conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
