using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class Conta
    {
 
        public string Nome { get; set; }
        public uint NumConta { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string nome, uint numConta, double depositoInicial)
        {
            Nome = nome;
            NumConta = numConta;
            Deposito(depositoInicial);
            
        }
        public Conta(string nome, uint numConta)
        {
            Nome = nome;
            NumConta = numConta;
        }
        public void Deposito(double deposito)
        {
            if(deposito > 0)
            {
                Saldo += deposito;
            } else
            {
                Console.WriteLine(" Erro ao realizar o depósito, por favor tente novamente !");
            }
        } 
        public void Saque(double saque)
        {
           Saldo -= saque + 5.00;
        }
        
    }

    
}
