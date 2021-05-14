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
                    if (tab.peca(i, j) == null) // Se a peça não tiver recebido um valor será mostrado um '-'.
                    {
                        Console.Write("-  ");
                    }
                    else
                    {
                        imprimirPeca(tab.peca(i, j)); // Usando o método do objeto 'tab' para ter acesso as informações da 'peca'.
                        Console.Write("  ");
                    }            
                }
                Console.WriteLine(""); //Pular para a linha abaixo após percorrer toda a coluna de uma linha.
            }
            Console.WriteLine("   a  b  c  d  e  f  g  h"); // Inserindo identificadores das colunas.


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
        }
    }
}