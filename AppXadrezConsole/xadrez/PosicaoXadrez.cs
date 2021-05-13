using tabuleiro;

namespace xadrez

{
    class PosicaoXadrez

    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao() // (conversor)transforma o objeto da 'linguagem' do xadrez (a1, a2, a3, etc) para as posições numericas do vetor (0 0, 0 1, 0 2, etc)
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }


    }
}
