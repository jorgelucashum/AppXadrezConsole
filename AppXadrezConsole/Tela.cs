using System;
using xadrez;

using tabuleiro;

namespace AppXadrezConsole
{
    class Tela
    {

        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(tab.linhas - i + "  "); // Enumarando as linhas ao lado.
                for (int j = 0; j < tab.colunas; j++)
                {
                    imprimirPeca(tab.peca(i, j)); // Usando o método do objeto 'tab' para ter acesso as informações da 'peca'.        
                }
                Console.WriteLine(""); //Pular para a linha abaixo após percorrer toda a coluna de uma linha.
            }
            Console.WriteLine("   a  b  c  d  e  f  g  h"); // Inserindo identificadores das colunas.
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoePossiveis) // Sobrecarga para receber 'posicoesPossiveis' como 
        {
            //Variáveis com a cor de fundo do console
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(tab.linhas - i + "  "); // Enumerando as linhas ao lado.
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (posicoePossiveis[i, j])//Destacar as posições possíveis das peças quando selecionadas
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    imprimirPeca(tab.peca(i, j)); // Usando o método do objeto 'tab' para ter acesso as informações da 'peca'.   
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine(""); //Pular para a linha abaixo após percorrer toda a coluna de uma linha.
            }
            Console.WriteLine("   a  b  c  d  e  f  g  h"); // Inserindo identificadores das colunas.

            Console.BackgroundColor = fundoOriginal; //Garantir que o fundo da tela volte a cor original
        }


        public static PosicaoXadrez lerPosicaoXadrez() // Método para ler a entrada do usuário.
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + ""); // trasnformar em string
            return new PosicaoXadrez(coluna, linha);


        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca == null)
            {
                Console.Write("-  ");
            }
            else
            {

             if (peca.cor == Cor.Branca)
                {
                Console.Write(peca);
                }
             else
             {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
              }
                Console.Write("  ");
            }
        }
    }
}