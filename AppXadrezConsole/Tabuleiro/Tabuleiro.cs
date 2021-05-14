
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; } // Quantidade de linhas do tabuleiro.
        public int colunas { get; set; } // Quantidade de colunas do tabuleiro.
        private Peca[,] pecas; // Declarando uma matriz com peças nulas para serem percorridas.

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            this.pecas = new Peca[linhas, colunas]; // Instanciando o tamanho do tabuleiro por meio de uma matriz onde as peças podem percorrer.
        }

        public Peca peca(int linha, int coluna) // Método para retornar uma peça que é privada para outra classe.
        {
            return pecas[linha, coluna]; // Retorna o que está armazenado na posição do vetor.
        }

        public Peca peca(Posicao pos) // Sobrecarga de 'peca' para melhorar o código.
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos) // Método para testar se existe uma peça na posição.
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos) // Método para colocar uma peça(instanciada) na posição que também foi instanciada.
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }

            pecas[pos.linha, pos.coluna] = p; // Tabuleiro com o vetor de peças null armazenando na posição que foi instanciada uma peça instanciada, fazendo com que essa posição não seja mais null.
            p.posicao = pos; // Peça instanciada recebendo os valores da posição instanciada no tabuleiro.
        }

        public Peca retirarPeca(Posicao pos) // Método para retirar uma peça.
        {
            if (peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }

        public bool posicaoValida(Posicao pos) // Método para testar se a posição é válida ou não.
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos) // Método para lançar uma exceção.
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição invalida!");
            }
        }
       
    }
}
