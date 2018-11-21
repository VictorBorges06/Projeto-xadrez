namespace tabuleiro
{
    abstract class Peca {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qntMovimentos {get; protected set;}
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null; //Coloquei como nulo pois neste momento a peça ainda não tem posição
            this.tab = tab;
            this.cor = cor;
            this.qntMovimentos = 0;
        }



        public void incrementarQntMovimentos() // Criado isso para poder inserir a quantidade de movimentos da peça
        {
            qntMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis(); 
        //é abstrato pois precisa de uma peça especifica para determinado movimento
    }
}
