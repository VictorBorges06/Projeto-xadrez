using tabuleiro;

namespace Xadrez__Jogo_{
    class Torre : Peca{ //Aqui diz que a classe Torre está herdando da classe Peca, tudo o que ela tem!

        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor){ // Esse : base (tab, cor) está repassando para a classe Peca
        }
        public override string ToString()
        {
            return "T";
        }
    }
}
