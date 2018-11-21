using System;
using tabuleiro;

namespace Xadrez__Jogo_
{
    class PartidaDeXadrez{

        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();

        }

        public void executaMovimento(Posicao origem, Posicao destino) // Construtor que faz o movimento da peça
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQntMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);

        }

        private void colocarPecas() //Encapsulamento para a exibição das peças no tabuleiro
        {
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicaoxadrez ('c', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicaoxadrez('c', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicaoxadrez('d', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicaoxadrez('e', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicaoxadrez('e', 1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicaoxadrez('d', 1).toPosicao());


            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicaoxadrez('c', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicaoxadrez('c', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicaoxadrez('d', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicaoxadrez('e', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicaoxadrez('e', 8).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicaoxadrez('d', 8).toPosicao());

        }
    }
}
