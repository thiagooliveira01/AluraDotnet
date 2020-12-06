using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap6
{
    public class MensagemAdministrativa : IMensagem
    {
        private string Nome;
        public IEnviador Enviador { get; set; }
        public MensagemAdministrativa(string nome)
        {
            Nome = nome;
        }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a Mensagem para o Administrador {0}", Nome);
        }
    }
}
