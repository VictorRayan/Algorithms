using System;

class decimoEx
{
	public static void algStart()
	{
		decimal numero = 0, somaPositivos = 0;
		int contador = 0, qntNegativos = 0;

		Console.WriteLine("Inicializado decimoEx.cs" + "\n");
		Console.WriteLine("Digite 30 números reais para serem verificados e exibido a soma dos positivos se houver e a quantidade de negativos se houver!");
		Console.WriteLine("***Lembre-se que 0 (zero) é valor neutro!");

		while (contador < 30)
		{


			contador++;


			Console.WriteLine("Digite o " + contador + "° número!");

			numero = int.Parse(Console.ReadLine());


			if (numero > 0)
			{

				somaPositivos += numero;


			}


			if (numero < 0)
			{

				qntNegativos++;


			}

		}

		if (qntNegativos == 0 & somaPositivos == 0)
		{

			Console.WriteLine("Todos os números digitados foram 0, não houve nem positivos e nem negativos!");

		}

		if (somaPositivos == 0 & qntNegativos > 0)
		{

			Console.WriteLine("Houve " + qntNegativos + "números negativos e não houve nenhum número positivo!");
		}

		if (somaPositivos > 0 & qntNegativos == 0)
		{

			Console.WriteLine("A soma dos números positivos resulta em " + somaPositivos + " e não houve nenhum número negativo!");

		}

		if (somaPositivos > 0 & qntNegativos > 0)
		{

			Console.WriteLine("A soma dos números positivos resultam em " + somaPositivos + " e houveram " + qntNegativos + " números negativos!");
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

