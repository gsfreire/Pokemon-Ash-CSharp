using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pokemon_Ash;
namespace TestesUnitarios
{
    [TestClass]
    public class AshTest
    {
        [TestMethod]
        public void AshInicializaNaPosicao00()
        {
            var ashTeste = new Ash();
            var posicaoInicial = new Posicao(0,0);
            Assert.AreEqual(posicaoInicial.x, ashTeste.RetornarPosicao().x);
            Assert.AreEqual(posicaoInicial.y, ashTeste.RetornarPosicao().y);
        }

        [TestMethod]
        public void AshAndaTresVezesProNorteESomaTresUnidadesNaPosicaoY()
        {
            var ashTeste = new Ash();
            var entrada = "NNN";
            foreach(char c in entrada)
            {
                ashTeste.Andar(c);
            }
            var posicaoEsperada = new Posicao(0, 3);
            Assert.AreEqual(posicaoEsperada.x, ashTeste.RetornarPosicao().x);
            Assert.AreEqual(posicaoEsperada.y, ashTeste.RetornarPosicao().y);
        }

        [TestMethod]
        public void AshAndaTresVezesProSulESubtraiTresUnidadesNaPosicaoY()
        {
            var ashTeste = new Ash();
            var entrada = "SSS";
            foreach (char c in entrada)
            {
                ashTeste.Andar(c);
            }
            var posicaoEsperada = new Posicao(0, -3);
            Assert.AreEqual(posicaoEsperada.x, ashTeste.RetornarPosicao().x);
            Assert.AreEqual(posicaoEsperada.y, ashTeste.RetornarPosicao().y);
        }

        [TestMethod]
        public void AshAndaTresVezesProEsteESomaTresUnidadesNaPosicaoX()
        {
            var ashTeste = new Ash();
            var entrada = "EEE";
            foreach (char c in entrada)
            {
                ashTeste.Andar(c);
            }
            var posicaoEsperada = new Posicao(3, 0);
            Assert.AreEqual(posicaoEsperada.x, ashTeste.RetornarPosicao().x);
            Assert.AreEqual(posicaoEsperada.y, ashTeste.RetornarPosicao().y);
        }

        [TestMethod]
        public void AshAndaTresVezesProOesteESubtraiTresUnidadesNaPosicaoX()
        {
            var ashTeste = new Ash();
            var entrada = "OOO";
            foreach (char c in entrada)
            {
                ashTeste.Andar(c);
            }
            var posicaoEsperada = new Posicao(-3, 0);
            Assert.AreEqual(posicaoEsperada.x, ashTeste.RetornarPosicao().x);
            Assert.AreEqual(posicaoEsperada.y, ashTeste.RetornarPosicao().y);
        }

        [TestMethod]
        public void AshAndaEmCirculoECapturaQuatroPokemons()
        {
            var ashTeste = new Ash();
            var entrada = "NESO";
            foreach (char c in entrada)
            {
                ashTeste.Andar(c);
            }
            Assert.AreEqual(4, ashTeste.RetornarQuantidadePokemonsCapturados());
        }

        [TestMethod]
        public void AshAndaNorteSulRepetidamente()
        {
            var ashTeste = new Ash();
            var entrada = "NSNSNSNS";
            foreach (char c in entrada)
            {
                ashTeste.Andar(c);
            }
            Assert.AreEqual(2, ashTeste.RetornarQuantidadePokemonsCapturados());
        }

        [TestMethod]
        public void AshAndaEmUmCaminhoLongo()
        {
            var ashTeste = new Ash();
            int qtdN = 27, qtdE = 99;


            for (int n = 0; n < qtdN; n++) ashTeste.Andar('N');
            for (int e = 0; e < qtdE; e++) ashTeste.Andar('E');

            Assert.AreEqual(1 + qtdN + qtdE, ashTeste.RetornarQuantidadePokemonsCapturados());
        }
    }
}
