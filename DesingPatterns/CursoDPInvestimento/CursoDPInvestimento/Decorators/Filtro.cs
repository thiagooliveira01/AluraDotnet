using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento.Decorators
{
    public abstract class Filtro
    {
        protected Filtro OutroFiltro { get; private set; }

        public Filtro()
        {
            OutroFiltro = null;
        }

        public Filtro(Filtro outroFiltro)
        {
            OutroFiltro = outroFiltro;
        }

        public abstract IList<ContaBancaria> Filtra(IList<ContaBancaria> contas);

        protected IList<ContaBancaria> ProximoFiltro(IList<ContaBancaria> contas)
        {
            if (OutroFiltro == null) return OutroFiltro.Filtra(contas);
            else return new List<ContaBancaria>();
        }

    }
}
