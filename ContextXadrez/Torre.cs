using XadrezConsole.ContextTabuleiro;

namespace XadrezConsole.ContextXadrez
{
    public class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor)
            : base(cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "T";
        }

    }
}