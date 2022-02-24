using ExercVetores;
using System;
using System.Security.Cryptography.X509Certificates;

public class ex1
{
	public static void startAlg()
	{
		Console.WriteLine("Inicializado ex1.cs" + "\n");
		string[] arrayCapitais = new string[26] { "Aracaju", "Belém", "B. Horizonte", "Boa Vista", "Brasília", "C. Grande", "Cuiabá", "Curitiba", "Florianópolis", "Fortaleza", "Goiânia", "João Pessoa", "Macapá", "Maceió", "Manaus", "Natal", "Palmas", "Porto Alegre", "Porto Velho", "Recife", "Rio Branco", "R. Janeiro", "Savador", "São Luis", "Teresina", "Vitória" };
		double[] arrayKmFixo = new double[26] {1.731, 481, 489, 3.300, 873, 894, 1.326, 338, 489, 2.368, 810, 2.216, 2.664, 1.928, 2.689, 2.320, 1.493, 852, 2.463, 2.128, 2.704, 357, 1.435, 2.348, 2.792, 882};
		double[] arrayKmUser = new double[26];
		double[] arrayPreço = new double[26];
		double calculo=0;
		bool valuesEnteredByUser = false;
		
		int x = 0;
		Console.WriteLine("Informe os dados requisitados para calcularmos o preço total de viagens de São Paulo à todas as outras capitais do país.");
		Console.WriteLine("\n"+"já existem os valores de distância entre Sao Paulo à outras capitais do país. Pois, você deseja inserir os valores de distâncias em Km apesar de serem desnecessários no ciclo do processo? (sim/nao)");
		string confirmation = Console.ReadLine();

		if(confirmation == "sim")
		{
			for(x=0; x < arrayKmFixo.Length; x++)
			{
				arrayKmUser[x] = double.Parse(Console.ReadLine());
			}
			valuesEnteredByUser = true;
			Console.Write("Agora... ");
		}else if(confirmation == "não" || confirmation == "nao")
		{
			Console.WriteLine("Ok, prosseguindo...");
		}
		else if(confirmation != "não" && confirmation != "nao")
		{
			Console.WriteLine("Sessão ignorada, pois o argumento é inválido");
		}

		Console.WriteLine("\n"+"Informe o custo da viagem R$ a cada quilometro de São Paulo às capitais requisitadas (apenas de ida).");
		Console.WriteLine("\n"+"**para que o cálculo seja corretamente efetuado, você deve informar em formato de casas decimais (ex 10,50) apenas se houver valores diferentes de ,00 ou .00");
		for(x=0; x < arrayCapitais.Length; x++)
		{
			Console.Write("\n" + "até "+arrayCapitais[x]+": ");
			arrayPreço[x] = double.Parse(Console.ReadLine());
			
		}

		for(x=0; x < arrayCapitais.Length; x++)
		{
			/*esta condicional verifica se os valores de distância foram inseridos
			pelo usuário, se sim usa-se na base do cálculo os valores inseridos pelo usuário, senão usa-se os
			valores fixos.
			*/
			if (valuesEnteredByUser == true) 
			{
				calculo += 2*(arrayPreço[x] * arrayKmUser[x]);
				
				
			}
			else {

				calculo += 2*(arrayPreço[x] * arrayKmFixo[x]); //*2 porque representa o preço da passagem na ida e volta.
				
			}

			
			
		}
		
		Console.WriteLine("\n" + "\n" + "O preço total de todas as viagens de ida e volta à todas as capitais dos país resulta em: "+ calculo.ToString("C"));
		projectMenu.requisição();

	}


}
