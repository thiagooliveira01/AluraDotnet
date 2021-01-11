using System;

namespace CursoDesignPatterns
{
    public class Item
    {
        public Item(String nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public String Nome { get; private set; }
        public double Valor { get; private set; }
    }
}