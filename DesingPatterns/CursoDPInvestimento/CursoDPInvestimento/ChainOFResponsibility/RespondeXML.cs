using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento.ChainOFResponsibility
{
    public class RespondeXML : IRespota
    {
        public RespondeXML(IRespota proximo)
        {
            Proximo = proximo;
        }

        public IRespota Proximo { get; set; }

        public string Responde(ContaBancaria contaBancaria, Formato formato)
        {
            if (formato == Formato.XML)
              return "<saldo>"+contaBancaria.Saldo+ "</saldo>" + "<nome>"+contaBancaria.Nome+ "</nome>";

            return Proximo.Responde(contaBancaria, formato);
        }
    }
}
