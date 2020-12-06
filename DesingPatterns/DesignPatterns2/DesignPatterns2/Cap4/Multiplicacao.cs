using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap4
{
    public class Multiplicacao : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public void Aceita(IVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public int Avalia()
        {
            int resultadoDaEsquerda = esquerda.Avalia();
            int resultadoDaDireita = direita.Avalia();
            return resultadoDaEsquerda * resultadoDaDireita;
        }
    }
}
