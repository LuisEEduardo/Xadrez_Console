using System;

namespace XadrezConsole.ContextTabuleiro
{
    public class TabuleiroException : Exception
    {
        public TabuleiroException(string msg)
            : base(msg)
        {
        }
    }
}