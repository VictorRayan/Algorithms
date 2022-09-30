using System;

class quartoEx
{
	public static void algStart()
	{

        int numero = 0, contador = 0;

		Console.WriteLine("Inicializado quartoEx.cs"+"\n");
        Console.WriteLine("Digite um número inteiro e positivo para ser exibidos os quadrados de cada número de 1 até o informado!");
        numero = int.Parse(Console.ReadLine());

        if(numero > 0)
		{
            for (contador = 0; contador < numero; contador++)
			{
                Console.WriteLine("quadrado de "+ contador+ " é: "+ Math.Pow(contador, 2));

            }
		}
		else
		{
            Console.WriteLine("O número digitado nao é positivo, reinicie o processo!");

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