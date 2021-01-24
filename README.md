# treinamento-poo-appbanco
:computer: :blue_book: 

Este é o repositório foi criado para turma Carreira Única do treinamento Programação Orientado a Objetos. Este é o desafio que vocês terão que concluir. Leia as informações abaixo:
 
 <h4 align="center"> 
	🚧  Projeto 🚀 Em construção...  🚧
 </h4>
 
 ### Siga as instruções do roteiro :page_facing_up:
 
## Criação da classe ContaCorrente
##### 1 - Crie a classe ContaCorrente é a nossa entidade e você deverá cria-la dentro da pasta Model, com os seguintes atributos: 
- Titular string
- Agencia int
- Numero int
- Saldo double

## Criação da classe ContaCorrenteService
##### 2 - Crie a classe ContaCorrente é a nossa de serviço onde contém nossas regras de negócio e você deverá cria-la dentro da pasta Service, e nela deve conter: 
- Método OperacaoSaque do tipo void (sem retorno):heavy_check_mark:
- Método OperacaoDeposito do tipo void (sem retorno) :heavy_check_mark:
- Método OperacaoTransferencia do tipo void (sem retorno) :heavy_check_mark:


## Criação dos métodos privados
##### 3 - Crie os métodos privados abaixo: 
- Método Sacar() deve ser privado e recebe um double valor e double saldo, deverá fazer o cálculo para sacar o valor e exibir mensagem ao usuário " Não foi possível concluir a transação. Seu saldo é inferior ao valor do saque!" caso o usuário informe um valor de saque maior do que tem em sua conta.
- Método Depositar() deve ser privado e recebe um double valor e double saldo, a funcionaldiade é adicionar o valor na conta do usuário. 
- Método Transferir() deve ser privado e recebe um double valor, double saldo e uma conta corrente destino, você deverá instanciar dois objetos conta corrente 1 conta corrente de origem e uma conta corrente de destino. Esse método deverá exibir a mensagem: "ão foi possível concluir a transação. Seu saldo é inferior ao valor que deseja transferir!" caso o saldo seja menior que o valor da transferência.

## Criação dos Métodos
##### 4 - Os métodos acima foram criados mas é preciso implementar sua funcionalidade, conforme descrito abaixo:
- OperacaoSaque =>  deve chamar o método Saque e realizar as operações de entrada e saída das informações para o usuário
- OperacaoDeposito => deve chamar o método Depósito e realizar as operações de entrada e saída das informações para o usuário
- OperacaoTransferencia => deve chamar o método Transferir e realizar as operações de entrada e saída das ifnormações para o usuário


É aconselhável realizar a consulta e utilizar como referência o projeto do repositório (https://github.com/JessicaNathany/treinamento-poo) que foi utilizado nos estudos em aula.Nele vocês podem obter a sintaxe do c#, código para exibir mensagem para o usuário Console.WriteLine() e instância de objeto.


Um desafio a mais para você colocar mais em prática os conceitos. Seguin como base a ContaCorrente, crie uma entidade ContaInvestimento e ContaInvestimentoService e faça as mesmas ações ou até mais ações da ContaCorrente, você pode utilizar a Herança e criar uma superclasse para as subclasses ContaCorrente e ContaInvestimento.
