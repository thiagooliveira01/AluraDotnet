using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap6;
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
            var mensagem = new MensagemAdministrativa("victor");
            var enviador = new EnviaPorEmail();
            mensagem.Enviador = enviador;
            mensagem.Envia();
        }
    }
}
