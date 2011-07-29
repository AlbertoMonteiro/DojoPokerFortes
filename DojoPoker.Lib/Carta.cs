namespace DojoPoker.Lib{
    public class Carta{
        
        public TipoCarta Valor { get; set; }
        public TipoNaipe Naipe { get; set; }

        public Carta(TipoCarta valor, TipoNaipe naipe){
            Valor = valor;
            Naipe = naipe;
        }

        public override string ToString() {
            return string.Format("{0}-{1}", Valor, Naipe);
        }

        public override bool Equals(object obj) {
            if (obj is Carta){
                var carta = obj as Carta;
                return Naipe == carta.Naipe && Valor == carta.Valor;
            }
            return base.Equals(obj);
        }

        public override int GetHashCode() {
            return string.Format("{0}-{1}", (int)Valor, (int)Naipe).GetHashCode();
        }
        public static bool operator <(Carta c1, Carta c2){
            return c1.Valor < c2.Valor;
        }

        public static bool operator >(Carta c1, Carta c2){
            return c1.Valor > c2.Valor;
        }
    }
}