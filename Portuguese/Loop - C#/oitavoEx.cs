using System;

class oitavoEx
{
	public static void algStart()
	{
		decimal numero = 0, menor = 0, maior = 0;
		int contador;

		Console.WriteLine("Incializado oitavoEx.cs" + "\n");
		Console.WriteLine("Digite 25 números reais para exibir o maior e o menor entre eles!");

		for (contador = 1; contador < 25; contador++)
		{
			Console.WriteLine("Digite o " + contador + "° número!");
			numero = int.Parse(Console.ReadLine());

			if (maior == 0 & menor == 0)
			{

				maior = numero;
				menor = numero;


			}

			if (maior < numero)
			{
				maior = numero;
			}
			else
			{
				//prevalesce o valor de "maior"

			}
			if (menor > numero)
			{
				menor = numero;
			}
			else
			{
				//prevaslesce o valor de "menor"
			}




		}

		if (maior == menor)
		{
			Console.WriteLine("Não houve diferenças, pois todos os números digitados foram: " + maior);


		}
		else
		{
			Console.Write("Dos números informados o menor é: " + menor + "; E o maior é: " + maior);
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