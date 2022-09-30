using System;

class ChooseAlg
{
	public static void startAlg()
	{
		Console.WriteLine("Deseja iniciar os algoritmos? (s/n)" + "\n" + "Ou se você deseja executar um algoritmo específico, informe o nome do arquivo." + "\n");
		Console.WriteLine("AlgAltura");
		Console.WriteLine("sistemaEleicao");
		Console.WriteLine("primeiroEx");
		Console.WriteLine("segundoEx");
		Console.WriteLine("terceiroEx");
		Console.WriteLine("quartoEx");
		Console.WriteLine("quintoEx");
		Console.WriteLine("sextoEx");
		Console.WriteLine("setimoEx");
		Console.WriteLine("oitavoEx");
		Console.WriteLine("nonoEx");
		Console.WriteLine("decimoEx");
		Console.WriteLine("Encerrar o Sistema (Encerrar)");

		String strConsole = Console.ReadLine();


		if (strConsole == "Encerrar")
		{
			Console.Clear();
			Console.WriteLine("Ok, o sistema será encerrado.");

		}

		else if (strConsole == "AlgAltura")
		{
			Console.Clear();
			AlgAltura.algStart();

		}

		else if (strConsole == "sistemaEleicao")
		{
			Console.Clear();
			sistemaEleicao.algStart();

		}

		else if (strConsole == "primeiroEx")
		{
			Console.Clear();
			primeiroEx.algStart();

		}

		else if (strConsole == "segundoEx")
		{
			Console.Clear();
			segundoEx.algStart();

		}

		else if (strConsole == "terceiroEx")
		{
			Console.Clear();
			terceiroEx.algStart();

		}

		else if (strConsole == "quartoEx")
		{
			Console.Clear();
			quartoEx.algStart();

		}

		else if (strConsole == "quintoEx")
		{
			Console.Clear();
			quintoEx.algStart();

		}

		else if (strConsole == "sextoEx")
		{
			Console.Clear();
			sextoEx.algStart();

		}


		else if (strConsole == "setimoEx")
		{
			Console.Clear();
			setimoEx.algStart();

		}
		
		else if (strConsole == "oitavoEx")
		{
			Console.Clear();
			oitavoEx.algStart();

		}
		
		else if (strConsole == "nonoEx")
		{
			Console.Clear();
			nonoEx.algStart();

		}
		

		else if (strConsole == "decimoEx")
		{
			Console.Clear();
			decimoEx.algStart();

		}
		

		else if (strConsole == "Encerrar")
		{
			Console.WriteLine("\n" + "Como requisitado o sistema será encerrado.");
		}
		else if (strConsole != "AlgAltura" & strConsole != "sistemaEleicao" & strConsole != "primeiroEx" & strConsole != "segundoEx" & strConsole != "terceiroEx" & strConsole != "quartoEx" & strConsole != "quintoEx" & strConsole != "sextoEx" & strConsole != "setimoEx" & strConsole != "oitavoEx" & strConsole != "nonoEx" & strConsole != "decimoEx" & strConsole != "Encerrar")
		{
			Console.WriteLine("Sem ação para esse argumento! Tente novamente!");
			startAlg();
		}

	}
}
