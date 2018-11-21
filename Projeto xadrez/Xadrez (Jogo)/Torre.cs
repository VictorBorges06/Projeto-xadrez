using tabuleiro;

namespace Xadrez__Jogo_{
    class Torre : Peca{ //Aqui diz que a classe Torre está herdando da classe Peca, tudo o que ela tem!

        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor){ // Esse : base (tab, cor) está repassando para a classe Peca
        }
        public override string ToString()
        {
            return "T";
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

            // Está lógica é para a Torre mover para cima!
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos). cor != cor)
                {
                    break;
                }
                pos.linha = pos.linha - 1;
            }

            // Está lógica é para a Torre mover para baixo!
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.linha + 1;
            }


            // Está lógica é para a Torre mover para direita!
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna + 1;
            }

            // Está lógica é para a Torre mover para esquerda!
            pos.definirValores(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.coluna = pos.coluna -1;
            }


            return mat;
        }




    }
}
