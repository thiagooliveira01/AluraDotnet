using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap4
{
    public class Subtracao : IExpressao
    {

        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeSubtracao(this);
        }

        public int Avalia()
        {
            int resultadoDaEsquerda = Esquerda.Avalia();
            int resultadoDaDireita = Direita.Avalia();
            return resultadoDaEsquerda - resultadoDaDireita;
        }
    }
}
