using tabuleiro;

namespace Xadrez__Jogo_{
    class Rei : Peca{ //Aqui diz que a classe Rei está herdando da classe Peca, tudo o que ela tem!

        private PartidaDeXadrez partida;


        public Rei(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor)
        { // Esse : base (tab, cor) está repassando para a classe Peca
            this.partida = partida;
        }
        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Posicao pos) //Lógica implementada para permitir que o usuário mova a peça e tratando
        {                                   //Caso tenha peças adversárias!
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        private bool testeTorreParaRoque(Posicao pos) //Verificando se a Torre é para o Roque
        {
            Peca p = tab.peca(pos);
            return p != null && p is Torre && p.cor == cor && p.qntMovimentos == 0;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            pos.definirValores(posicao.linha - 1, posicao.coluna); // O Rei movendo para cima é essa lógica
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(posicao.linha - 1, posicao.coluna + 1); // O Rei movendo para o Nordeste é essa lógica
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }


            pos.definirValores(posicao.linha, posicao.coluna + 1); // O Rei movendo para Direita
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(posicao.linha + 1, posicao.coluna + 1); // O Rei movendo para o Sudeste
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            pos.definirValores(posicao.linha + 1, posicao.coluna); // O Rei movendo para baixo
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }


            pos.definirValores(posicao.linha + 1, posicao.coluna - 1); // O Rei movendo para o Sudoeste
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }


            pos.definirValores(posicao.linha, posicao.coluna - 1); // O Rei movendo para esquerda
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }


            pos.definirValores(posicao.linha - 1, posicao.coluna - 1); // O Rei movendo Noroeste
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // Movimento especial 'Roque Pequeno'

            if (qntMovimentos == 0 && !partida.xeque)
            {
                Posicao PosT1 = new Posicao(posicao.linha, posicao.coluna + 3);
                if (testeTorreParaRoque(PosT1))
                {
                    Posicao p1 = new Posicao(posicao.linha, posicao.coluna + 1);
                    Posicao p2 = new Posicao(posicao.linha, posicao.coluna + 2);
                    if (tab.peca(p1)==null && tab.peca(p2) == null)
                    {
                        mat[posicao.linha, posicao.coluna + 2] = true;
                    }
                }
                // Jogada especial para o Roque Grande
                Posicao PosT2 = new Posicao(posicao.linha, posicao.coluna - 4);
                if (testeTorreParaRoque(PosT2))
                {
                    Posicao p1 = new Posicao(posicao.linha, posicao.coluna - 1);
                    Posicao p2 = new Posicao(posicao.linha, posicao.coluna - 2);
                    Posicao p3 = new Posicao(posicao.linha, posicao.coluna - 3);
                    if (tab.peca(p1) == null && tab.peca(p2) == null && tab.peca(p3) == null)
                    {
                        mat[posicao.linha, posicao.coluna - 2] = true;
                    }
                }
            }
            return mat;
        }
    }
}
