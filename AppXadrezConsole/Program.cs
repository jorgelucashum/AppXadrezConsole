using System;

using tabuleiro;

namespace AppXadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8); // Instanciando o tabuleiro de tamanho 8x8.
            Tela.imprimirTabuleiro(tab);
        }
    }
}
