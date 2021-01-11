using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento.ChainOFResponsibility
{
    public class RespondePorcento : IRespota
    {
        public RespondePorcento(IRespota proximo)
        {
            Proximo = proximo;
        }

        public IRespota Proximo { get; set; }

        public string Responde(ContaBancaria contaBancaria, Formato formato)
        {
            if (formato == Formato.PORCENTO)
                return contaBancaria.Saldo + "%" + contaBancaria.Nome;

            return Proximo.Responde(contaBancaria, formato);
        }
    }
}
