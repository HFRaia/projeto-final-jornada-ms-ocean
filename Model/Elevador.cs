using System;

namespace ProjetoFinal_JornadaMS.Model
{
	public class Elevador
	{
		//A seguir estão definidos os atributos da classe Elevador
		#region Atributos
		//Atributo Capacidade: indica a capacidade total de pessoas que podem estar dentro do elevador ao mesmo tempo.
		private int Capacidade { get; set; }
		//Atributo TotalAndaresPredio: Indica a quantidade total de andares que o prédio possui, desconsiderando o térreo.
		private int TotalAndaresPredio { get; set; }
		//Atributo AndarAtual: Indica o andar no qual o elevador se encontra em determinado momento.
		private int AndarAtual { get; set; }
		//Atributo NumPessoasDentroElevador: Indica o número de pessoas que estão dentro do elevador em determinado momento.
		private int NumPessoasDentroElevador { get; set; }
		#endregion

		//A seguir estão definidos os métodos da classe Elevador
		#region Métodos
		/// <summary>
		/// O método Inicializar define os valores iniciais necessários para a execução do programa.
		/// Os parâmetros deste método são:
		/// capacidade, que define a capacidade total de pessoas permitida dentro do elevador e
		/// totalAndaresPredio, que define a quantidade total de andares que o prédio possui, desconsiderando o térreo.
		/// Ambos os parâmetros são do tipo inteiro.
		/// </summary>
		/// <param name="capacidade">
		/// Capacidade total do elevador
		/// </param>
		/// <param name="totalAndaresPredio">
		/// Quantidade total de andares do prédio
		/// </param>
		public void Inicializar(int capacidade, int totalAndaresPredio)
		{
			Capacidade = capacidade;
			TotalAndaresPredio = totalAndaresPredio;
			AndarAtual = 0;
			NumPessoasDentroElevador = 0;

			Console.WriteLine();
		}

		/// <summary>
		/// O método Entrar simula a ação de uma nova pessoa entrar no elevador.
		/// Este método verifica se a quantidade de pessoas dentro do elevador é igual à capacidade, caso seja, uma excessão é lançada dizendo que o elevador já encontra-se na capacidade máxima.
		/// Caso a quantidade de pessoas dentro do elevador seja inferior à capacidade, então o atributo NumPessoasDentroElevador será incrementado.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// Excessão informando que o elevador já encontra-se lotado
		/// </exception>
		public void Entrar()
		{
			if (Capacidade == NumPessoasDentroElevador)
			{
				throw new InvalidOperationException("Elevador já está na capacidade máxima!");
			}
			NumPessoasDentroElevador++;
		}

		/// <summary>
		/// O método Sair simula a ação de uma nova pessoa entrar no elevador.
		/// Este método verifica se a quantidade de pessoas dentro do elevador é igual a 0 (zero), caso seja, uma excessão é lançada dizendo que o elevador já encontra-se vazio.
		/// Caso a quantidade de pessoas dentro do elevador seja acima de 0 (zero), então o atributo NumPessoasDentroElevador será decrementado.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// Excessão informando que o elevador já se encontra vazio
		/// </exception>
		public void Sair()
		{
			if (NumPessoasDentroElevador == 0)
			{
				throw new InvalidOperationException("Elevador já está vazio!");
			}
			NumPessoasDentroElevador--;
		}

		/// <summary>
		/// O método Subir simula a ação de o elevador se mover ao andar superior.
		/// Este método verifica se o elevador já encontra-se no último andar do prédio, caso esteja, uma excessão é lançada dizendo que o elevador já encontra-se no último andar.
		/// Caso o elevador não se encontre no último andar, então o atributo AndarAtual será incrementado.
		/// </summary>
		/// <exception cref="InvalidOperationException"></exception>
		public void Subir()
		{
			if (AndarAtual == TotalAndaresPredio)
			{
				throw new InvalidOperationException("Elevador já está no último andar!");
			}
			AndarAtual++;
		}

		/// <summary>
		/// O método Descer simula a ação de o elevador se mover para o andar inferior.
		/// Este método verifica se o elevador já encontra-se no térreo (andar 0) do prédio, caso esteja, uma excessão é lançada dizendo que o elevador já encontra-se no térreo.
		/// Caso o elevador não se encontre no térreo (andar 0), então o atributo AndarAtual será decrementado.
		/// </summary>
		/// <exception cref="InvalidOperationException"></exception>
		public void Descer()
		{
			if (AndarAtual == 0)
			{
				throw new InvalidOperationException("Elevador já está no térreo!");
			}
			AndarAtual--;
		}

		/// <summary>
		/// O método ObterAndarAtual verifica o andar no qual o elevador está no momento e retorna essa informação.
		/// </summary>
		/// <returns>
		/// Andar no qual o elevador está no momento.
		/// </returns>
		public int ObterAndarAtual()
		{
			return AndarAtual;
		}

		/// <summary>
		/// O método ObterLotacaoAtual verifica a quantidade de pessoas dentro do elevador no momento e retorna essa informação.
		/// </summary>
		/// <returns>
		/// Quantidade de pessoas dentro do elevador no momento.
		/// </returns>
		public int ObterLotacaoAtual(){
			return NumPessoasDentroElevador;
		}
		#endregion
	}
}
