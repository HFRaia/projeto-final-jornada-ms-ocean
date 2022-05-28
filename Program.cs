using ProjetoFinal_JornadaMS.Model;
using System;

namespace ProjetoFinal_JornadaMS
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Variável elevador é instanciada como uma nova instância da classe Elevador
			Elevador elevador = new Elevador();

			//Criação e inicialização das variáveis capacidade, andaresPredio e opcaoSelecionada
			int capacidade = 0, andaresPredio = 0, opcaoSelecionada = 0;

			//Criação da variável infoAtual que receberá as informações referentes ao andar atual e à lotação atual
			int infoAtual;

			//Solicitação que o usuário informe as informações relevantes para a inicialização da classe Elevador (capacidade total do elevador e quantidade de andares do prédio)
			Console.WriteLine("Informe as informações relevantes para a inicialização do programa.");

			//Estrutura de repetição do while é utilizada para repetir a solicitação da capacidade total enquanto um valor válido não for informado
			do
			{

				//Mensagem solicitando a capacidade total do elevador é apresentada ao usuário
				Console.Write("Capacidade total do elevador: ");

				//É feita uma verificação se o valor informado pelo usuário não é um inteiro ou se é menor ou igual a zero
				if (!int.TryParse(Console.ReadLine(), out capacidade) || capacidade <= 0)
				{
					//Caso o valor informado pelo usuário seja inválido, uma mensagem de erro é apresentada no console
					ApresentarMensagemErro("A capacidade total do elevador deve ser um inteiro maior que zero!\nInforme uma capacidade válida!");
				}

			} while (capacidade <= 0);

			//Estrutura de repetição do while é utilizada para repetir a solicitação da capacidade total enquanto um valor válido não for informado
			do
			{
				//Mensagem solicitando o total de andares do prédio é apresentada ao usuário
				Console.Write("Total de andares do prédio (desconsiderando o térreo): ");

				//É feita uma verificação se o valor informado pelo usuário não é um inteiro ou se é menor ou igual a zero
				if (!int.TryParse(Console.ReadLine(), out andaresPredio) || andaresPredio <= 0)
				{
					//Caso o valor informado pelo usuário seja inválido, uma mensagem de erro é apresentada no console
					ApresentarMensagemErro("A quantidade total de andares do prédio deve ser um inteiro maior que zero!\nInforme um valor válido para o total de andares!");
				}

			} while (andaresPredio <= 0);

			//Método inicializar é chamado, atribuindo os valores iniciais aos atributos do objeto elevador.
			elevador.Inicializar(capacidade, andaresPredio);

			//Estrutura de repetição do while é usada para apresentar o menu ao usuário enquanto ele não selecionar a opção de sair (opção 7)
			do
			{

				//O console é limpo, para que apenas o menu seja apresentado ao usuário
				Console.Clear();

				//O menu é apresentado ao usuário
				Console.WriteLine("Selecione uma ação a ser executada: " +
				"\n1 - Entrar - Executa a ação de uma pessoa entrar no elevador" +
				"\n2 - Sair - Executa a ação de uma pessoa sair do elevador" +
				"\n3 - Subir - Executa a ação de o elevador subir um andar" +
				"\n4 - Descer - Executa a ação de o elevador descer um andar" +
				"\n5 - Verificar andar atual - Apresenta o andar no qual o elevador está parado no momento" +
				"\n6 - Verificar lotação atual - Apresenta a quantidade de pessoas dentro do elevador no momento" +
				"\n7 - Encerrar - encerra a execução do programa");

				//verifica se uma opção válida foi inserida pelo usuário (inteiro acima de zero)
				if (!int.TryParse(Console.ReadLine(), out opcaoSelecionada) || opcaoSelecionada <= 0)
				{
					//Caso a opção inserida seja inválida, as ações abaixo são executadas
					//Limpa o console para apresentar a mensagem de erro
					Console.Clear();
					//Uma mensagem de erro é apresentada no console para o usuário
					ApresentarMensagemErro("Opção Inválida!\nSelecione uma opção válida (1 a 7)!");
					//É solicitado que o usuário pressione qualquer tecla para continuar. Isso foi feito para que o usuário possa ler a mensagem de erro calmamente.
					Console.WriteLine("Pressione qualquer tecla para continuar.");
					//Espera que o usuário pressione alguma tecla.
					Console.ReadKey();

					//O comando continue interrompe a execução do resto das instruções dentro da estrutura de repetição e inicia a próxima iteração do loop
					continue;
				}

				//Um bloco try catch é utilizado para manipular as exceções que podem ser lançadas pelas instruções presentes no bloco.
				try
				{
					//Bloco switch tratará um comportamento para cada opção do menu que pode ser selecionada pelo usuário
					switch (opcaoSelecionada)
					{
						//Caso a opção selecionada pelo usuário seja "1"
						case 1:
							//O método Entrar() da classe Elevador será executado
							elevador.Entrar();
							//Caso nenhuma exceção seja lançada por esse método, uma mensagem de sucesso é apresentada ao usuário
							ApresentarMensagemSucesso();
							break;

						//Caso a opção selecionada pelo usuário seja "2"
						case 2:
							//O método Sair() da classe Elevador será executado
							elevador.Sair();
							//Caso nenhuma exceção seja lançada por esse método, uma mensagem de sucesso é apresentada ao usuário
							ApresentarMensagemSucesso();
							break;
						
						//Caso a opção selecionada pelo usuário seja "3"
						case 3:
							//O método Subir() da classe Elevador será executado
							elevador.Subir();
							//Caso nenhuma exceção seja lançada por esse método, uma mensagem de sucesso é apresentada ao usuário
							ApresentarMensagemSucesso();
							break;
						
						//Caso a opção selecionada pelo usuário seja "4"
						case 4:
							//O método Descer() da classe Elevador será executado
							elevador.Descer();
							//Caso nenhuma exceção seja lançada por esse método, uma mensagem de sucesso é apresentada ao usuário
							ApresentarMensagemSucesso();
							break;
						
						//Caso a opção selecionada pelo usuário seja "5"
						case 5:
							//O método ObterAndarAtual() da classe Elevador será executado e seu retorno será atribuido à variável infoAtual
							infoAtual = elevador.ObterAndarAtual();
							//Adiciona-se um espaço de uma linha para separar a resposta do menu
							Console.WriteLine();
							//Informação sobre o andar atual é informada ao usuário. Utiliza-se um "if ternário" para que caso o andar atual seja zero, o texto "Térreo" será apresentado ao usuário,
							//caso o andar atual seja diferente de zero, um inteiro é apresentado ao usuário indicando o andar no qual o elevador se encontra
							Console.WriteLine("Andar atual: {0}\nQuantidade de andares do prédio: {1}", infoAtual == 0 ? "Térreo" : infoAtual, andaresPredio);
							break;
						
						//Caso a opção selecionada pelo usuário seja "6"
						case 6:
							//O método ObterLotacaoAtual() da classe Elevador será executado e seu retorno será atribuido à variável infoAtual
							infoAtual = elevador.ObterLotacaoAtual();
							//Adiciona-se um espaço de uma linha para separar a resposta do menu
							Console.WriteLine();
							//Informação sobre o andar atual é informada ao usuário. Utiliza-se um "if ternário" para que caso a lotação atual seja zero, o texto "Vazio" será apresentado ao usuário,
							//caso não seja, um outro "if ternário" verifica se a lotação atual é igual à capacidade total do elevador e, se essa condição for verdadeira, o texto "Cheio" será apresentado ao usuário.
							//Caso nenhuma das duas afirmações seja verdadeira, um inteiro mostrando a lotação usual é apresentado ao usuário.
							Console.WriteLine("Lotação atual: {0}\nLotação total do elevador: {1}", infoAtual == 0 ? "Vazio" : infoAtual == capacidade ? "Cheio" : infoAtual, capacidade);
							break;
						
						//Caso a opção selecionada pelo usuário seja "7"
						case 7:
							//Uma mensagem é apresentada ao usuário indicando a finalização da execução do programa
							Console.WriteLine("Finalizando execução do programa...");
							break;
						
						//Caso nenhuma opção válida seja selecionada pelo usuário
						default:
							//O console é limpo
							Console.Clear();
							//Uma mensagem de erro é apresentada ao usuário
							ApresentarMensagemErro("Opção Inválida!\nSelecione uma opção válida (1 a 7)!");
							break;
					}
				}
				//Captura as exceções que podem ter sido lançadas pelos métodos da classe Elevador
				catch (InvalidOperationException e)
				{
					//Caso algum método tenha lançado uma excessão, esta excessão será apresentada no console como uma mensagem de erro para o usuário
					ApresentarMensagemErro(e.Message);
				}

				//Após a execução de qualquer opção do menu, é solicitado que o usuário pressione qualquer tecla para continuar a execução do programa.
				Console.WriteLine("Pressione qualquer tecla para continuar.");
				Console.ReadKey();

			//O programa continuará sendo executado até que o usuário selecione a opção 7
			} while (opcaoSelecionada != 7);
		}

		/// <summary>
		/// Método que apresenta as mensagens de erro no console na cor vermelha para que seja mais fácil para o usuário distinguir essas mensagens das mensagens padrão.
		/// </summary>
		/// <param name="erro">
		/// Mensagem de erro a ser apresentada ao usuário
		/// </param>
		static void ApresentarMensagemErro(string erro)
		{
			//A cor da letra no console é alterada para vermelho
			Console.ForegroundColor = ConsoleColor.Red;

			//A mensagem de erro recebida por parâmetro é apresentada ao usuário
			Console.WriteLine(erro);

			//Retorna a cor da letra no console para a coloração padrão
			Console.ResetColor();
		}

		/// <summary>
		/// Método que apresenta uma mensagem que a operação foi realizada com sucesso. Esta mensagem é apresentada no console com a cor verde.
		/// </summary>
		static void ApresentarMensagemSucesso()
		{
			//A cor da letra no console é alterada para verde
			Console.ForegroundColor = ConsoleColor.Green;
			
			//A mensagem de sucesso é apresentada ao usuário
			Console.WriteLine("Operação realizada com sucesso!");
			
			//Retorna a cor da letra no console para a coloração padrão
			Console.ResetColor();
		}
	}
}
