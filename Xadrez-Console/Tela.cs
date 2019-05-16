﻿using tabuleiro;
using System;
using Xadrez;
using System.Collections.Generic;
namespace Xadrez_Console
{
    class Tela
    {

        public static void imprimirPartida(PartidadeXadrez partida)
        {
            imprimirTabuleiro(partida.tab); 
            Console.WriteLine();
            imprimirPecasCapturadas(partida);
            Console.WriteLine();
            Console.WriteLine("Turno " + partida.turno);
            if (!partida.terminada)
            {
                
                Console.WriteLine("Aguardando jogada das peças " + partida.jogadorAtual);
                if (partida.xeque) Console.WriteLine("XEQUE!");

            }

            else
            {
                
                Console.WriteLine("XEQUEMATE!");
                Console.WriteLine("Vencedor " + partida.jogadorAtual);
                Console.WriteLine();
            }

        }

        public static void imprimirPecasCapturadas(PartidadeXadrez partida)
        {
            Console.WriteLine("Peças capturadas: ");
            Console.Write("Brancas ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.Write("Pretas ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
        }
        public static void imprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[ ");
            foreach(Peca x in conjunto)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine (" ]");
        }
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    imprimirPeca(tab.peca(i, j));

                }
                Console.WriteLine();

            }

            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool [,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;
            for (int i = 0; i < tab.Linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (posicoesPossiveis[i, j]) Console.BackgroundColor = fundoAlterado;
                    else Console.BackgroundColor = fundoOriginal;
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;

                }
                Console.WriteLine();

            }

            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = fundoOriginal;
        }


        public static PosicaoXadrez lerPosicaoXadrez()
        {
            String s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirPeca(Peca peca)
        {
            if (peca == null) Console.Write("- ");
            else
            {


                if (peca.Cor == Cor.Branca)
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
                Console.Write(" ");
            }
        }
    }
}
