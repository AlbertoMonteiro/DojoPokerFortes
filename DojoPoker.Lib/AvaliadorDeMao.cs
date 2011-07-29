using System.Collections.Generic;
using System.Linq;

namespace DojoPoker.Lib {
    public class AvaliadorDeMao {
        
        public static Jogo jogo { get; set; }
        private static TipoCarta cartaDaTrinca;

        public static TipoJogo Avalia(Mao mao) {

            if (TemRoyalFlush(mao.Cartas))
                return TipoJogo.RoyalFlush;
            if (TemSequenciaFlush(mao.Cartas))
                return TipoJogo.SequenciaFlush;
            if (TemQuadra(mao.Cartas))
                return TipoJogo.Quadra;
            if (TemFullHouse(mao.Cartas))
                return TipoJogo.FullHouse;
            if (TemFlush(mao.Cartas))
                return TipoJogo.Flush;
            if (TemSequencia(mao.Cartas))
                return TipoJogo.Sequencia;
            if (TemTrinca(mao.Cartas, out cartaDaTrinca))
                return TipoJogo.Trinca;
            if (TemDoisPares(mao.Cartas))
                return TipoJogo.DoisPares;
            if (TemUmPar(mao.Cartas))
                return TipoJogo.Par;

            return TipoJogo.CartaAlta;
        }

        private static bool TemRoyalFlush(List<Carta> cartas) {
            var menorCartaEh10 = cartas.OrderBy(carta => carta.Valor).First().Valor == TipoCarta.C10;
            if (!menorCartaEh10) return false;
            var temSequenciaFlush = TemSequenciaFlush(cartas);
            return temSequenciaFlush;
        }

        private static bool TemSequenciaFlush(List<Carta> cartas) {
            return TemFlush(cartas) && TemSequencia(cartas);
        }

        private static bool TemFlush(IEnumerable<Carta> cartas) {
            var naipes = cartas.Select(carta => carta.Naipe).Distinct();
            return naipes.Count() == 1;
        }

        private static bool TemQuadra(IEnumerable<Carta> cartas) {
            List<TipoCarta> duplicates = cartas.GroupBy(i => i.Valor).Where(g => g.Count() > 3).Select(g => g.Key).ToList();
            return duplicates.Count == 1;
        }

        private static bool TemFullHouse(List<Carta> cartas) {
            var temTrinca = TemTrinca(cartas, out cartaDaTrinca);
            if (!temTrinca) return false;
            return TemUmPar(cartas.Where(car => car.Valor != cartaDaTrinca));
        }

        private static bool TemSequencia(IEnumerable<Carta> cartas) {
            var cartasOrdenadas = cartas.OrderBy(carta => carta.Valor).ToList();
            for (int i = 0; i < cartasOrdenadas.Count() - 1; i++) {
                if (cartasOrdenadas[i].Valor + 1 != cartasOrdenadas[i + 1].Valor)
                    return false;
            }
            return true;
        }

        private static bool TemTrinca(IEnumerable<Carta> cartas, out TipoCarta tipoCarta) {
            List<TipoCarta> duplicates = cartas.GroupBy(i => i.Valor).Where(g => g.Count() > 2).Select(g => g.Key).ToList();
            tipoCarta = duplicates.FirstOrDefault();
            return duplicates.Count == 1;
        }

        private static bool TemDoisPares(IEnumerable<Carta> cartas) {
            List<TipoCarta> duplicates = cartas.GroupBy(i => i.Valor).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
            return duplicates.Count == 2;
        }

        private static bool TemUmPar(IEnumerable<Carta> cartas) {
            List<Carta> duplicates = cartas.GroupBy(i => i.Valor).Where(g => g.Count() > 1).Select(g => g.ElementAt(0)).ToList();
            jogo = new Jogo(duplicates.OrderBy(x => x.Valor).ToList(), TipoJogo.Par);
            return duplicates.Count == 1;
        }

        public static Carta DescobreCartaAlta(Mao mao) {
            return mao.Cartas.OrderBy(car => car.Valor).Last();
        }

        public static int Desempata(Mao mao1, Jogo jogo1, Mao mao2, Jogo jogo2){
            var sobraMao1 = mao1.Cartas.Where(x => !jogo1._cartas.Any(y => y.Valor == x.Valor));
            var sobraMao2 = mao2.Cartas.Where(x => !jogo2._cartas.Any(y => y.Valor == x.Valor));
            var descobreCartaAlta1 = DescobreCartaAlta(new Mao(sobraMao1));
            var descobreCartaAlta2 = DescobreCartaAlta(new Mao(sobraMao2));
            return descobreCartaAlta1 > descobreCartaAlta2 ? 1 : 2;
        }
    }
}
