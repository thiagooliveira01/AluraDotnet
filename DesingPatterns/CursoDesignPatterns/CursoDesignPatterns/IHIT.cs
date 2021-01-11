using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursoDesignPatterns
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public IHIT(Imposto outroImposto) : base(outroImposto)
        {
        }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return doisItensComMesmoNome(orcamento);
        }

        private bool doisItensComMesmoNome(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 1)
            {
                List<Item> filtro;
                foreach (Item item in orcamento.Itens)
                {
                    filtro = orcamento.Itens.Where(x => x.Nome.Equals(item.Nome)).ToList();
                    if (filtro.Count > 1)
                        return true;
                }
            }
            return false;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Itens.Count * 0.01;
        }
    }
}
