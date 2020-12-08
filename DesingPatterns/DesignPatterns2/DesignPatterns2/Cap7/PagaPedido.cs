using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2.Cap7
{
    public class PagaPedido : IComando
    {
        private readonly Pedido _pedido;

        public PagaPedido(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Pagando o Pedido do Cliente {0}", _pedido.Cliente);
            _pedido.Paga();
        }
    }
}
