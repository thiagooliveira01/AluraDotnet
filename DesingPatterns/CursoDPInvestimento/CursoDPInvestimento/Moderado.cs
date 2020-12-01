using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento
{
    public class Moderado : Investimento
    {
        public double Investir(ContaBancaria conta)
        {
            Random random = new Random();
            if (random.Next(2) == 0)
                return conta.Saldo * 0.025;
            else
                return conta.Saldo * 0.007;
        }
    }
}
