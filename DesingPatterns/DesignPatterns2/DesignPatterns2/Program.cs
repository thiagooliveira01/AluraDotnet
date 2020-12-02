using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap4;
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
            IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
            IExpressao direita = new Soma(new Numero(2), new Numero(10));

            IExpressao conta = new Soma(esquerda, direita);

            int resultado = conta.Avalia();
            Console.WriteLine(resultado);

            IExpressao contaDivisao = new Divisao(new Numero(10), new Numero(2));
            IExpressao contaMultiplicacao = new Multiplicacao(new Numero(10), new Numero(2));

            int resultado2 = contaDivisao.Avalia();
            Console.WriteLine(resultado2);

            int resultado3 = contaMultiplicacao.Avalia();
            Console.WriteLine(resultado3);
        }
    }
}
