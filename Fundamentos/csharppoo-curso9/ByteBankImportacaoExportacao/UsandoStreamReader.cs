using ByteBankImportacaoExportacao.Modelos;
using System;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {

        static void ImportaArquivoUsandoStreamReader()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDoArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var contaCorrente = ConverterStringParaContaCorrente(linha);

                    Console.WriteLine($"{contaCorrente.Titular.Nome} : Conta número {contaCorrente.Numero}, ag. {contaCorrente.Agencia}. Saldo: {contaCorrente.Saldo}");
                }
            }

        }

        public static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var resultado = new ContaCorrente(int.Parse(agencia), int.Parse(numero));
            resultado.Depositar(double.Parse(saldo));
            resultado.Titular = new Cliente(nomeTitular);

            return resultado;
        }

    }
}
