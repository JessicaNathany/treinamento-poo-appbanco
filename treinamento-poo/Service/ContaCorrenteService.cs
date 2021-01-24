using System;
using treinamento_poo.Model;

namespace treinamento_poo.Service
{
    /// <summary>
    /// Nesta classe vamos manter todas as regras de negócio da nossa pequena aplicação
    /// </summary>
    public class ContaCorrenteService
    {
        public void OperacaoSaque()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja sacar: " + "\n");


            // mplemente a ação sacar aqui e exiba as informações para o usuário...
        }

        public void OperacaoDeposito()
        {
            Console.WriteLine();
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja depositar: " + "\n");


            // implemente a ação depositar aqui e exiba as informações para o usuário...
        }

        public void OperacaoTransferencia()
        {
            Console.WriteLine("Digite seu nome: " + "\n");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor que deseja transferir: " + "\n");

            // implemente a ação transferir aqui e exiba as informações para o usuário
        }

        // criar os métodos Sacar, Depositar e Transferir como private
    }
}
