using ExercVetores;
using System;

class ex9
{
	public static void startAlg()
	{
		int [] número = new int[20];
		int qntImpares = 0;
		int qntNegativos = 0;
		int qntMúltiplos_de_sete = 0;

		Console.WriteLine("Inicializado ex9.cs");
		Console.WriteLine("\n" + "Informe um intervalo de 20 números inteiros para analisar-se a quantidade de números ímpares, inteiros e múltiplos de 7");
		Console.Write("Informe o ");
		for(int i = 0; i < número.Length; i++)
		{
			Console.WriteLine((i + 1) + "° número:   ");
			número[i] = int.Parse(Console.ReadLine());

			if(número[i] % 2 != 0)
			{
				qntImpares++;
			}
			if(número[i] % 7 == 0)
			{
				qntMúltiplos_de_sete++;
			}
			if(número[i] < 0)
			{
				qntNegativos++;
			}

			
		}
		Console.WriteLine("\n" + "Diante do intervalo informado, temos:");
		Console.WriteLine(qntImpares + " números ímpares;");
		Console.WriteLine(qntNegativos + " múltiplos de sete");
		Console.WriteLine(qntNegativos + " números negativos");

		projectMenu.requisição();
	}
}