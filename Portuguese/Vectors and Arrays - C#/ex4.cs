using ExercVetores;
using System;

class ex4
{
	public static void startAlg()
	{
		double[] número = new double[5];
		double soma = 0;
		double médiaAritmética = 0;
		Console.WriteLine("Inicializado ex4.cs");
		Console.WriteLine("Para o processo calcular o valor de média aritmética de 5 valores, será necessário informa-los.");
		Console.Write("Digite o ");
		for(int i = 0; i < número.Length; i++)
		{
			Console.WriteLine((i+1)+"° número");
			número[i] = double.Parse(Console.ReadLine());

			soma += número[i];

		}

		//cálcula a média aritmética dos valores reais digitados pelo usuário...
		médiaAritmética = soma / número.Length;

		//exibe abaixo o resultado do cálculo acima...
		Console.WriteLine("Resutado da média aritmética dos números informados pelo usuário: "+médiaAritmética);
		projectMenu.requisição();

		
	}
}