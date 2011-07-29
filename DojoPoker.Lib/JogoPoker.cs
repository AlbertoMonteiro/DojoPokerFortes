using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DojoPoker.Lib {
    public class JogoPoker {
        private readonly Mao _mao;
        private readonly Mao _mao2;

        public JogoPoker(Mao mao, Mao mao2) {
            _mao = mao;
            _mao2 = mao2;
        }

        public int Vencedor() {
            var tipoJogo1 = AvaliadorDeMao.Avalia(_mao);
            var jogo1 = AvaliadorDeMao.jogo;
            var tipoJogo2 = AvaliadorDeMao.Avalia(_mao2);
            var jogo2 = AvaliadorDeMao.jogo;
            if (tipoJogo1 == tipoJogo2) {
                if (tipoJogo1 == TipoJogo.CartaAlta) {
                    var cartaAlta1 = AvaliadorDeMao.DescobreCartaAlta(_mao);
                    var cartaAlta2 = AvaliadorDeMao.DescobreCartaAlta(_mao2);
                    return cartaAlta1 > cartaAlta2 ? 1 : 2;
                }
                if (jogo1._cartas.First().Valor == jogo2._cartas.First().Valor)
                    return AvaliadorDeMao.Desempata(_mao, jogo1, _mao2, jogo2);

                return jogo1._cartas.First() > jogo2._cartas.First() ? 1 : 2;
            }
            return tipoJogo1 > tipoJogo2 ? 1 : 2;
        }
    }
}
