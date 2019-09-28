﻿using System;
using tabuleiro;

namespace Xadrez_Console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.GetPeca(i, j) != null)
                    {
                        Console.WriteLine($"{tab.GetPeca(i, j)} ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
