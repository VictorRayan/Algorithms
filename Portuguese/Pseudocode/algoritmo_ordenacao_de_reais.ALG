Algoritmo "semnome"

Var
  
   numA, numB, numC, num1, num2, num3:real;
   text:caractere;
   imprime: logico;


Inicio
 
   escreval("Digite os numeros reais para que sejam ordenado!")
   escreval("Come�ando pelo primeiro!")
   leia(numA)
   escreval("Digite o segundo n�mero Real!")
   leia(numB)
   escreval("Digite o terceiro n�mero Real!")
   leia(numC)

   // Ordena��o dos valores reais

   imprime <- verdadeiro

   se (numA = numB) ou (numA = numC) ou (numB = numC)ent�o //verifica numeros repetidos
      escreval("Os valores s�o iguais! Eles devem ser diferentes para que sejam Ordenados!")
      escreval("Reinicialize o processo!")
      imprime <- falso; //n�o deixa imprimir os valores ordenados se houver repeti��o



   sen�o


      se ((numA < numB) e (numA < numC))ent�o

         num1 <-numA

         se(numB < numC)ent�o

            num2 <- numB
            num3 <- numC

         sen�o

            num2 <- numC
            num3 <- numB


         fimse
      fimse







      se((numB < numA) e (numB < numC))ent�o

         num1 <- numB

         se(numA < numC )ent�o

            num2 <- numA
            num3 <- numC

         sen�o

            num2 <- numC
            num3 <- numA

         fimse


      fimse


      se ((numC < numA)) e ((numC < numB))ent�o

         num1 <- numC

         se (numB < numA) ent�o

            num2 <- numB
            num3 <- numA
         sen�o

            num2 <- numA
            num3 <- numB

         fimse








      fimse
   fimse

   // Verifica por meio da Var "imprime" se pode imprimir os valores, se n�o puder
   //devido a valores repetidos o Processo ser� encerrado.
   se (imprime = falso) ent�o
      escreval ("O processo ser� encerrado devido as inconsist�ncias dos valores!")

Fimalgoritmo
sen�o // se os valores n�o forem repetidos, imprime os valores!!
   escreval("N�meros Ordenados!!", num1, num2, num3 )

fimse

Fimalgoritmo