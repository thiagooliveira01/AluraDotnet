using Alura.CoisasAFazer.Core.Commands;
using Alura.CoisasAFazer.Core.Models;
using Alura.CoisasAFazer.Infrastructure;
using Alura.CoisasAFazer.Services.Handlers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;

namespace Alura.CoisasAFazer.Testes
{
    public class CadastraTarefaHandlerExecute
    {
        [Fact]
        public void DadaTarefaComInfoValidaDeveIncluirNoBD()
        {
            //arrange
            var comando = new CadastraTarefa("Estudar Xunit", new Categoria("Estudo"), new DateTime(2019, 12, 31));

            var options = new DbContextOptionsBuilder<DbTarefasContext>()
                .UseInMemoryDatabase("DbTarefasContext")
                .Options;
            var contexto = new DbTarefasContext(options);
            var repo = new RepositorioTarefa(contexto);

            var handle = new CadastraTarefaHandler(repo);

            //act
            handle.Execute(comando);

            //assert
            var tarefas = repo.ObtemTarefas(t => t.Titulo == "Estudar Xunit").FirstOrDefault();
            Assert.NotNull(tarefas);

        }
    }
}
