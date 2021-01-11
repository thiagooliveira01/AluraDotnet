﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV(Imposto outroImposto) : base(outroImposto) {  }
        public IKCV() : base() { }
    
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temItemMaiorQue100ReaisNo(orcamento);
        }


        protected override double MinimaTaxacao(Orcamento orcamento) 
        {
            return orcamento.Valor * 0.1;
        }
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }


        private bool temItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }
            return false;
        }
    }
}
