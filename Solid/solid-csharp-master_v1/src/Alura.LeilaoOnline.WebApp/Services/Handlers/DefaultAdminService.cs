using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Services.Handlers
{
    public class DefaultAdminService : IAdminService
    {
        ILeilaoDao _dao;

        public DefaultAdminService(ILeilaoDao dao)
        {
            _dao = dao;
        }

        public void CadastraLeilao(Leilao leilao)
        {
            _dao.Incluir(leilao);
        }

        public IEnumerable<Categoria> ConsultaCategorias()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Leilao> ConsultaLeiloes()
        {
            throw new NotImplementedException();
        }

        public Leilao ConsultaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void FinalizaPregaoDoLeilaoComId(int id)
        {
            throw new NotImplementedException();
        }

        public void IniciaPregaoDoLeilaoComId(int id)
        {
            throw new NotImplementedException();
        }

        public void ModificaLeilao(Leilao leilao)
        {
            throw new NotImplementedException();
        }

        public void RemoveLeilao(Leilao leilao)
        {
            throw new NotImplementedException();
        }
    }
}
