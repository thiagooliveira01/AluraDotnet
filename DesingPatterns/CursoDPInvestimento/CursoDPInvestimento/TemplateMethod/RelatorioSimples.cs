using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento.TemplateMethod
{
    public class RelatorioSimples : TemplateRelatorio
    {
        protected override string Cabecalho(Banco banco)
        {
            return "Banco: "+ banco.Nome + " - " + banco.Telefone;
        }

        protected override string Corpo(ContaBancaria conta)
        {
            return "Conta: " + conta.Nome + " - " + conta.Saldo;
        }

        protected override string Rodape(Banco banco)
        {
            return "Banco: " + banco.Nome + " - " + banco.Telefone;
        }
    }
}
