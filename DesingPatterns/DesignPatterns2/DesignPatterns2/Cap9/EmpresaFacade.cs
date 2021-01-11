using DesignPatterns2.Cap8;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap9
{
    public class EmpresaFacade
    {
        public Cliente BuscaCliente(string cpf)
        {
            return new Cliente();
        }
        /*
        public Fatura CriaFatura(Cliente cliente, double valor)
        {
            return new Fatura(cliente, valor);
        }
        public Cobranca GeraCobranca(Tipotipo, Fatura, fatura)
        {
            Cobranca cobranca = new Cobranca(tipo, fatura);
            cobranca.Emite();
        }
        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        {
            ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            contato.Dispara();
            return.Dispara();
        }*/
    }
}
