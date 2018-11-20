using tabuleiro;

namespace Xadrez__Jogo_{
    class Rei : Peca{ //Aqui diz que a classe Rei está herdando da classe Peca, tudo o que ela tem!

        public Rei (Tabuleiro tab, Cor cor) : base(tab, cor){ // Esse : base (tab, cor) está repassando para a classe Peca
        }
        public override string ToString()
        {
            return "R";
        }
    }
}
