using System;
using DojoPoker.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DojoPoker.Teste {
    [TestClass]
    public class Dado_Uma_Mao {
        
        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void Nao_posso_adicionar_carta_ja_existente() {
            var mao = new Mao();
            mao.AdicionarCarta(new Carta(TipoCarta.C1, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C1, TipoNaipe.C));
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void So_posso_ter_cinco_cartas() {
            var mao = new Mao();
            mao.AdicionarCarta(new Carta(TipoCarta.C1, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C2, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C3, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C4, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C5, TipoNaipe.C));
            mao.AdicionarCarta(new Carta(TipoCarta.C6, TipoNaipe.C));
        }
    }

    
}