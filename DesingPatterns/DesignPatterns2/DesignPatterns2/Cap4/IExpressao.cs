using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap4
{
    public interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor visitor);
    }
}
