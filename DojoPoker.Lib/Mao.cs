using System;
using System.Collections.Generic;

namespace DojoPoker.Lib {
    public class Mao {

        public Mao(){
            Cartas = new List<Carta>(5);
        }

        public Mao(IEnumerable<Carta> sobraMao1) {
            Cartas = new List<Carta>(5);
            Cartas.AddRange(sobraMao1);
        }

        public List<Carta> Cartas { get; private set; }

        public void AdicionarCarta(Carta carta) {
            if(Cartas.Count == 5)
                throw new InvalidOperationException("Limite de cartas atingido");
            else if (!Cartas.Contains(carta))
                Cartas.Add(carta);
            else {
                throw new ArgumentException("Não é possível adicionar uma carta já existente");
            }
        }
    }
}