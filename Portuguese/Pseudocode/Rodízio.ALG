Algoritmo "Rod�zio"

Var

   placa, finalPlaca: inteiro


Inicio

   escreval("Informe o n�mero da placa de seu carro para saber o dia do seu Rod�zio!")
   leia(placa)


   se (placa = 0)entao
      escreval("N�mero informado incorreto! Refa�a o processo!")
      Fimalgoritmo
      
   senao
   
        //m�todo para isolar �ltimo n�mero da placa.
      finalPlaca <- placa mod 10


      se (finalPlaca = 1) ou (finalPlaca = 2) entao

         escreval("Rod�zio �s segundas!")
      fimse

      se (finalPlaca = 3) ou (finalPlaca = 4) entao

         escreval("Rod�zio �s ter�as!")
      fimse

      se (finalPlaca = 5) ou (finalPlaca = 6) entao
         escreval("Rod�zio �s quartas!")
      fimse

      se (finalPlaca = 7) ou (finalPlaca = 8) entao
         escreval("Rod�zio �s quintas!")
      fimse

      se(finalPlaca = 9) ou (finalPlaca = 0) entao
         escreval("Rod�zio �s sextas!")
      fimse
   fimse





Fimalgoritmo