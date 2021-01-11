using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class EmAprovacao : IEstadoDeUmOrcamento
    {
        public bool DescontoAplicado { get; set; } = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!DescontoAplicado)
            {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
                DescontoAplicado = true;
            }
            else
                throw new Exception("Desconto já aplicado");
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento em aprovação não pode ir para finalizado direto");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
    }
}
