 using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro Tab{ get; set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.Posicao = null;
            this.Cor = cor;
            this.Tab = tab;
            this.qteMovimentos = 0;
        }
        
        public void incrementarQteMovimentos()
        {
            this.qteMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
        
    }
}
