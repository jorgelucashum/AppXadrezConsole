using System;

using tabuleiro;

namespace AppXadrezConsole
{
    class Tela
    {

        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null) // Se a peça não tiver recebido um valor será mostrado um '-'.
                    {
                        Console.Write("-  ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + "  "); // Usando o método do objeto 'tab' para ter acesso as informações da 'peca'.
                    } 
                }
                Console.WriteLine(""); //Pular para a linha abaixo após percorrer toda a coluna de uma linha.
            }

        }
    }
}