using ExercVetores;
using System;

class ex6
{
	public static void startAlg()
	{
		double[] número = new double[15];
		double maiorN = 0;
		double menorN = 0;
		Console.WriteLine("Inicializado ex5.cs");
		Console.WriteLine("Digite 15 números para-se saber qual o maior e menor entre eles:");
		Console.Write("Digite o ");

		for(int i = 0; i < número.Length; i++)
		{
			Console.Write((i+1)+"° número ");
			número[i] = double.Parse(Console.ReadLine());

			if(número[i]> maiorN)
			{
				maiorN = número[i];
			}
			if(número[i]< menorN)
			{
				menorN = número[i];
			}
		}

		Console.WriteLine("\n" + "Dentre os números informados, temos:");
		Console.WriteLine("maior número: " + maiorN);
		Console.WriteLine("menor número: " + menorN);

		projectMenu.requisição();
		
	}
}