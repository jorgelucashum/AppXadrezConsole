﻿ 
namespace tabuleiro
{
    abstract class Peca // Clase genérica.
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qntMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qntMovimentos = 0;
        }

        public void incrementarQntMovimentos()
        {
            qntMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();

    }
}
