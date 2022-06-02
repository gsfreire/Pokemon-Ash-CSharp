using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pokemon_Ash;
namespace TestesUnitarios
{
    [TestClass]
    public class AshTest
    {
        Ash ashTeste;

        [TestInitialize]
        public void TestInitialize(){
            ashTeste = new Ash();
        }

        [TestMethod]
        public void AshInicializaNaPosicao00Com1Pokemon(){
            var posicaoInicial = new Posicao(0, 0);
            int quantidadePokemonEsperada = 1;
            Assert.IsTrue(new ComparadorPosicao().Equals(posicaoInicial, ashTeste.RetornarPosicao()));
            Assert.AreEqual(quantidadePokemonEsperada, ashTeste.RetornarQuantidadePokemonsCapturados());
        }

        [TestMethod]
        public void AshAndaProNorteEContem2Pokemons(){
            var posicaoEsperada = new Posicao(0, 1);
            int quantidadePokemonEsperada = 2;

            ashTeste.AndarProNorte();
            Assert.IsTrue(new ComparadorPosicao().Equals(posicaoEsperada, ashTeste.RetornarPosicao()));
            Assert.AreEqual(quantidadePokemonEsperada, ashTeste.RetornarQuantidadePokemonsCapturados());
        }

        [TestMethod]
        public void AshAndaProSulEContem2Pokemons(){
            var posicaoEsperada = new Posicao(0, -1);
            int quantidadePokemonEsperada = 2;

            ashTeste.AndarProSul();
            Assert.IsTrue(new ComparadorPosicao().Equals(posicaoEsperada, ashTeste.RetornarPosicao()));
            Assert.AreEqual(quantidadePokemonEsperada, ashTeste.RetornarQuantidadePokemonsCapturados());
        }

        [TestMethod]
        public void AshAndaProEsteEContem2Pokemons(){
            var posicaoEsperada = new Posicao(1, 0);
            int quantidadePokemonEsperada = 2;

            ashTeste.AndarProEste();
            Assert.IsTrue(new ComparadorPosicao().Equals(posicaoEsperada, ashTeste.RetornarPosicao()));
            Assert.AreEqual(quantidadePokemonEsperada, ashTeste.RetornarQuantidadePokemonsCapturados());
        }

        [TestMethod]
        public void AshAndaProOesteEContem2Pokemons(){
            var posicaoEsperada = new Posicao(-1, 0);
            int quantidadePokemonEsperada = 2;

            ashTeste.AndarProOeste();

            Assert.IsTrue(new ComparadorPosicao().Equals(posicaoEsperada, ashTeste.RetornarPosicao()));
            Assert.AreEqual(quantidadePokemonEsperada, ashTeste.RetornarQuantidadePokemonsCapturados());
        }

        [TestMethod]
        public void AshAndaEmUmPequenoCirculoEContem4Pokemons(){
            var posicaoEsperada = new Posicao(0, 0);
            int quantidadePokemonEsperada = 4;
            string sequencia = "NESO";

            ashTeste.Movimentar(sequencia);
            Assert.IsTrue(new ComparadorPosicao().Equals(posicaoEsperada, ashTeste.RetornarPosicao()));
            Assert.AreEqual(quantidadePokemonEsperada, ashTeste.RetornarQuantidadePokemonsCapturados());
        }
        [TestMethod]
        public void AshAndaSempreVoltaPraPosicaoInicialEContem5Pokemons()
        {
            var posicaoEsperada = new Posicao(0, 0);
            int quantidadePokemonEsperada = 5;
            string sequencia = "NSOESNEO";

            ashTeste.Movimentar(sequencia);
            Assert.IsTrue(new ComparadorPosicao().Equals(posicaoEsperada, ashTeste.RetornarPosicao()));
            Assert.AreEqual(quantidadePokemonEsperada, ashTeste.RetornarQuantidadePokemonsCapturados());
        }
    }
}
