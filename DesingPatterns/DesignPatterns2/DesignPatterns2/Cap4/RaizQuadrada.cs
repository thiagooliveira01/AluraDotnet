using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap4
{
    public class RaizQuadrada : IExpressao
    {
        private IExpressao expressao;

        public RaizQuadrada(IExpressao e)
        {
            this.expressao = e;
        }

        public void Aceita(IVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public int Avalia()
        {
            return (int)Math.Sqrt(expressao.Avalia());
        }
    }
}
