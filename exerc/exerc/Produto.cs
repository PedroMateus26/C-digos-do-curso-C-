using System;
using System.Collections.Generic;
using System.Text;

namespace exerc
{
    class Produto
    {
        public String Nome;
        public double Preco;
        public int Quantidade;

        public Produto(String nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }

        public double ValorTotalEmEstoque()
        {
            return Preco*Quantidade;
        }
        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }


    }
}
