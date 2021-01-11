using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento
{
    public interface Investimento
    {
        public double Investir(ContaBancaria conta);
    }
}
