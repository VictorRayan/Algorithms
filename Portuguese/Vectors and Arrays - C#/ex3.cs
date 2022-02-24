using ExercVetores;
using System;

class ex3
{
	public static void startAlg()
	{
		int [] número = new int[350];
		int qntMúltiplosOnze = 0;
		int qntPares = 0;
		int qntNegativos = 0;
		int perNegativos = 0;
		int somaMúltiplosDeCinco = 0;

		Console.WriteLine("Inicializado ex3.cs");
		Console.WriteLine("Informe 350 números para levantarmos determinadas informações.");
		Console.Write("\n"+"Digite o ");

		for(int i = 0; i < número.Length; i++)
		{
			Console.WriteLine((i+1) + "° número:");

			número[i] = int.Parse(Console.ReadLine());
			
			//verifica quantidade de múltiplos de 11 e pares na Array...
			if(número[i] % 11 == 0)
			{
				qntMúltiplosOnze++;

				if (número[i] % 2 == 0)
				{
					qntPares++;
				}
			}

			//verifica a quantidade de valores negativos armazenados na Array...
			if (número[i] < 0)
			{
				qntNegativos++;
				
				//fora do bloco "for" ocorre o cálculo da porcentagem de negativos diante de 350 números...
			}

			//faz a soma dos múltiplos de cinco...
			if(número[i] % 5 == 0)
			{
				somaMúltiplosDeCinco += número[i];
			}

		}

		//cálculo do percentual de negativos...
		perNegativos = 350 / 100 * (qntNegativos);

		//Abaixo exibe os valores abaixo dos cálculos e levantamentos das Arrays (Matrizes) ou Vetores...

		Console.WriteLine("Múltiplos de onze: "+ qntMúltiplosOnze+" sendo "+qntPares+" múltiplos pares");
		Console.WriteLine("Perccentual de negativos dós números informados " + perNegativos);
		Console.WriteLine("Soma dos valores múltiplos de 5: "+perNegativos);
		projectMenu.requisição();


	}
}
