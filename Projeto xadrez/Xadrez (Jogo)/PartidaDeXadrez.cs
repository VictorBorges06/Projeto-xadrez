using System;
using tabuleiro;

namespace Xadrez__Jogo_
{
    class PartidaDeXadrez{

        public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
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

        public void realizaJogada(Posicao origem, Posicao destino) //Método criado para poder mudar o jogador depois da jogada
        {
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }

        public void validarPosicaoDeOrigem (Posicao pos) //Validação feita para as jogadas das peças, onde tem ou não peça
        {
            if (tab.peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida!");
            }
            if(jogadorAtual != tab.peca(pos).cor)
            {
                throw new TabuleiroException("A peça de origem escolhida não é sua!");
            }
            if (!tab.peca(pos).existeMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possíveis para a peça de origem escolhida!");
            }
        }


        public void ValidarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!tab.peca(origem).podeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino inválida!");
            }
        }


        private void mudaJogador()
        {
            if (jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Preta;
            }
            else
            {
                jogadorAtual = Cor.Branca;
            }
        }
        private void colocarPecas() //Encapsulamento para a exibição das peças no tabuleiro
        {
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicaoxadrez('c', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicaoxadrez('c', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicaoxadrez('d', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicaoxadrez('e', 2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicaoxadrez('e', 1).toPosicao());
            tab.colocarPeca(new Rei  (tab, Cor.Branca), new Posicaoxadrez('d', 1).toPosicao());


            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicaoxadrez('c', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicaoxadrez('c', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicaoxadrez('d', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicaoxadrez('e', 7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicaoxadrez('e', 8).toPosicao());
            tab.colocarPeca(new Rei  (tab, Cor.Preta), new Posicaoxadrez('d', 8).toPosicao());

        }
    }
}
