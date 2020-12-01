using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public ICPP(Imposto outroImposto) : base(outroImposto) { }

        public ICPP() : base() { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor >= 500);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
