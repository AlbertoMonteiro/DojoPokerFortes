using System.Collections.Generic;

namespace DojoPoker.Lib {
    public class Jogo {
        public readonly List<Carta> _cartas;
        public readonly TipoJogo _tipoJogo;

        public Jogo(List<Carta> cartas, TipoJogo tipoJogo) {
            _cartas = cartas;
            _tipoJogo = tipoJogo;
        }
    }
}
