using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento
{
    public class RealizadorDeInvestimentos
    {
        public void RealizaInvestimento(ContaBancaria conta, Investimento investimento)
        {
            Console.WriteLine("Saldo da conta antes do investimento: " + conta.Saldo);

            var resgateInvestimento = investimento.Investir(conta) * 0.75; //apenas 75%

            conta.Depositar(resgateInvestimento);

            Console.WriteLine("Valor do resgate: " + resgateInvestimento);

            Console.WriteLine("Saldo da conta depois do investimento: " + conta.Saldo);
        }
    }
}
