using Alura.LeilaoOnline.Core;
using System.Linq;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
    public class LeilaoRecebeLance
    {
        [Fact]
        public void NaoAceitaProximoLanceDadoMesmoClienteRealizouUltimo()
        {
            //Arranje = cenário
            var modalidade = new MaiorValor();
            var leilao = new Leilao("Van Gogh", modalidade);
            var fulano = new Interessada("Fulano", leilao);
            leilao.IniciaPregao();

            leilao.RecebeLance(fulano, 800);

            //Act = método sob teste
            leilao.RecebeLance(fulano, 1000);

            //Assert
            var qtdeEperada = 1;
            Assert.Equal(qtdeEperada, leilao.Lances.Count());
        }
        [Theory]
        [InlineData(2, new double[] { 800, 900})]
        [InlineData(3, new double[] { 800, 900, 1000})]
        public void NaoPermiteNovosLancesDadoLeilaoFinalizado(int qtdeEperada, double[] ofertas)
        {
            //Arranje = cenário
            var modalidade = new MaiorValor();
            var leilao = new Leilao("Van Gogh", modalidade);
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);
            leilao.IniciaPregao();
            for (int i = 0; i < ofertas.Length; i++)
            {
                var valor = ofertas[i];
                if ((i % 2) == 0)
                {
                    leilao.RecebeLance(fulano, valor);
                }
                else
                {
                    leilao.RecebeLance(maria, valor);
                }
            }
            leilao.TerminaPregao();

            //Act = método sob teste
            leilao.RecebeLance(fulano, 1000);

            //Assert
            Assert.Equal(qtdeEperada, leilao.Lances.Count());
        }

        [Theory]
        [InlineData(new double[] { 200, 300, 400, 500 })]
        [InlineData(new double[] { 200 })]
        [InlineData(new double[] { 200, 300, 400 })]
        [InlineData(new double[] { 200, 300, 400, 500, 600, 700 })]
        public void QtdePermaneceZeroDadoQuePregaoNaoFoiIniciado(double[] ofertas)
        {
            var modalidade = new MaiorValor();
            var leilao = new Leilao("Van Gogh", modalidade);
            var fulano = new Interessada("Fulano de Tal", leilao);

            foreach (var valor in ofertas)
            {
                leilao.RecebeLance(fulano, valor);
            }

            Assert.Empty(leilao.Lances);
        }
    }
}
