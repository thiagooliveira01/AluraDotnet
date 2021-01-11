using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Services
{
    public interface IProdutoService
    {
        IEnumerable<Leilao> PesquisaLeiloesEmPregaoPorTermo(string termo);
        IEnumerable<Categoria> ConsultaCategoriasComTotalDeLeiloesEmPregao();
        Categoria ConsultaCategoriaPorIdClomLeiloesEmPregao(int id);
    }
}
