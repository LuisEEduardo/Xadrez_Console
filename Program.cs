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
            
            PosicaoXadrez posx = new PosicaoXadrez('c', 7);
            System.Console.WriteLine(posx);
            System.Console.WriteLine(posx.ToPosicao());

            Console.ReadLine();
        }
    }
}
