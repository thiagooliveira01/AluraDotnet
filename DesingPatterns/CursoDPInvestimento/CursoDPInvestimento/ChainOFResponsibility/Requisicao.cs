using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento.ChainOFResponsibility
{
    public enum Formato
    {
        XML,
        CSV,
        PORCENTO
    }

    public class Requisicao
    {
        public Formato Formato { get; private set; }

        public Requisicao(Formato formato)
        {
            Formato = formato;
        }
    }
}
