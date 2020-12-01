using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Services
{
    public interface IAdminService
    {
        public IEnumerable<Categoria> ConsultaCategorias();

        public IEnumerable<Leilao> ConsultaLeiloes();

        public Leilao ConsultaPorId(int id);

        public void CadastraLeilao(Leilao leilao);
        public void ModificaLeilao(Leilao leilao);
        public void RemoveLeilao(Leilao leilao);
        public void IniciaPregaoDoLeilaoComId(int id);
        public void FinalizaPregaoDoLeilaoComId(int id);
    }
}
