using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap4
{
    public class Numero : IExpressao
    {
        public int Valor { get; private set; }
        private int numero;
        public Numero(int numero)
        {
            this.numero = numero;
            Valor = numero;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeNumero(this);
        }

        public int Avalia()
        {
            return numero;
        }
    }
}
