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

        public void colocarPeca( Peca p, Posicao pos) // Método criado que coloca as peças no tabuleiro
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
    }
}
