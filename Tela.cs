using XadrezConsole.ContextTabuleiro;
using System;

namespace XadrezConsole
{
    public class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write($"{tab.Pecas[i, j]} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}