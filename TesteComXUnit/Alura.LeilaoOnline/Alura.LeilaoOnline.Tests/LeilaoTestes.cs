using Alura.LeilaoOnline.Core;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
    public class LeilaoTestes
    {
        [Fact]
        public  void LeilaoComApenasUmLance()
        {
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            leilao.RecebeLance(fulano, 800);

            //Act = método sob teste
            leilao.TerminaPregao();

            //Assert
            Assert.Equal(800, leilao.Ganhador.Valor);
        }
        [Fact]
        public void LeilaoComVariosLances()
        {
            //Arranje = cenário
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(fulano, 1000);
            leilao.RecebeLance(fulano, 990);

            //Act = método sob teste
            leilao.TerminaPregao();

            //Assert
            Assert.Equal(1000, leilao.Ganhador.Valor);
        }
    }
}
