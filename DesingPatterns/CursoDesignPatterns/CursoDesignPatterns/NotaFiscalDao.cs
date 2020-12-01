using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("simulando salvaNoBanco");
        }
    }
}
