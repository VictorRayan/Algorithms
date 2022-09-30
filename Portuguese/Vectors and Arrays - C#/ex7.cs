using ExercVetores;
using System;

class ex7
{
	public static void startAlg()
	{
		double[] salário = new double[18];

		Console.WriteLine("Inicializado ex7.cs");
		Console.WriteLine("Informe o salários dos 18 funcionários para-se aplicar o reajuste.");
		Console.WriteLine("(apenas números sem simbologia de moeda; todos os valores devem conter casas decimais, ex: mil reais = 1.000,00");
		Console.Write("Valor do salário do ");

		for(int i = 0; i < salário.Length; i++)
		{
			Console.Write("funcionário "+(i+1)+":     ");
			salário[i] = double.Parse(Console.ReadLine());

			if(salário[i] <= 1500)
			{
				salário[i] += (salário[i] / 100) * 8;
			}
			else if(salário[i] > 1500)
			{
				salário[i] += (salário[i] / 100) * 5;
			}

		}

		Console.WriteLine("\n"+"----------------Salários Reajustados----------------");
		
		for(int i = 0; i<salário.Length; i++)
		{
			Console.WriteLine("funcionário " + (i + 1) + ": "+salário[i].ToString("C"));

		}
		projectMenu.startMenu();

		
	}
}
