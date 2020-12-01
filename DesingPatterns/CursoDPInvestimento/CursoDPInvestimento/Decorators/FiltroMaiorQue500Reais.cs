using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento.Decorators
{
    public class FiltroMaiorQue500Reais : Filtro
    {
        public FiltroMaiorQue500Reais() : base() { }

        public FiltroMaiorQue500Reais(Filtro outroFiltro) : base(outroFiltro) { }

        public override IList<ContaBancaria> Filtra(IList<ContaBancaria> contas)
        {
            IList<ContaBancaria> filtrada = new List<ContaBancaria>();

            foreach (ContaBancaria c in contas)
            {
                if (c.Saldo > 500) filtrada.Add(c);
            }
            foreach (ContaBancaria c in ProximoFiltro(contas))
            {
                filtrada.Add(c);
            }
            return filtrada;
        }
    }
}
