using System;

class quintoEx
{
    public static void algStart()
    {
        int numero = 0, contador = 0;
        double soma = 0;

        Console.WriteLine("Inicializado quintoEx.cs" + "\n");
        Console.WriteLine("Digite um número inteiro e positivo para exibir a soma dos quadrados até o informado!");
        numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.Clear();
            while (contador < numero)
            {
                contador++;
                soma = soma + Math.Pow(contador, 2);
                Console.WriteLine(soma);
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
