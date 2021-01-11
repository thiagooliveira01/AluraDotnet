using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento.ChainOFResponsibility
{
    public class ProcessadorResposta
    {
        public string Responde(ContaBancaria contaBancaria, Requisicao req)
        {
            var r1 = new RespondeCSV();
            var r2 = new RespondePorcento(r1);
            var r3 = new RespondeXML(r2);

            return r3.Responde(contaBancaria, req.Formato);
        }
    }
}
