using System;

class terceiroEx
{

	public static void algStart()
	{
		int numero = 0;
		Console.WriteLine("Inicializado terceiroEx.cs" + "\n");
		Console.WriteLine("Digite um número inteiro e positivo para mostrar a decrescência do número atá 1!");
		numero = int.Parse(Console.ReadLine());

		if(numero > 0)
		{
			while(numero > 1)
			{
				numero--;
				Console.WriteLine(numero);
			}
		}
		else
		{
			Console.WriteLine("O número digitado não é positivo, reinicie o processo!");
		}

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