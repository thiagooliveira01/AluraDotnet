using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        protected TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto)
        {
        }
        protected TemplateDeImpostoCondicional() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
                return MaximaTaxacao(orcamento);
            else
                return MinimaTaxacao(orcamento);

        }

        protected abstract double MinimaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
    }
}
