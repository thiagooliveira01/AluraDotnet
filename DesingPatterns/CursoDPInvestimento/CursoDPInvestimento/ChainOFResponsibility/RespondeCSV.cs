using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento.ChainOFResponsibility
{
    public class RespondeCSV : IRespota
    {
        public RespondeCSV()
        {
        }

        public RespondeCSV(IRespota proximo)
        {
            Proximo = proximo;
        }

        public IRespota Proximo { get; set; }

        public string Responde(ContaBancaria contaBancaria, Formato formato)
        {
            if (formato == Formato.CSV)
                return contaBancaria.Saldo + ";" + contaBancaria.Nome;

            return Proximo.Responde(contaBancaria, formato);
        }
    }
}
