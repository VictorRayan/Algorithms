using System;

class AlgAltura
{
	public static void algStart()
	{
		double altura1, altura2;
		int anos = 0;

		altura1 = 1.50;
		altura2 = 1.10;


		while (altura2 < altura1)
		{
			anos += 1;
			altura2 += 0.3;
		}

		Console.WriteLine("Inicializado AlgAltura.cs  " + "\n" + "\n" + "Serão necessários " + anos + " anos para que Felisberto seja maior que Anacleto!");

		AlgAltura.toNext();


	}



	//Função pública, estática e vazia, propósito de setar e executar o próximo arquivo (classe).
	public static void toNext()
	{
		Console.WriteLine("\n"+"Escolher outro algoritmo? (s/n)");
		string strConsole = Console.ReadLine();
		
		if(strConsole == "s")
		{
			Console.Clear();
			ChooseAlg.startAlg();
		}
		else if(strConsole == "n")
		{
			Console.Clear();
			Console.WriteLine("Ok... O sistema será encerrado.");
		}
		else if(strConsole !="s" & strConsole != "n")
		{

			Console.WriteLine("Não existe ação para este argumento! Tente Novamente!");
			AlgAltura.toNext();
		}

	}
}



