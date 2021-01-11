using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap6
{
    public class MensagemCliente : IMensagem
    {
        private string Nome;
        public IEnviador Enviador { get; set; }
        public MensagemCliente(string nome)
        {
            Nome = nome;
        }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Mensagem para o Cliente {0}", Nome);
        }
    }
}
