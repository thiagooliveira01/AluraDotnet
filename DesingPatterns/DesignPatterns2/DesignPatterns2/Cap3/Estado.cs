using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap3
{
    public class Estado
    {
        public Contrato Contrato { get; private set; }

        public Estado(Contrato contrato)
        {
            Contrato = contrato;
        }
    }
}
