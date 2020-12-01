using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class EnviadorDeEmail : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("simulando enviaPorEmail");
        }
    }
}
