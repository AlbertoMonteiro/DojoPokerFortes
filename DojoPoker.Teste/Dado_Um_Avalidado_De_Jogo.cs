using DojoPoker.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DojoPoker.Teste {
    [TestClass]
    public class Dado_Um_Avalidado_De_Jogo {

        [TestMethod]
        public void Posso_descobrir_a_carta_alta() {
            var mao = new Mao();
            mao.AdicionarCarta(new Carta(TipoCarta.C1, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C2, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C4, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C5, TipoNaipe.C));

            var maiorCarta = new Carta(TipoCarta.C5, TipoNaipe.C);
            
            var carta = AvaliadorDeMao.DescobreCartaAlta(mao);
            Assert.AreEqual(maiorCarta, carta);
        }

        [TestMethod]
        public void Posso_descobrir_um_par() {
            var mao = new Mao();
            mao.AdicionarCarta(new Carta(TipoCarta.C1, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C2, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C1, TipoNaipe.D));
            mao.AdicionarCarta(new Carta(TipoCarta.C4, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C5, TipoNaipe.C));

            var tipoJogo = AvaliadorDeMao.Avalia(mao);

            Assert.AreEqual(TipoJogo.Par, tipoJogo);
        }

        [TestMethod]
        public void Posso_descobrir_dois_pares() {
            var mao = new Mao();
            mao.AdicionarCarta(new Carta(TipoCarta.C1, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C2, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C1, TipoNaipe.D));
            mao.AdicionarCarta(new Carta(TipoCarta.C5, TipoNaipe.D));
            mao.AdicionarCarta(new Carta(TipoCarta.C5, TipoNaipe.C));

            var tipoJogo = AvaliadorDeMao.Avalia(mao);


            Assert.AreEqual(TipoJogo.DoisPares, tipoJogo);
        }

        [TestMethod]
        public void Posso_descobrir_trica() {
            var mao = new Mao();
            mao.AdicionarCarta(new Carta(TipoCarta.C1, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C2, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C1, TipoNaipe.D));
            mao.AdicionarCarta(new Carta(TipoCarta.C1, TipoNaipe.S));
            mao.AdicionarCarta(new Carta(TipoCarta.C5, TipoNaipe.C));

            var tipoJogo = AvaliadorDeMao.Avalia(mao);


            Assert.AreEqual(TipoJogo.Trinca, tipoJogo);
        }

        [TestMethod]
        public void Posso_descobrir_sequencia() {
            var mao = new Mao();
            mao.AdicionarCarta(new Carta(TipoCarta.C1, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C2, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.D));
            mao.AdicionarCarta(new Carta(TipoCarta.C4, TipoNaipe.S));
            mao.AdicionarCarta(new Carta(TipoCarta.C5, TipoNaipe.C));

            var tipoJogo = AvaliadorDeMao.Avalia(mao);


            Assert.AreEqual(TipoJogo.Sequencia, tipoJogo);
        }

        [TestMethod]
        public void Posso_descobrir_flush() {
            var mao = new Mao();
            mao.AdicionarCarta(new Carta(TipoCarta.C1, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C2, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C8, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C5, TipoNaipe.C));

            var tipoJogo = AvaliadorDeMao.Avalia(mao);


            Assert.AreEqual(TipoJogo.Flush, tipoJogo);
        }

        [TestMethod]
        public void Posso_descobrir_full_house() {
            var mao = new Mao();
            mao.AdicionarCarta(new Carta(TipoCarta.C1, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C1, TipoNaipe.D));
            mao.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.D));
            mao.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.S));
            mao.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.C));

            var tipoJogo = AvaliadorDeMao.Avalia(mao);


            Assert.AreEqual(TipoJogo.FullHouse, tipoJogo);
        }

        [TestMethod]
        public void Posso_descobrir_quadra() {
            var mao = new Mao();
            mao.AdicionarCarta(new Carta(TipoCarta.C1, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.H));
            mao.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.D));
            mao.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.S));
            mao.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.C));

            var tipoJogo = AvaliadorDeMao.Avalia(mao);


            Assert.AreEqual(TipoJogo.Quadra, tipoJogo);
        }

        [TestMethod]
        public void Posso_descobrir_sequencia_flush() {
            var mao = new Mao();
            mao.AdicionarCarta(new Carta(TipoCarta.C1, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C2, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C4, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C5, TipoNaipe.C));

            var tipoJogo = AvaliadorDeMao.Avalia(mao);


            Assert.AreEqual(TipoJogo.SequenciaFlush, tipoJogo);
        }

        [TestMethod]
        public void Posso_descobrir_royal_flush() {
            var mao = new Mao();
            mao.AdicionarCarta(new Carta(TipoCarta.CA, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.CK, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.CQ, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C10, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.CJ, TipoNaipe.C));

            var tipoJogo = AvaliadorDeMao.Avalia(mao);


            Assert.AreEqual(TipoJogo.RoyalFlush, tipoJogo);
        }
    }
}
