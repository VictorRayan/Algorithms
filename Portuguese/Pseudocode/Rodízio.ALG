Algoritmo "Rodízio"

Var

   placa, finalPlaca: inteiro


Inicio

   escreval("Informe o número da placa de seu carro para saber o dia do seu Rodízio!")
   leia(placa)


   se (placa = 0)entao
      escreval("Número informado incorreto! Refaça o processo!")
      Fimalgoritmo
      
   senao
   
        //método para isolar último número da placa.
      finalPlaca <- placa mod 10


      se (finalPlaca = 1) ou (finalPlaca = 2) entao

         escreval("Rodízio às segundas!")
      fimse

      se (finalPlaca = 3) ou (finalPlaca = 4) entao

         escreval("Rodízio às terças!")
      fimse

      se (finalPlaca = 5) ou (finalPlaca = 6) entao
         escreval("Rodízio às quartas!")
      fimse

      se (finalPlaca = 7) ou (finalPlaca = 8) entao
         escreval("Rodízio às quintas!")
      fimse

      se(finalPlaca = 9) ou (finalPlaca = 0) entao
         escreval("Rodízio às sextas!")
      fimse
   fimse





Fimalgoritmo