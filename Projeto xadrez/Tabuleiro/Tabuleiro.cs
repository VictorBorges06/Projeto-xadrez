namespace tabuleiro{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas; //vetor sendo usando para Peças [,] para receber um numero especifico de linhas e colunas

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas]; // informando no contrutor qual o parametro que o vetor peças vai receber
        
        }

    }
}
