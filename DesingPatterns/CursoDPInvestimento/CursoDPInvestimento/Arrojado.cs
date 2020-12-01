using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento
{
    public class Arrojado : Investimento
    {
        public double Investir(ContaBancaria conta)
        {
            Random random = new Random();

            var perc = random.Next(101);

            if (perc > 50)
                return conta.Saldo * 0.006;
            else if (perc > 20)
                return conta.Saldo * 0.03;
            else
                return conta.Saldo * 0.05;
        }
    }
}
