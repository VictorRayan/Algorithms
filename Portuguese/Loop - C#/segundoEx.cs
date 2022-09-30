using System;

class segundoEx
{
	public static void algStart()
	{

        int numero, contador;
        bool houveMultiplo = false;
        Console.WriteLine("Inicializado segundoEx.cs" + "\n");
        Console.WriteLine("Informe um número positivo e inteiro para ser exibidos as possibilidades de múltiplos de três até o informado!");
        numero = int.Parse(Console.ReadLine());
        Console.Clear();

        for(contador = 0; contador < numero; contador++)
		{
            if(contador % 3 == 0)
			{
                Console.WriteLine(contador);
                houveMultiplo = true;
			}
			
		}

        if(houveMultiplo == false)
		{
            Console.WriteLine("O intervalo informado de 0 á ", numero, " não houve múltiplos!");
		}
		else
		{
            Console.WriteLine("Sao esses os múltiplos de três!");

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