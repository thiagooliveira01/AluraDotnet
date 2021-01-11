using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class NotaFiscalBuilder
    {
        public string RazaSocial { get; private set; }
        public string Cnpj { get; private set; }
        private double ValorTotal;
        private double Impostos { get; set; }
        public string Obs { get; private set; }
        public DateTime Data { get; private set; } = DateTime.Now;

        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();
        private IList<IAcaoAposGerarNota> todasAcoesASeremExecutadas = new List<IAcaoAposGerarNota>();

        public NotaFiscal Constroi()
        {
            var nf = new NotaFiscal(RazaSocial, Cnpj, Data, ValorTotal, Impostos, todosItens, Obs);

            foreach (var acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        public void AdicionaAcao(IAcaoAposGerarNota novaAcao)
        {
            todasAcoesASeremExecutadas.Add(novaAcao);
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaSocial = razaoSocial;
            return this;
        }
        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }
        public NotaFiscalBuilder ComObs(string obs)
        {
            Obs = obs;
            return this;
        }
        public NotaFiscalBuilder NaData(DateTime date)
        {
            Data = date;
            return this;
        }
        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }
    }
}
