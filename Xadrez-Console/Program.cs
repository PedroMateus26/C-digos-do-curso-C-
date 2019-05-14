﻿using System;
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
                    try
                    {
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno " + partida.turno);
                        Console.WriteLine("Aguardando jogada das peças " + partida.jogadorAtual);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();
                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
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
