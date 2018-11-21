namespace tabuleiro{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas; //vetor sendo usando para Peças [,] para receber um numero especifico de linhas e colunas
        // Vetor acima está 'private' para evitar que o Desenvolvedor mexa de maneira equivocada na peça.
        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas]; // informando no contrutor qual o parametro que o vetor peças vai receber
        
        }
         public Peca peca (int linha, int coluna) // Método criado para que a classe Tela, possa acessar as peças na matriz
        {
            return pecas[linha, coluna];
        }

        public Peca peca (Posicao pos) //Isto é uma sobrecarga da Peça
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos) //Método criado para testar se existe alguma peça em determinada posição
        {                        
            validarPosicao(pos); //Caso não exista a posição, essa linha será responsável por retornar a mensagem da exceção!
            return peca(pos)!= null;
        }

        public void colocarPeca( Peca p, Posicao pos) // Método criado que coloca as peças no tabuleiro
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public bool posicaoValida(Posicao pos){ //Este metodo foi criado para testar se a posicao e valida ou nao (8,8) e o tabuleiro
            if (pos.linha<0 || pos.linha>= linhas || pos.coluna<0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos){ //Método criado para testar se a posicao nao é valida e lançar uma mensagem
            if (!posicaoValida(pos)){
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
