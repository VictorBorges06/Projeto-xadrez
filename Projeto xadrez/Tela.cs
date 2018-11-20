using System;
using tabuleiro;

namespace Projeto_xadrez
{
    class Tela{

        public static void imprimirTabuleiro( Tabuleiro tab)
        {
            for (int i= 0; i<tab.linhas; i++) //Os dois 'for' foram criados para percorrer as linhas e colunas do tabuleiro
            {
                for (int j=0; j<tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null) //Teste feito para imprimir um traço ' - ' caso o campo (posição) n recebe peça
                    {
                        Console.Write("- ");
                    }
                    else { 
                    Console.Write(tab.peca(i,j)  + " "); //Para imprimir o que tem na linha ou coluna!
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
