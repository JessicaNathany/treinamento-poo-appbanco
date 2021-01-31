using System;
using treinamento_poo.Model;

namespace treinamento_poo.Service
{
    public class ContaCorrenteService
    {
        public void OperacaoSaque()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja sacar: " + "\n");

            var valor = Convert.ToDouble(Console.ReadLine());

            var conta = new ContaCorrente()
            {
                Agencia = 8792,
                Titular = "Jéssica",
                Numero = 36921,
                Saldo = 5000
            };

            var saque = Sacar(valor, conta.Saldo);

            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados da conta do cliente");
            Console.WriteLine();
            Console.WriteLine($"Olá {nome}," + "\n" + "saque realizado com sucesso!" + "\n" + $"Valor da retirada: {valor}" + "\n");
            Console.WriteLine($"Agencia: {conta.Agencia}" + "\n" + $"Numero: {conta.Numero}" + "\n" + $"Saldo: {saque}");
            Console.ReadKey();
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
        }

        public void OperacaoDeposito()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja depositar: " + "\n");

            var valor = Convert.ToDouble(Console.ReadLine());

            var conta = new ContaCorrente()
            {
                Agencia = 8792,
                Titular = "Jéssica",
                Numero = 36921,
                Saldo = 5000
            };

            var deposito = Depositar(valor, conta.Saldo);

            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados da conta do cliente");
            Console.WriteLine();
            Console.WriteLine($"Olá {nome}," + "\n" + "seu depósito foi realizado com sucesso!" + "\n" + $"Valor do depósito: {valor}" + "\n");
            Console.WriteLine($"Agencia: {conta.Agencia}" + "\n" + $"Numero: {conta.Numero}" + "\n" + $"Saldo: {deposito}");
            Console.ReadKey();
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
        }

        public void OperacaoTransferencia()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja transferir: " + "\n");

            var valor = Convert.ToDouble(Console.ReadLine());

            var conta = new ContaCorrente()
            {
                Agencia = 8792,
                Titular = "Jéssica",
                Numero = 36921,
                Saldo = 5000
            };

            var contaDestino = new ContaCorrente()
            {
                Agencia = 01415,
                Titular = "Dona Maria",
                Numero = 0001,
                Saldo = 1000
            };

            var transferencia = Transferir(valor, conta.Saldo, contaDestino);

            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados da conta do cliente");
            Console.WriteLine();
            Console.WriteLine($"Olá {nome}," + "\n" + "a transferência realizada com sucesso!" + "\n");
        }

        private double Sacar(double valor, double saldo)
        {
            if (valor > saldo)
            {
                Console.WriteLine($"Não foi possível concluir a transação. Seu saldo {saldo} é inferior ao valor do saque {valor}.");
                Console.ReadKey();
            }
            else
            {
                saldo -= valor;
                return saldo;
            }

            return saldo;
        }

        private double Depositar(double valor, double saldo)
        {
            saldo += valor;
            return saldo;
        }

        private bool Transferir(double valor, double saldo, ContaCorrente contaDestino)
        {
            if (saldo < valor)
            {
                Console.WriteLine($"Não foi possível concluir a transação. Seu saldo {saldo} é inferior ao valor que deseja transferir. {saldo}");
                Console.ReadKey();
            }

            saldo -= valor;
            Depositar(valor, saldo);
            Console.WriteLine($"Transferência realizada com sucesso! Seu saldo é de: {saldo}");
            Console.WriteLine();
            Console.WriteLine("Dados da conta destino");
            Console.WriteLine($"Nome: {contaDestino.Titular}" + "\n" + $"Agencia: {contaDestino.Agencia}" + "\n" + $"Numero: {contaDestino.Numero}" + "\n" + $"Valor transferido: {valor}");
            Console.ReadKey();
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
            return true;
        }
    }
}
