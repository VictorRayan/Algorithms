using System;

class sextoEx
{
    public static void algStart()
    {

        int numero = 0, contador = 0, calculo = 0, cNumero = 0;
        Console.WriteLine("Inicializado sextoEx.cs" + "\n");
        Console.WriteLine("Digite um número positivo e inteiro para mostrar o fatorial desse número!");
        numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.Clear();
            calculo = 1;
            cNumero = numero;

            for (contador = 0; contador < numero -1; contador++)
            {
                calculo = calculo * cNumero;
                cNumero = cNumero - 1;
            }

            Console.WriteLine("O fatorial de " + numero + " é: " + calculo);
        }
        else
        {
            Console.WriteLine("O número digitado não é positivo, reinicie o processo!");
            toNext();
        }
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
