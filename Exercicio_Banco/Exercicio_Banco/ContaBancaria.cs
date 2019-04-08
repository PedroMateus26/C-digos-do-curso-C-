using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Banco
{
    class ContaBancaria
    {
        private int _numConta;
        public double Saldo { get; private set; }
        public String Nome { get; set; }
        public bool contaAtiva;
        




        public ContaBancaria(String nome, int numConta)
        {
            this.Nome = nome;
            this._numConta = numConta;
            this.Saldo = 0;
            this.contaAtiva = false;

        }

        public int NumConta
        {
            get { return this._numConta; }
        }

        public void AbrirConta()
        {
            Console.WriteLine("Sua conta foi aberta\n");
            Console.WriteLine("Deseja deposista algo incialmente? s para sim, n para não\n");
            char decisao = char.Parse(Console.ReadLine());
            if (decisao == 's')
            {
                Console.WriteLine("Entre com a quantia inicial\n");
                double saldoInicial = double.Parse(Console.ReadLine());
                this.Saldo += saldoInicial;
                Console.WriteLine("Muito bem! Seu saldo inicial agora é de \n" + this.Saldo);
                this.contaAtiva = true;
            } 
            else
            {
                Console.WriteLine("Seu saldo incial é de \n" + this.Saldo);
                this.contaAtiva = true;
            }
        }

        public void Deposito(double quantidade)
        {
            Console.WriteLine("Você executou a operação de deposito.\n");
            this.Saldo += quantidade;
            Console.WriteLine("Você depositou "+quantidade+ " reais\n");
            Console.WriteLine("O valor total da sua conta é de \n" + this.Saldo);
        }

        public void Saque(double saque)
        {
            Console.WriteLine("Você solicitou a operação de saque.\n ");
            this.Saldo -= (saque+5);
            Console.WriteLine("Você retirou "+saque+" reais de sua conta \n");
            Console.WriteLine("Seu saldo atual é de \n"+this.Saldo);

        }
        public void FecharConta()
        {
            if (this.Saldo > 0) Console.WriteLine("Contas não podem ser fechadas com saldos positivos\n");

            else Console.WriteLine("Conta fechada com sucesso!\n");

        }

        public void EstatusConta()
        {
            Console.WriteLine("Nome: "+this.Nome);
            Console.WriteLine("Numero da conta "+this._numConta);
            Console.WriteLine("Saldo atual: "+this.Saldo);
            Console.Write("sitiação da conta: ");
            if (contaAtiva) Console.WriteLine("Ativa");
            else Console.WriteLine("Inativa");
        }
    }
}
