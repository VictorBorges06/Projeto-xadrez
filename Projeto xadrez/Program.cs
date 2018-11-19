using System;
using Tabuleiro;

namespace Projeto_xadrez
{
    class Program
    {
        static void Main(string[] args){

            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("A Posição é: " + P);

            Console.ReadLine();

        }
    }
}
