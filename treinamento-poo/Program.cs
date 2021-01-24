using System;
using System;
using treinamento_poo.Service;

namespace treinamento_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exibe menu de opções para o usuário selecionar

            Console.WriteLine(" ..:: Selecione uma opção ::..");
            Console.WriteLine();
            Console.WriteLine("1 - Depósito");
            Console.WriteLine("2 - Saque");
            Console.WriteLine("3 - Transferência");

            // obtem a opção selecionada pelo usuário
            var opcao = Console.ReadKey();

            switch (opcao.KeyChar)
            {
                case '1':
                    new ContaCorrenteService().OperacaoDeposito();
                    break;

                case '2':
                    new ContaCorrenteService().OperacaoSaque();
                    break;

                case '3':
                    new ContaCorrenteService().OperacaoTransferencia();
                    break;
            }
        }
    }
}
