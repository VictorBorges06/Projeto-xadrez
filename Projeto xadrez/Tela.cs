using System;
using tabuleiro;
using Xadrez__Jogo_;
namespace Projeto_xadrez
{
    class Tela{

        public static void imprimirTabuleiro( Tabuleiro tab)
        {
            for (int i= 0; i<tab.linhas; i++) //Os dois 'for' foram criados para percorrer as linhas e colunas do tabuleiro
            {
                Console.Write(8 - i + " "); //Essa linha é para melhorar a impressão do tabuleiro.
                for (int j=0; j<tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null) //Teste feito para imprimir um traço ' - ' caso o campo (posição) n recebe peça
                    {
                        Console.Write("- ");
                    }
                    else {
                        imprimirPeca(tab.peca(i, j)); //Para imprimir o que tem na linha ou coluna!
                        Console.Write(" "); 
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h"); //Essa linha é para aparecer as listas igual no tabuleiro de xadrez
        }

        public static Posicaoxadrez lerPosicaoXadrez() {

            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new Posicaoxadrez(coluna, linha);
        }


        public static void imprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
