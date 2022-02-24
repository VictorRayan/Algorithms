using ExercVetores;
using System;

class ex10
{

	public static void startAlg()
	{
		double[] precoProd = new double[15];
		double[] qntProd = new double[precoProd.Length];
		double precoTotal = 0;

		Console.WriteLine("Incializado ex10.cs");
		Console.WriteLine("\n"+"informe o preço e ao der Enter a quantidade de cada produto, para-se calcular o valor total em produtos no estoque");
		Console.WriteLine("(os valores devem ser inseridos com todas as casas decimais, ex: dez mil = 10.000,00)");
		Console.Write("\n"+"Começando pelo preço, informe o preço do ");

		for(int i = 0; i<precoProd.Length; i++)
		{
			Console.WriteLine("Produto "+(i+1));
			precoProd[i] = double.Parse(Console.ReadLine());

			Console.WriteLine("\n"+"Quantidade do Produto "+"\n" + (i + 1));
			qntProd[i] = double.Parse(Console.ReadLine());

			precoTotal += precoProd[i] * qntProd[i];
		}

		Console.WriteLine("\n"+"Você tem " + precoTotal.ToString("C") + " em produtos no estoque!");

		projectMenu.requisição();

		
	}


}