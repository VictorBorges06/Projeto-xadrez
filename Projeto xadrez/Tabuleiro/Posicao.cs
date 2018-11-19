

namespace tabuleiro
{
    class Posicao
    {
        public int linha { get; set; } // Atributos com o Encapsulamento {Get; Set} 
        public int coluna { get; set; }// Get = Permite que o Atributo pode ser acessado, depois de colocar a palavra ''public''
                                       // Set = Permite que o Atributo possa ser alterado.

        public Posicao (int linha, int coluna) //Construtor para a função ''Program''
        {
            this.linha = linha; //Uso da palavra this que converte (associa) o que foi inserido na função Program após a sua instância
            this.coluna = coluna;
        }

        public override string ToString() // ToString para poder informar o conteudo da classe pro usuario depois de instanciado
        {
            return linha 
               + ", " 
               + coluna;
        }
    }
}
