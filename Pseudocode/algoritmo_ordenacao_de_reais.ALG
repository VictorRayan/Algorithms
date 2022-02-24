Algoritmo "semnome"

Var
  
   numA, numB, numC, num1, num2, num3:real;
   text:caractere;
   imprime: logico;


Inicio
 
   escreval("Digite os numeros reais para que sejam ordenado!")
   escreval("Começando pelo primeiro!")
   leia(numA)
   escreval("Digite o segundo número Real!")
   leia(numB)
   escreval("Digite o terceiro número Real!")
   leia(numC)

   // Ordenação dos valores reais

   imprime <- verdadeiro

   se (numA = numB) ou (numA = numC) ou (numB = numC)então //verifica numeros repetidos
      escreval("Os valores são iguais! Eles devem ser diferentes para que sejam Ordenados!")
      escreval("Reinicialize o processo!")
      imprime <- falso; //não deixa imprimir os valores ordenados se houver repetição



   senão


      se ((numA < numB) e (numA < numC))então

         num1 <-numA

         se(numB < numC)então

            num2 <- numB
            num3 <- numC

         senão

            num2 <- numC
            num3 <- numB


         fimse
      fimse







      se((numB < numA) e (numB < numC))então

         num1 <- numB

         se(numA < numC )então

            num2 <- numA
            num3 <- numC

         senão

            num2 <- numC
            num3 <- numA

         fimse


      fimse


      se ((numC < numA)) e ((numC < numB))então

         num1 <- numC

         se (numB < numA) então

            num2 <- numB
            num3 <- numA
         senão

            num2 <- numA
            num3 <- numB

         fimse








      fimse
   fimse

   // Verifica por meio da Var "imprime" se pode imprimir os valores, se não puder
   //devido a valores repetidos o Processo será encerrado.
   se (imprime = falso) então
      escreval ("O processo será encerrado devido as inconsistências dos valores!")

Fimalgoritmo
senão // se os valores não forem repetidos, imprime os valores!!
   escreval("Números Ordenados!!", num1, num2, num3 )

fimse

Fimalgoritmo