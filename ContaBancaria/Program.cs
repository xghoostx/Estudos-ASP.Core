using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositoInicial;
            Conta novaConta;

            Console.WriteLine("Cadastro de novo usuário: ");
            Console.WriteLine("Por favor digite o nome do usuário");
            string nome = Console.ReadLine();
            Console.WriteLine("Por favor digite o número da nova conta");
            uint numConta = uint.Parse(Console.ReadLine());

            Console.WriteLine("Deseja fazer um depósito inicial ? Sim(s) Não( Aperte qualquer tecla )");
            string esc = Console.ReadLine();

            if(esc == "s")
            {
                Console.WriteLine("Por favor digite o valor a ser depositado: ");
                depositoInicial = double.Parse(Console.ReadLine());
                novaConta = new Conta(nome, numConta, depositoInicial);
            } else
            {
                novaConta = new Conta(nome, numConta);
            }

            Console.WriteLine("Deseja realizar um depósito: Sim (s) Não( Aperte qualquer tecla )");
            string esc1 = Console.ReadLine();

            if (esc1 == "s" || esc1 == "S")
            {
                Console.WriteLine("Por favor digite o valor a ser depositado: ");
                double deposito = double.Parse(Console.ReadLine());
                novaConta.Deposito(deposito);
                Console.WriteLine("Deposito realizado com sucesso ! Saldo atual: " + novaConta.Saldo);
            }

            Console.WriteLine("Deseja realizar um saque: Sim (s) Não( Aperte qualquer tecla )");
            string esc2 = Console.ReadLine();

            if (esc2 == "s" || esc2 == "S")
            {
                Console.WriteLine("Por favor digite o valor do saque: ");
                double saque = double.Parse(Console.ReadLine());
                novaConta.Saque(saque);
                Console.WriteLine("Saque realizado com sucesso ! Saldo atual: " + novaConta.Saldo);
            }
        }
    }
}
