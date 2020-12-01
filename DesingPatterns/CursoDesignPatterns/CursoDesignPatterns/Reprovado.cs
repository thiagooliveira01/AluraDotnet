using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class Reprovado : IEstadoDeUmOrcamento
    {
        public bool DescontoAplicado { get; set; } = false;

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta reprovado, não pode ser aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta rerpovado");
        }
    }
}
