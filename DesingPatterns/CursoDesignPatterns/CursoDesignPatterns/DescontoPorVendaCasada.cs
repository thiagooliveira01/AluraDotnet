using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (Existe("LAPIS", orcamento) && Existe("CANETA", orcamento))
            {
                return orcamento.Valor * 0.05;
            }

            if (Proximo != null)
                return Proximo.Desconta(orcamento);
            else
                return 0;
        }

        private bool Existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }
}
