namespace XadrezConsole.ContextTabuleiro
{
    public class Tabuleiro
    {
        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public int Linhas { get; set; }
        public int Colunas { get; set; }
        public Peca[,] Pecas { get; private set; }

        public Peca Peca(int linha, int coluna)
        {   
            return Pecas[linha, coluna];
        }



    }
}