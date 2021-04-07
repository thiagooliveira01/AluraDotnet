using ByteBankImportacaoExportacao.Modelos;
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
        static void Main(string[] args) 
        {
            var numero = 691693903;

            using (var fs = new FileStream("c:/temp/BinaryWriter.txt", FileMode.Create))
            using (var writer = new BinaryWriter(fs))
            {
                writer.Write(numero);
            }

            using (var fs = new FileStream("c:/temp/StreamWriter.txt", FileMode.Create))
            using (var writer = new StreamWriter(fs))
            {
                writer.Write(numero);
            }
        }

        
    }
} 
 