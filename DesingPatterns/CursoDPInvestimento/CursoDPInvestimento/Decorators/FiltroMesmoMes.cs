using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento.Decorators
{
    public class FiltroMesmoMes : Filtro
    {
        public FiltroMesmoMes() : base() { }

        public FiltroMesmoMes(Filtro outroFiltro) : base(outroFiltro) { }

        public override IList<ContaBancaria> Filtra(IList<ContaBancaria> contas)
        {
            IList<ContaBancaria> filtrada = new List<ContaBancaria>();

            foreach (ContaBancaria c in contas)
            {
                if (c.DataAbertura.Month == DateTime.Now.Month && c.DataAbertura.Year == DateTime.Now.Year)
                {
                    filtrada.Add(c);
                }
            }

            foreach (ContaBancaria c in ProximoFiltro(contas))
            {
                filtrada.Add(c);
            }

            return filtrada;
        }
    }
}
