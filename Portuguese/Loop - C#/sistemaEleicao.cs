using System;

class sistemaEleicao
{
	public static void algStart()
	{
        int nV = 0;
        int nVoto1 = 0;
        int nVoto2 = 0;
        int nVoto3 = 0;
        int nVoto4 = 0;
        int nNulos = 0;
        int nBrancos = 0;
        int count = 0;






        decimal pcVoto1;
        decimal pcVoto2;
        decimal pcVoto3;
        decimal pcVoto4;
        decimal pcNulos;
        decimal pcBrancos;

        Console.WriteLine("Inicializado sistemaEleicao.cs"+"\n"+"\n"+"Informe os dados requisitados da eleição a seguir!");

        for (count = 1; count < 5; count++) {
            Console.WriteLine("Informe o número de votos do candidato "+ count);
            nV = int.Parse(Console.ReadLine());


            switch (count) {



               case 1:
                    nVoto1 = nV;
                    break;
               case 2:
                    nVoto2 = nV;
                    break;
               case 3:
                    nVoto3 = nV;
                    break;

               case 4:
                    nVoto4 = nV;
                    break;
             }
  

      }

        Console.WriteLine("Informe o número de votos nulos!");
      nNulos = int.Parse(Console.ReadLine());


        Console.WriteLine("Informe o número de votos brancos!");
      nBrancos = int.Parse(Console.ReadLine());


        //calculo de votos e percentuais
        
        pcVoto1 = nVoto1 + nVoto2 + nVoto3 + nVoto4 + nNulos + nBrancos;
        pcVoto1 = nVoto1 / pcVoto1;
        pcVoto1 = pcVoto1 * 100;


        
        pcVoto2 = nVoto1 + nVoto2 + nVoto3 + nVoto4 + nNulos + nBrancos;
        pcVoto2 = nVoto2/pcVoto2;
        pcVoto2 = pcVoto2 * 100;

        pcVoto3 = nVoto1 + nVoto2 + nVoto3 + nVoto4 + nNulos + nBrancos;
        pcVoto3 = nVoto3 / pcVoto3;
        pcVoto3 = pcVoto3 * 100;


        pcVoto4 = nVoto1 + nVoto2 + nVoto3 + nVoto4 + nNulos + nBrancos;
        pcVoto4 = nVoto4 / pcVoto4;
        pcVoto4 = pcVoto4 * 100;

        pcBrancos = nVoto1 + nVoto2 + nVoto3 + nVoto4 + nNulos + nBrancos;
        pcBrancos = nBrancos / pcBrancos;
        pcBrancos = pcBrancos * 100;

        pcNulos = nVoto1 + nVoto2 + nVoto3 + nVoto4 + nNulos + nBrancos;
        pcNulos = nNulos / pcNulos;
        pcNulos = pcNulos * 100;

        //apresentação dos dados

        Console.Clear();


        Console.WriteLine("Perante os dados informados o seguem os resultados...");
        Console.WriteLine(" ");
        Console.WriteLine("Categoria       Votos          Percentual");
        Console.WriteLine("Candidato 1     "+ nVoto1+ "              "+ Math.Round(pcVoto1) + "%");
        Console.WriteLine("Candidato 2     "+ nVoto2+ "              "+ Math.Round(pcVoto2) + "%");
        Console.WriteLine("Candidato 3     "+ nVoto3+ "              "+ Math.Round(pcVoto3) + "%");
        Console.WriteLine("Candidato 4     "+ nVoto4+ "              "+ Math.Round(pcVoto4) + "%");
        Console.WriteLine("Brancos         "+ nBrancos+ "              "+ Math.Round(pcBrancos) + "%");
        Console.WriteLine("Nulos           "+ nNulos+ "              "+ Math.Round(pcNulos) + "%");

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