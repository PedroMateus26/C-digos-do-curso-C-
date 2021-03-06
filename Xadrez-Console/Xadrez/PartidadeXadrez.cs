﻿using System;
using tabuleiro;
using System.Collections.Generic;

namespace Xadrez
{
    class PartidadeXadrez
    {
        public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
        public bool terminada = false;
        private HashSet<Peca> pecas;
        private HashSet<Peca> capturadas;
        public bool xeque { get; private set; }
        public Peca vulneravelEnPassant { get; private set; }


        public PartidadeXadrez()
        {
            this.tab = new Tabuleiro(8, 8);
            this.turno = 1;
            this.jogadorAtual = Cor.Branca;
            xeque = false;
            vulneravelEnPassant = null;
            pecas = new HashSet<Peca>();
            capturadas = new HashSet<Peca>();
            colocarPecas();

        }

        public Peca executaMovimento(Posicao origem, Posicao destino)
        {

            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);

            if (pecaCapturada != null) capturadas.Add(pecaCapturada);

            //Roque pequeno
            if (p is Rei && destino.Coluna == origem.Coluna + 2)
            {
                Posicao origemT = new Posicao(origem.Linha, origem.Coluna + 3);
                Posicao destinoT = new Posicao(origem.Linha, origem.Coluna + 1);
                Peca T = tab.retirarPeca(origemT);
                T.incrementarQteMovimentos();
                tab.colocarPeca(T, destinoT);
            }
            //Roque grande
            if (p is Rei && destino.Coluna == origem.Coluna - 2)
            {
                Posicao origemT = new Posicao(origem.Linha, origem.Coluna - 4);
                Posicao destinoT = new Posicao(origem.Linha, origem.Coluna - 1);
                Peca T = tab.retirarPeca(origemT);
                T.incrementarQteMovimentos();
                tab.colocarPeca(T, destinoT);
            }
            //Enpassant
            if(p is Peao)
            {
                if(origem.Coluna != destino.Coluna && pecaCapturada == null)
                {
                    Posicao posP;
                    if (p.Cor == Cor.Branca)
                    {
                        posP = new Posicao(destino.Linha + 1, destino.Coluna);
                    }
                    else
                    {
                        posP = new Posicao(destino.Linha - 1, destino.Coluna);
                    }
                    pecaCapturada = tab.retirarPeca(posP);
                    capturadas.Add(pecaCapturada);
                }
            }
            return pecaCapturada;
        }

        public void desfazMovimento(Posicao origem, Posicao destino, Peca pecaCapturada)
        {
            Peca p = tab.retirarPeca(destino);
            p.decrementarQteMovimentos();
            if (pecaCapturada != null)
            {
                tab.colocarPeca(pecaCapturada, destino);
                capturadas.Remove(pecaCapturada);

            }
            tab.colocarPeca(p, origem);
            //Roque pequeno
            if (p is Rei && destino.Coluna == origem.Coluna + 2)
            {
                Posicao origemT = new Posicao(origem.Linha, origem.Coluna + 3);
                Posicao destinoT = new Posicao(origem.Linha, origem.Coluna + 1);
                Peca T = tab.retirarPeca(destinoT);
                T.decrementarQteMovimentos();
                tab.colocarPeca(T, origemT);
            }
            //Roque pequeno
            if (p is Rei && destino.Coluna == origem.Coluna - 2)
            {
                Posicao origemT = new Posicao(origem.Linha, origem.Coluna - 3);
                Posicao destinoT = new Posicao(origem.Linha, origem.Coluna - 1);
                Peca T = tab.retirarPeca(destinoT);
                T.decrementarQteMovimentos();
                tab.colocarPeca(T, origemT);
            }
            //Enpassant
            if(p is Peao)
            {
                if(origem.Coluna!=destino.Coluna && pecaCapturada == vulneravelEnPassant)
                {
                    Peca peao = tab.retirarPeca(destino);
                    Posicao posP;
                    if (p.Cor == Cor.Branca)
                    {
                        posP = new Posicao(3, destino.Coluna);
                    }
                    else
                    {
                        posP = new Posicao(4, destino.Coluna);
                    }
                    tab.colocarPeca(peao, posP);
                }
            }
        }

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            Peca pecaCapturada = executaMovimento(origem, destino);
            if (estaEmXeque(jogadorAtual))
            {
                desfazMovimento(origem, destino, pecaCapturada);
                throw new TabuleiroException("Você não se pode colocar me xeque!");
            }

            //Jogada especial Promoção
            Peca p = tab.peca(destino);
            if(p is Peao)
            {
                if ((p.Cor == Cor.Branca && destino.Linha == 0) || ((p.Cor == Cor.Preta && destino.Linha == 7)))
                {
                    p = tab.retirarPeca(destino);
                    pecas.Remove(p);
                    
                    Console.Write("Entre com o valor  para o tipo de peça desejado: 1-cavalo, 2,bispo , 3-torre e 4-dama: ");
                    int n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            Peca Cavalo = new Cavalo(tab, p.Cor);
                            tab.colocarPeca(Cavalo, destino);
                            pecas.Add(Cavalo);
                            break;
                        case 2:
                            Peca Bispo = new Bispo(tab, p.Cor);
                            tab.colocarPeca(Bispo, destino);
                            pecas.Add(Bispo);
                            break;
                        case 3:
                            Peca Torre = new Torre(tab, p.Cor);
                            tab.colocarPeca(Torre, destino);
                            pecas.Add(Torre);
                            break;
                        case 4:
                            Peca Dama = new Dama(tab, p.Cor);
                            tab.colocarPeca(Dama, destino);
                            pecas.Add(Dama);
                            break;
                    }
                    
                }
                

                
            }

            if (estaEmXeque(corAdversaria(jogadorAtual))) xeque = true;
            else xeque = false;

            if (testeXequeMate(corAdversaria(jogadorAtual)))
            {
                terminada = true;
            }
            else
            {
                turno++;
                mudaJogador();
            }

            
            //Jogada especial enpassant
            if (p is Peao && (destino.Linha == origem.Linha - 2 || destino.Linha == origem.Linha + 2))
            {
                vulneravelEnPassant = p;
            }
            else vulneravelEnPassant= null;

        }

        public bool testeXequeMate(Cor cor)
        {
            if (!estaEmXeque(cor)) return false;

            foreach (Peca x in pecasEmJogo(cor))
            {
                bool[,] mat = x.movimentosPossiveis();
                for (int i = 0; i < tab.Linhas; i++)
                {
                    for (int j = 0; j < tab.Colunas; j++)
                    {
                        if (mat[i, j])
                        {
                            Posicao origem = x.Posicao;
                            Posicao destino = new Posicao(i, j);
                            Peca pecaCapturada = executaMovimento(origem, destino);
                            bool testeXeque = estaEmXeque(cor);
                            desfazMovimento(origem, destino, pecaCapturada);
                            if (!testeXeque) return false;
                        }
                    }
                }
            }
            return true;
        }

        public void validarPosicaoDeOrigem(Posicao pos)
        {
            if (tab.peca(pos) == null) throw new TabuleiroException("Não existe peça na posição escolhida!");
            if (jogadorAtual != tab.peca(pos).Cor) throw new TabuleiroException("A peça de orgigem escohida não é sua!");
            if (!tab.peca(pos).existeMovimentosPossiveis()) throw new TabuleiroException("Não há movimentos possíveis para a peça de origem escolhida!");
        }

        public void validarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!tab.peca(origem).movimentoPossivel(destino)) throw new TabuleiroException("Posição de destino inválida!");


        }

        public void mudaJogador()
        {
            if (jogadorAtual == Cor.Branca) jogadorAtual = Cor.Preta;
            else jogadorAtual = Cor.Branca;
        }

        public HashSet<Peca> pecasCapturadas(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in capturadas)
            {
                if (x.Cor == cor)
                {
                    aux.Add(x);
                }
            }
            return aux;
        }

        public HashSet<Peca> pecasEmJogo(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in pecas)
            {
                if (x.Cor == cor)
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(pecasCapturadas(cor));
            return aux;
        }

        private Cor corAdversaria(Cor cor)
        {
            if (cor == Cor.Branca) return Cor.Preta;
            else return Cor.Branca;

        }

        private Peca rei(Cor cor)
        {
            foreach (Peca x in pecasEmJogo(cor))
            {
                if (x is Rei) return x;

            }

            return null;
        }

        public bool estaEmXeque(Cor cor)
        {
            Peca R = rei(cor);
            if (R == null) throw new TabuleiroException("Não há rei da cor " + cor + " no tabuleiro");
            foreach (Peca x in pecasEmJogo(corAdversaria(cor)))
            {
                bool[,] mat = x.movimentosPossiveis();
                if (mat[R.Posicao.Linha, R.Posicao.Coluna]) return true;
            }
            return false;
        }

        public void colocarNovaPeca(char coluna, int linha, Peca peca)
        {
            tab.colocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
            pecas.Add(peca);
        }

        private void colocarPecas()
        {


            colocarNovaPeca('a', 1, new Torre(tab, Cor.Branca));
            colocarNovaPeca('b', 1, new Cavalo  (tab,  Cor.Branca));
            colocarNovaPeca('c', 1, new Bispo   (tab,  Cor.Branca));
            colocarNovaPeca('d', 1, new Dama    (tab,  Cor.Branca));
            colocarNovaPeca('e', 1, new Rei(tab, Cor.Branca, this));
            colocarNovaPeca('f', 1, new Bispo   (tab,  Cor.Branca));
            colocarNovaPeca('g', 1, new Cavalo  (tab,  Cor.Branca));
            colocarNovaPeca('h', 1, new Torre(tab, Cor.Branca));
            colocarNovaPeca('a', 2, new Peao(tab, Cor.Branca, this));
            colocarNovaPeca('b', 2, new Peao(tab, Cor.Branca, this));
            colocarNovaPeca('c', 2, new Peao(tab, Cor.Branca, this));
            colocarNovaPeca('d', 2, new Peao(tab, Cor.Branca, this));
            colocarNovaPeca('e', 2, new Peao(tab, Cor.Branca, this));
            colocarNovaPeca('f', 2, new Peao(tab, Cor.Branca, this));
            colocarNovaPeca('g', 2, new Peao(tab, Cor.Branca, this));
            colocarNovaPeca('h', 2, new Peao(tab, Cor.Branca, this));

            colocarNovaPeca('a', 8, new Torre(tab, Cor.Preta));
            colocarNovaPeca('b', 8, new Cavalo(tab, Cor.Preta));
            colocarNovaPeca('c', 8, new Bispo (tab, Cor.Preta));
            colocarNovaPeca('d', 8, new Dama  (tab, Cor.Preta));
            colocarNovaPeca('e', 8, new Rei(tab, Cor.Preta, this));
            colocarNovaPeca('f', 8, new Bispo (tab, Cor.Preta));
            colocarNovaPeca('g', 8, new Cavalo(tab, Cor.Preta));
            colocarNovaPeca('h', 8, new Torre(tab, Cor.Preta));
            colocarNovaPeca('a', 7, new Peao(tab, Cor.Preta, this));
            colocarNovaPeca('b', 7, new Peao(tab, Cor.Preta, this));
            colocarNovaPeca('c', 7, new Peao(tab, Cor.Preta, this));
            colocarNovaPeca('d', 7, new Peao(tab, Cor.Preta, this));
            colocarNovaPeca('e', 7, new Peao(tab, Cor.Preta, this));
            colocarNovaPeca('f', 7, new Peao(tab, Cor.Preta, this));
            colocarNovaPeca('g', 7, new Peao(tab, Cor.Preta, this));
            colocarNovaPeca('h', 7, new Peao(tab, Cor.Preta, this));


        }

    }
}
