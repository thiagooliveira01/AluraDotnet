using CursoDPInvestimento.State;
using System;

namespace CursoDPInvestimento
{
    public class ContaBancaria
    {
        public double Saldo { get; set; }
        public string Nome { get; private set; }
        public string Agencia { get; private set; }
        public string Numero { get; private set; }
        public DateTime DataAbertura { get; private set; }
        public IEstadoConta EstadoAtual { get; set; }

        public ContaBancaria( double valor, string nome, string agencia, string numero, DateTime dataAbertura)
        {
            Saldo = valor;
            Nome = nome;
            Agencia = agencia;
            Numero = numero;
            DataAbertura = dataAbertura;
            if(Saldo >= 0)
                EstadoAtual = new StatusPositivo();
            else
                EstadoAtual = new StatusNegativo();
        }
        public void Depositar(double valor)
        {
            EstadoAtual.Depositar(this, valor);
        }
        public void Sacar(double valor)
        {
            EstadoAtual.Sacar(this, valor);
        }

    }
}