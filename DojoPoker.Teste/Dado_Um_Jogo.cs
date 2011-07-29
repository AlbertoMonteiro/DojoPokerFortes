using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DojoPoker.Lib;

namespace DojoPoker.Teste {
    [TestClass]
    public class Dado_Um_Jogo {
        [TestMethod]
        public void Posso_descobri_o_vencedor_da_primeira_entrada() {
            var mao = new Mao();
            mao.AdicionarCarta(new Carta(TipoCarta.C5, TipoNaipe.H));
            mao.AdicionarCarta(new Carta(TipoCarta.C5, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C6, TipoNaipe.S));
            mao.AdicionarCarta(new Carta(TipoCarta.C7, TipoNaipe.S));
            mao.AdicionarCarta(new Carta(TipoCarta.CK, TipoNaipe.D));

            var mao2 = new Mao();
            mao2.AdicionarCarta(new Carta(TipoCarta.C2, TipoNaipe.C));
            mao2.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.S));
            mao2.AdicionarCarta(new Carta(TipoCarta.C8, TipoNaipe.S));
            mao2.AdicionarCarta(new Carta(TipoCarta.C8, TipoNaipe.D));
            mao2.AdicionarCarta(new Carta(TipoCarta.CJ, TipoNaipe.D));

            var jogo = new JogoPoker(mao, mao2);
            int numeroMao = jogo.Vencedor();

            Assert.AreEqual(2, numeroMao);
        }

        [TestMethod]
        public void Posso_descobri_o_vencedor_da_segunda_entrada() {
            var mao = new Mao();
            mao.AdicionarCarta(new Carta(TipoCarta.C5, TipoNaipe.D));
            mao.AdicionarCarta(new Carta(TipoCarta.C8, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C9, TipoNaipe.S));
            mao.AdicionarCarta(new Carta(TipoCarta.CJ, TipoNaipe.S));
            mao.AdicionarCarta(new Carta(TipoCarta.CA, TipoNaipe.C));

            var mao2 = new Mao();
            mao2.AdicionarCarta(new Carta(TipoCarta.C2, TipoNaipe.C));
            mao2.AdicionarCarta(new Carta(TipoCarta.C5, TipoNaipe.C));
            mao2.AdicionarCarta(new Carta(TipoCarta.C7, TipoNaipe.D));
            mao2.AdicionarCarta(new Carta(TipoCarta.C8, TipoNaipe.S));
            mao2.AdicionarCarta(new Carta(TipoCarta.CQ, TipoNaipe.H));

            var jogo = new JogoPoker(mao, mao2);
            int numeroMao = jogo.Vencedor();

            Assert.AreEqual(1, numeroMao);
        }

        [TestMethod]
        public void Posso_descobri_o_vencedor_da_terceira_entrada() {
            var mao = new Mao();
            mao.AdicionarCarta(new Carta(TipoCarta.C2, TipoNaipe.D));
            mao.AdicionarCarta(new Carta(TipoCarta.C8, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.CA, TipoNaipe.S));
            mao.AdicionarCarta(new Carta(TipoCarta.CA, TipoNaipe.H));
            mao.AdicionarCarta(new Carta(TipoCarta.CA, TipoNaipe.C));

            var mao2 = new Mao();
            mao2.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.D));
            mao2.AdicionarCarta(new Carta(TipoCarta.C6, TipoNaipe.D));
            mao2.AdicionarCarta(new Carta(TipoCarta.C7, TipoNaipe.D));
            mao2.AdicionarCarta(new Carta(TipoCarta.C10, TipoNaipe.D));
            mao2.AdicionarCarta(new Carta(TipoCarta.CQ, TipoNaipe.D));

            var jogo = new JogoPoker(mao, mao2);
            int numeroMao = jogo.Vencedor();

            Assert.AreEqual(2, numeroMao);
        }

        [TestMethod]
        public void Posso_descobri_o_vencedor_da_quarta_entrada() {
            var mao = new Mao();
            mao.AdicionarCarta(new Carta(TipoCarta.C4, TipoNaipe.D));
            mao.AdicionarCarta(new Carta(TipoCarta.C6, TipoNaipe.S));
            mao.AdicionarCarta(new Carta(TipoCarta.C9, TipoNaipe.H));
            mao.AdicionarCarta(new Carta(TipoCarta.CQ, TipoNaipe.H));
            mao.AdicionarCarta(new Carta(TipoCarta.CQ, TipoNaipe.C));

            var mao2 = new Mao();
            mao2.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.D));
            mao2.AdicionarCarta(new Carta(TipoCarta.C6, TipoNaipe.D));
            mao2.AdicionarCarta(new Carta(TipoCarta.C7, TipoNaipe.H));
            mao2.AdicionarCarta(new Carta(TipoCarta.CQ, TipoNaipe.D));
            mao2.AdicionarCarta(new Carta(TipoCarta.CQ, TipoNaipe.S));

            var jogo = new JogoPoker(mao, mao2);
            int numeroMao = jogo.Vencedor();

            Assert.AreEqual(1, numeroMao);
        }

        [TestMethod]
        public void Posso_descobri_o_vencedor_da_quinta_entrada() {
            var mao = new Mao();
            mao.AdicionarCarta(new Carta(TipoCarta.C2, TipoNaipe.H));
            mao.AdicionarCarta(new Carta(TipoCarta.C2, TipoNaipe.D));
            mao.AdicionarCarta(new Carta(TipoCarta.C4, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C4, TipoNaipe.D));
            mao.AdicionarCarta(new Carta(TipoCarta.C4, TipoNaipe.S));

            var mao2 = new Mao();
            mao2.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.C));
            mao2.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.D));
            mao2.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.S));
            mao2.AdicionarCarta(new Carta(TipoCarta.C9, TipoNaipe.S));
            mao2.AdicionarCarta(new Carta(TipoCarta.C9, TipoNaipe.D));

            var jogo = new JogoPoker(mao, mao2);
            int numeroMao = jogo.Vencedor();

            Assert.AreEqual(1, numeroMao);
        }
    }
}
