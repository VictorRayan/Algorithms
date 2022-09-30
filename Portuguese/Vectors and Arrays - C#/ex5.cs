using ExercVetores;
using System;

class ex5
{
	public static void startAlg()
	{
		int[] números = new int[16];
		Console.WriteLine("Inicializado ex5.cs");
		Console.WriteLine("Informe 16 números para decompolos de ordem contrária.");
		Console.Write("Informe o ");

		for(int i = 0; i < números.Length; i++)
		{
			Console.WriteLine((i + 1) + "° número:");
			números[i] = int.Parse(Console.ReadLine());
		}

		Console.Write("A ordem contrária dos números informados é essa: ");
		for(int i =  números.Length; i > 0; i--)
		{
			if(i - 1 == 0)
			{
				Console.Write(números[i-1]+".");
			}
			else
			{
				Console.Write(números[i-1] + ", ");
			}
		}

		projectMenu.requisição();

	}
}
