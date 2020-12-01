using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento.TemplateMethod
{
    public abstract class TemplateRelatorio : IRelatorio

    {
        public void Imprime(Banco banco, List<ContaBancaria> contas)
        {
            Console.WriteLine(Cabecalho(banco));

            foreach (var item in contas)
            {
                Console.WriteLine(Corpo(item));
            }

            Console.WriteLine(Rodape(banco));
        }

        protected abstract string Cabecalho(Banco banco);
        protected abstract string Corpo(ContaBancaria conta);
        protected abstract string Rodape(Banco banco);
    }
}
