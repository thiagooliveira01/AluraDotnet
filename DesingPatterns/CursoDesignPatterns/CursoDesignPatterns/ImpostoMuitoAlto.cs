using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto()
        {
        }

        public ImpostoMuitoAlto(Imposto outroImposto) : base(outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.20);
        }
    }
}
