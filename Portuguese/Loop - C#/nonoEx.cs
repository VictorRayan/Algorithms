using System;

class nonoEx
{
	public static void algStart()
	{

		decimal numero = 0, qntMultiplos = 0;
		int contador = 0;


		Console.WriteLine("Incializado nonoEx.cs" + "\n");
		Console.WriteLine("Digite 20 números reais para determinar quantos múltiplos de 7 houve nesse intervalo!");

		for (contador = 1; contador < 20; contador++)
		{

			Console.WriteLine("Digite o " + contador + "° numero!");

			numero = int.Parse(Console.ReadLine());


			if (numero % 7 == 0)
			{

				qntMultiplos = qntMultiplos + 1;



			}

		}


		Console.Clear();
		if (qntMultiplos == 0)
		{

			Console.WriteLine("Não houve nenhum múltiplo de 7 nesse intervalo informado!");

		}
		else
		{


			Console.WriteLine("Foram verificados "+ qntMultiplos+ " números múltiplos de 7!");
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