using System;
using tabuleiro;
using Xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Tabuleiro tab = new Tabuleiro(8, 8);
                //tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao('c', 1));
                //tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                PartidadeXadrez partida = new PartidadeXadrez();
                Tela.imprimirTabuleiro(partida.tab);
             
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem,destino);
                }
                
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            
            /*PosicaoXadrez pos = new PosicaoXadrez('a',1);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());*/
        }
    }
}
