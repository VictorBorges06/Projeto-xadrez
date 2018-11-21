using tabuleiro;

namespace Xadrez__Jogo_
{
    class Posicaoxadrez{

        public char coluna { get; set; }
        public int linha { get; set; }

        public Posicaoxadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao() //Método criado para converter a posição na matriz
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }

    }
}
