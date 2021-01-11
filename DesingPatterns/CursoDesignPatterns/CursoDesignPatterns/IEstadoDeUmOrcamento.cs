using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public interface IEstadoDeUmOrcamento
    {
        public bool DescontoAplicado { get; set; }
        public void AplicaDescontoExtra(Orcamento orcamento);
        public void Aprova(Orcamento orcamento);
        public void Reprova(Orcamento orcamento);
        public void Finaliza(Orcamento orcamento);
    }
}
