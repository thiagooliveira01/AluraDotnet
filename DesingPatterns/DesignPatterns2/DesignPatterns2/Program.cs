using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            var notas = new NotasMusicais();
            var musica = new List<INota>
            {
                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("fa")
            };

            var piano = new Piano();
            piano.Toca(musica);
        }
    }
}
