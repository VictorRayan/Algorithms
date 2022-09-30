using System;

class primeiroEx
{
	public static void algStart()
	{

		int numero = 0;
		int contador = 0;
		int soma = 0;

		Console.WriteLine("Inicializado primeiroEx.cs" + "\n");
		Console.WriteLine("Informe um número para exibir a soma dos números até o informado!");

		numero = int.Parse(Console.ReadLine());

		for (contador = 1; contador <= numero; contador++)
		{

			soma = soma + contador;


		}
		Console.WriteLine("Soma dos números: " + soma);

		toNext();
	}

	public static void toNext()
	{
		Console.WriteLine("\n" + "Escolher outro algoritmo? (s/n)");
		string strConsole = Console.ReadLine();

		if (strConsole == "s")
		{
			Console.Clear();
			ChooseAlg.startAlg();
		}
		else if (strConsole == "n")
		{
			Console.Clear();
			Console.WriteLine("Ok... O sistema será encerrado.");
		}
		else if (strConsole != "s" & strConsole != "n")
		{

			Console.WriteLine("Não existe ação para este argumento! Tente Novamente!");
			toNext();
		}

	}

}