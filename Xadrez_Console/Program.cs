using System;
using tabuleiro;
using tabuleiro.Enums;
using tabuleiro.Exceptions;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Tabuleiro tab = new Tabuleiro(8, 8);

                //tab.SetPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                //tab.SetPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                //tab.SetPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                //Tela.ImprimirTabuleiro(tab);

                PosicaoXadrez pos = new PosicaoXadrez('c', 7);
                Console.WriteLine(pos.ToPosicao());

            }
            catch (TabulerioException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
