﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap4
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeNumero(Numero numero);
    }
}
