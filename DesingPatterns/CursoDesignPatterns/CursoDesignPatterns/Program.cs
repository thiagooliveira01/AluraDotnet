using System;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var criador = new NotaFiscalBuilder();
            var criadorItem = new ItemDaNotaBuilder();
            criador.ParaEmpresa("Thiago")
            .ComCnpj("23.456.789/0001-12")

            .ComItem(criadorItem.ComNome("Item1").ComValor(100).Controi())
            .ComItem(criadorItem.ComNome("Item2").ComValor(200).Controi())
            .NaData(DateTime.Now)
            .ComObs("uma obs qualquer");

            criador.AdicionaAcao(new EnviadorDeEmail());
            criador.AdicionaAcao(new EnviadorDeSms());
            criador.AdicionaAcao(new NotaFiscalDao());
            criador.AdicionaAcao(new Multiplicador(2));

            var nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
            Console.WriteLine(nf.DataDeEmissao);

            Console.ReadKey();

        }
    }
}
