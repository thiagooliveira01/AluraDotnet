using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDPInvestimento.TemplateMethod
{
    public class Banco
    {
        public Banco(string nome, string telefone, string endereco, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Email = email;
        }

        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Endereco { get; private set; }
        public string Email { get; private set; }
    }
}
