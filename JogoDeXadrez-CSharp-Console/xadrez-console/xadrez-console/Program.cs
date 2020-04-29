using System;
using tabuleiro;
using xadrez;
using xadrez_console;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('C', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
                
            Console.ReadLine();
        }
    }
}
