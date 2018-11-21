using System;
using tabuleiro;
using Xadrez__Jogo_;

namespace Projeto_xadrez
{
     class Program
    {
        static void Main(string[] args){

            Posicaoxadrez pos = new Posicaoxadrez('a', 1);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            Console.ReadLine();

        }
    }
}
