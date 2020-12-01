using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class Multiplicador : IAcaoAposGerarNota
    {
        public Multiplicador(double fator)
        {
            Fator = fator;
        }

        public double Fator { get; private set; }

        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Valor Multiplicado: " + nf.ValorBruto * Fator);
        }
    }
}
