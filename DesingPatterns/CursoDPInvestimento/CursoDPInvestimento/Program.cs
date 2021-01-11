using CursoDPInvestimento.ChainOFResponsibility;
using CursoDPInvestimento.Decorators;
using CursoDPInvestimento.TemplateMethod;
using System;
using System.Collections.Generic;

namespace CursoDPInvestimento
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var listaContas = new List<ContaBancaria>();

            for (int i = 0; i < 4; i++)
            {
                listaContas.Add(new ContaBancaria(1000 + i, "Thiago " + i, "Agencia1 " + i, "n " + i, DateTime.Today));
            }
            */

            var contap = new ContaBancaria(1000 , "Thiago ", "Agencia1 ", "n ", DateTime.Today);
            var contan = new ContaBancaria(-500, "Thiago ", "Agencia1 ", "n ", DateTime.Today);


            Console.WriteLine(contap.Saldo);
            Console.WriteLine(contan.Saldo);

            contap.Sacar(100);
            //contan.Sacar(100);
            contan.Depositar(100);

            Console.WriteLine(contap.Saldo);
            Console.WriteLine(contan.Saldo);


            Console.ReadKey();
        }
    }
}
