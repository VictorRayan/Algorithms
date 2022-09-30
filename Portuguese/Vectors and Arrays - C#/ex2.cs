using ExercVetores;
using System;
using System.Security.Cryptography.X509Certificates;

public class ex2
{
	public static void startAlg()
	{
		int[] andaresPrédio = new int[40];
		int andarMaior = 0;
		int média = 0;
		int repetidos = 0;

		Console.WriteLine("Inicializado ex2.cs");
		Console.WriteLine("Informe a quantidade de pessoas por andar que utilizam o elevador. (um andar de cada vez)");

		for (int x = 0; x < 40; x++)
		{
			Console.Write(x + 1 + "° andar: ");
			andaresPrédio[x] = int.Parse(Console.ReadLine());
			média += andaresPrédio[x];
		}

		média /= 40;

		Console.Clear();
		Console.WriteLine("Algoritmo: ex2.cs" + "\n");
		Console.WriteLine("A média de pessoas no prédio que utilizam o elevador é de " + média + " pessoas.");

		int count = 0;
		while (count < 40)
		{

			if (andarMaior < andaresPrédio[count])
			{
				andarMaior = count;
			}

			for (int i = 0; i < 40; i++)
			{
				if (andaresPrédio[count] == andaresPrédio[i])
				{
					repetidos++;
				}
			}

			count++;
			
		}
		
		if (repetidos < 1600)
		{
			Console.WriteLine("O andar que mais tem fluxo de pessoas no uso do elevador é o " + andarMaior + "°.");
		}
		else
		{
			Console.WriteLine("Todos os andares tem o mesmo fluxo de pessoas que usam o elevador.");
		}

		projectMenu.startMenu();
	}
}
