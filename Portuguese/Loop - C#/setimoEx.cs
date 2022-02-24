using System;

class setimoEx
{
	public static void algStart()
	{

		decimal numero = 0, maiorN = 0;
		int qntDiferencas = 0, contador = 0;

		Console.WriteLine("Inicializado setimoEx.cs" + "\n");
		Console.WriteLine("Digite 25 números reais para determinar o maior entre eles!");
		Console.WriteLine("Lembrando que dar Enter sem valor, será valor zero ou o sistema poderá ser interrompido!");

		for (contador = 1; contador < 25; contador++)
		{

			Console.WriteLine("Digite o "+ contador+ "° número.");
			numero = int.Parse(Console.ReadLine());

			if (maiorN == 0)
			{
				maiorN = numero;
			}

			if (numero > maiorN)
			{
				maiorN = numero;
			}


			else if (maiorN > numero)
			{
				//prevalesce valor atual de "maiorN"
			}


			if (maiorN == numero | numero == maiorN )
			{
				qntDiferencas++;
			}




		}

		if (qntDiferencas < 25)
		{
			Console.WriteLine("O maior dos números informados é: " + maiorN);
			
		}
		else
		{
			Console.WriteLine("Não houve diferença entre os números informados, pois todos os números foram " + numero);
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