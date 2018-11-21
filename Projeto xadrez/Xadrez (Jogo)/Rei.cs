using tabuleiro;

namespace Xadrez__Jogo_{
    class Rei : Peca{ //Aqui diz que a classe Rei está herdando da classe Peca, tudo o que ela tem!

        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor){ // Esse : base (tab, cor) está repassando para a classe Peca
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
            return mat;
        }
    }
}
