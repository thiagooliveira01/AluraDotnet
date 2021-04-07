using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void EscritaBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using (var escrito = new BinaryWriter(fs))
            {
                escrito.Write(456); 
                escrito.Write(546544);
                escrito.Write(546544);
                escrito.Write("Gustavo Braga");
            }
        }

        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using (var leitura = new BinaryReader(fs))
            {
                var agencia = leitura.ReadInt32();
                var numeroConta = leitura.ReadInt32();
                var saldo = leitura.ReadDouble();
                var titular = leitura.ReadString();

                Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");   
            }
        }
    }
}
