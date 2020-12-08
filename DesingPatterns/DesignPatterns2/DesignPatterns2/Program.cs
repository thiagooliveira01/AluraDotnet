using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap6;
using DesignPatterns2.Cap7;
using DesignPatterns2.Cap8;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Serialization;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = "victor";
            cliente.Endereco = "Rua Vergueiro";
            cliente.DataDeNascimento = DateTime.Now;

            string xml = new GeradorDeXml().GeraXml(cliente);

            Console.WriteLine(xml);
        }
    }
}
