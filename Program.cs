using System;
using ContextTabuleiro;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); 
            Posicao p = new Posicao(3, 4);
            Console.WriteLine($"Posição: {p}");
            Tabuleiro tab = new Tabuleiro(8, 8);
            Console.ReadLine();
        }
    }
}
