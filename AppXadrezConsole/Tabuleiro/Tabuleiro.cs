
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; } // Quantidade de linhas do tabuleiro.
        public int colunas { get; set; } // Quantidade de colunas do tabuleiro.
        private Peca[,] pecas; // Declarando um vetor com peças nulas para serem percorridas.

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            this.pecas = new Peca[linhas, colunas]; // Instanciando o tamanho do tabuleiro por meio de uma matriz onde as peças podem percorrer.
        }

        public Peca peca(int linha, int coluna) // Método para retornar uma peça que é privada para outra classe.
        {
            return pecas[linha, coluna];
        }

        public void colocarPeca(Peca p, Posicao pos) // Método para colocar uma peça(instanciada) na posição que também foi instanciada.
        {
            pecas[pos.linha, pos.coluna] = p; // Tabuleiro com o vetor de peças null recebendo na posição que foi instanciada uma peça instanciada, assim não rebendo null nessa posição.
            p.posicao = pos; // Peça instanciada recebendo os valores da posição instanciada no tabuleiro.
        }
    }
}
