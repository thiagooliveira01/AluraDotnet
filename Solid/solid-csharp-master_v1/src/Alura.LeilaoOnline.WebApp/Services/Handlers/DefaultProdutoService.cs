using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Services.Handlers
{
    public class DefaultProdutoService : IProdutoService
    {
        ILeilaoDao _leilaoDao;
        ICategoriaDao _categoriaDao;

        public DefaultProdutoService(ILeilaoDao leilaoDao, ICategoriaDao categoriaDao)
        {
            _leilaoDao = leilaoDao;
            _categoriaDao = categoriaDao;
        }

        public Categoria ConsultaCategoriaPorIdClomLeiloesEmPregao(int id)
        {
            return _categoriaDao.ConsultaCategoriaPorId(id);
        }

        public IEnumerable<Categoria> ConsultaCategoriasComTotalDeLeiloesEmPregao()
        {
            return _categoriaDao.
        }

        public IEnumerable<Leilao> PesquisaLeiloesEmPregaoPorTermo(string termo)
        {
            throw new NotImplementedException();
        }
    }
}
