﻿
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; } // Quantidade de linhas do tabuleiro.
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            this.pecas = new Peca[linhas, colunas]; // Instanciando o tamanho do tabuleiro por meio de uma matriz.
        }

        public Peca peca(int linha, int coluna) // Método para retornar uma peça que é privada para outra classe.
        {
            return pecas[linha, coluna];
        }

    }
}
