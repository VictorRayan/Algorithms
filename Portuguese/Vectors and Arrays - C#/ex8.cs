using ExercVetores;
using System;
class ex8{ 
	public static void startAlg()
	{
		double[] matriz1 = new double[10];
		double[] matriz2 = new double[10];
		double[] matriz3 = new double[10];
		Console.WriteLine("Inicializado ex8.cs");
		Console.WriteLine("Informe 20 números reais ao todo para se obter a soma vertorial de seus correspondentes. (ex: 1° número do grupo 1 + 1° número do grupo 2, ou correspondentes do Domínio em Contradomíno) ");

		Console.WriteLine("\n" + "1° Grupo (Matriz 1)");
		for(int i = 0; i < matriz1.Length & i < matriz2.Length; i++)
		{
			Console.WriteLine("Digite o "+(i + 1) + "° número:  ");
			matriz1[i] = double.Parse(Console.ReadLine());
		}

		Console.WriteLine("\n" + "2° Grupo (Matriz 2) ");
		for(int i = 0; i < matriz1.Length & i < matriz2.Length; i++)
		{
			Console.WriteLine("Digite o " + (i + 1) + "° número");
			matriz2[i] = double.Parse(Console.ReadLine());
		}

		for(int i = 0; i < matriz1.Length & i < matriz2.Length; i++)
		{
			matriz3[i] = matriz1[i] + matriz2[i];
		}

		Console.WriteLine("-------------------Resultado da soma dos valores dos vetores correspondentes-------------------");
		for(int i = 0; i < matriz3.Length; i++)
		{
			Console.WriteLine((i+1)+ "°vetor das matrizes: "+matriz3[i]);
		}

		projectMenu.requisição();
		
	}

}