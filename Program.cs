using System;
using XadrezConsole.ContextTabuleiro;
using XadrezConsole.ContextXadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.ColocarPeca(
                    new Torre(tab, Cor.Preta),
                    new Posicao(0, 0)
                );
                tab.ColocarPeca(
                    new Torre(tab, Cor.Preta),
                    new Posicao(1, 3));
                tab.ColocarPeca(
                    new Rei(tab, Cor.Preta),
                    new Posicao(0, 2));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
