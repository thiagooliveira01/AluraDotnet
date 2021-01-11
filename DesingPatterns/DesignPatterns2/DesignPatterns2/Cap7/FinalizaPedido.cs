using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap7
{
    public class FinalizaPedido : IComando
    {
        private readonly Pedido _pedido;

        public FinalizaPedido(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Finalizando o Pedido do Cliente {0}", _pedido.Cliente);
            _pedido.Finaliza();
        }
    }
}
