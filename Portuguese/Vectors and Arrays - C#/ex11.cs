using ExercVetores;
using System;


class ex11
{
	public static void startAlg()
	{
		
		double[] nota_primeiroSemestre = new double[25];
		double[] nota_segundoSemestre = new double[nota_primeiroSemestre.Length];
		double[] nota_anual = new double[nota_primeiroSemestre.Length];
		string[] situacao = new string[nota_primeiroSemestre.Length];
		

		Console.WriteLine("Inicializado ex11.cs");
		Console.WriteLine("\n"+"Insira as notas de cada aluno pelo número de ordem / chamada, primeira mente, do primeiro semestre. E depois as notas do segundo semestre assim que requisitado.");
		Console.WriteLine("---------------Insira as notas do 1° Semestre---------------"+"\n");
		for(int i = 0; i < nota_primeiroSemestre.Length; i++ )
		{
			Console.Write("Aluno n°" + (i + 1)+":   ");
			nota_primeiroSemestre[i] = double.Parse(Console.ReadLine());
			if (nota_primeiroSemestre[i] > 10 || nota_primeiroSemestre[i] < 0)
			{
				Console.WriteLine("Nota inválida, o processo será reiniciado após teclar qualquer tecla.");
				Console.WriteLine("mais atenção na próxima vez!! (•`_´•)");
				Console.ReadKey();
				Console.Clear();
				startAlg();

			}
			else
			{
				nota_primeiroSemestre[i] = (nota_primeiroSemestre[i] / 100) * 40;
			}
		}

		Console.WriteLine("\n"+ "---------------Insira as notas do 2° Semestre---------------"+"\n");
		for(int i = 0; i < nota_segundoSemestre.Length; i++)
		{
			Console.Write("Aluno n°" + (i + 1) + ":   ");
			nota_segundoSemestre[i] = double.Parse(Console.ReadLine());
			if (nota_segundoSemestre[i] > 10 || nota_segundoSemestre[i] < 0)
			{
				Console.WriteLine("Nota inválida, o processo será reiniciado após teclar qualquer tecla.");
				Console.WriteLine("mais atenção na próxima vez!! (•`_´•)");
				Console.ReadKey();
				Console.Clear();
				startAlg();

			}
			else
			{
				nota_segundoSemestre[i] = (nota_segundoSemestre[i] / 100) * 60;
			}
		}

		//cálcula e exibe a média anual...

		Console.Clear();
		Console.WriteLine("\n" + "--------------------Resultado Anual--------------------" + "\n");
		Console.WriteLine("N° de ordem / chamada do aluno  ||   Situação"+"\n");
		for (int i = 0; i < nota_anual.Length; i++)
		{
			nota_anual[i] = nota_primeiroSemestre[i] + nota_segundoSemestre[i];

			//define se o aluno foi aprovado ou reprovado.
			if (nota_anual[i] < 6)
			{
				situacao[i] = "REPROVADO (•`_´•)";
			}
			else if (nota_anual[i] >= 6) 
			{
				situacao[i] = "APROVADO  (°o°)";
			}
		

			
			Console.WriteLine("número "+(i+1)+"                                         "+situacao[i]);
			
		}
		projectMenu.requisição();

	}
}