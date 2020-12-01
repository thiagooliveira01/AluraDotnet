using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class Aprovado : IEstadoDeUmOrcamento
    {

        public bool DescontoAplicado { get; set; } = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!DescontoAplicado)
            {
                orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.02);
                DescontoAplicado = true;
            }
            else
                throw new Exception("Desconto já aplicado");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja esta aprovado, não pode ser reprovado");
        }
    }
}
