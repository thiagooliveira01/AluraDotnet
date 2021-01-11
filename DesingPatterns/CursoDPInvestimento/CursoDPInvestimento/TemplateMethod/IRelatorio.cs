using System.Collections.Generic;

namespace CursoDPInvestimento.TemplateMethod
{
    public interface IRelatorio
    {
        public void Imprime(Banco banco, List<ContaBancaria> contas);
    }
}