using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap9
{
    public class ServicoSingleton
    {
        private static Servico facade = new Servico();
        public Servico Instancia
        {
            get
            {
                return facade;
            }
        }
    }
}
