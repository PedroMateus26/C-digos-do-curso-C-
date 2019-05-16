﻿using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace Xadrez
{
    class Bispo : Peca
    {
        public Bispo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "B";
        }
        public bool podeMover(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != this.Cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //NE
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna+1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != this.Cor) break;
                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            }

            //SE
            pos.definirValores(Posicao.Linha+1, Posicao.Coluna + 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != this.Cor) break;
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            }

            //NO
            pos.definirValores(Posicao.Linha -1 , Posicao.Coluna-1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != this.Cor) break;
                pos.definirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            }

            //SO
            pos.definirValores(Posicao.Linha+1, Posicao.Coluna - 1);
            while (Tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
                if (Tab.peca(pos) != null && Tab.peca(pos).Cor != this.Cor) break;
                pos.definirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            }

            return mat;
        }
    }
}
