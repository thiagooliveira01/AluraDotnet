using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento.TemplateMethod
{
    public class RelatorioComplexos : TemplateRelatorio
    {
        protected override string Cabecalho(Banco banco)
        {
            return "Banco: " + banco.Nome + " - " + banco.Endereco + " - " + banco.Telefone;
        }

        protected override string Corpo(ContaBancaria conta)
        {
            return "Conta: " + conta.Nome + " - " + conta.Agencia + " - " + conta.Numero + " - " + conta.Saldo;
        }

        protected override string Rodape(Banco banco)
        {
            return banco.Email + " - " + DateTime.Now.ToShortDateString();
        }
    }
}
