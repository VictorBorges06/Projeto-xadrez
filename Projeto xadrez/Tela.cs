using System;
using System.Collections.Generic;
using tabuleiro;
using Xadrez__Jogo_;
namespace Projeto_xadrez
{
    class Tela {

        public static void imprimirPartida(PartidaDeXadrez partida)
        {
            imprimirTabuleiro(partida.tab);
            Console.WriteLine();
            imprimirPecasCapturadas(partida);
            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.turno);
            Console.WriteLine("Aguardando a jogada da peça: " + partida.jogadorAtual);
            if (partida.xeque)
            {
                Console.WriteLine("Você está em xeque!");
            }
        }

        public static void imprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Peças Capturadas: ");
            Console.Write("Brancas: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.WriteLine();
            Console.Write("Pretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }

        public static void imprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach (Peca x in conjunto)
            {
                Console.Write(x + " ");
            }
            Console.Write("]");
        }

        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            { //Os dois 'for' foram criados para percorrer as linhas e colunas do tabuleiro
                Console.Write(8 - i + " "); //Essa linha é para melhorar a impressão do tabuleiro.
                for (int j = 0; j < tab.colunas; j++)
                {
                    imprimirPeca(tab.peca(i, j)); //Para imprimir o que tem na linha ou coluna!
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }
             
            public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis){
                ConsoleColor fundoOriginal = Console.BackgroundColor;
                ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

                for (int i = 0; i < tab.linhas; i++)
                {
                    Console.Write(8 - i + " ");
                    for (int j = 0; j < tab.colunas; j++)
                    {
                        if (posicoesPossiveis[i, j])
                        {
                            Console.BackgroundColor = fundoAlterado;
                        }
                        else
                        {
                            Console.BackgroundColor = fundoOriginal;
                        }
                        imprimirPeca(tab.peca(i, j));
                        Console.BackgroundColor = fundoOriginal;
                    }
                Console.WriteLine();
               
            }
 
            Console.BackgroundColor = fundoOriginal;
        }

            public static Posicaoxadrez lerPosicaoXadrez() {

                string s = Console.ReadLine();
                char coluna = s[0];
                int linha = int.Parse(s[1] + "");
                return new Posicaoxadrez(coluna, linha);
            }

            
            public static void imprimirPeca(Peca peca)
            {
                if (peca == null)
                {
                    Console.Write("- ");
                }
                else
                {
                    if (peca.cor == Cor.Branca)
                    {
                        Console.Write(peca);
                    }

                    else
                    {
                        ConsoleColor aux = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(peca);
                        Console.ForegroundColor = aux;
                    }
                    Console.Write(" ");
                }
            }
        }
    }
