using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public interface IDesconto
    {
        public double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
