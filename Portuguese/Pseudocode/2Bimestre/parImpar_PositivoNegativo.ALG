Algoritmo "parImpar_PositivoNegativo"

Var

   num1, num2, num3, num4, num5, par, impar, positivo, negativo: inteiro;


Inicio

   escreval("Informe 5 n�meros para avaliarmos se s�o impares ou pares, positivos ou negativos!")
   escreval("Digite um de cada vez!")
   leia(num1)
   leia(num2)
   leia(num3)
   leia(num4)
   leia(num5)


   //verifica o primerio n�mero
   se(num1 % 2 = 0)entao
      par <- par +1

   senao
      impar <- impar +1

   fimse

   se(num1 > 0)entao
      positivo <- positivo +1

   senao
      negativo <- negativo +1
   fimse



   //verifica o segundo n�mero
   se(num2 % 2 = 0)entao
      par <- par +1
   senao
      impar <- impar +1
   fimse

   se(num2> 0)entao
      positivo <- positivo + 1
   senao
      negativo <- negativo +1
   fimse


   //verifica o terceiro n�mero
   se(num3 % 2 = 0)entao
      par <- par + 1
   senao
      impar <- impar + 1
   fimse

   se(num3 >0)entao
      positivo <- positivo +1
   senao
      negativo <- negativo +1
   fimse


   //verifica quarto n�mero
   se(num4 % 2 =0) entao
      par <- par +1
   senao
      impar <- impar + 1
   fimse

   se(num4 > 0)entao
      positivo <- positivo +1
   senao
      negativo <- negativo +1
   fimse


   //verifica o quinto n�emro
   se(num5 % 2 = 0) entao
      par <- par +1
   senao
      impar <- impar +1
   fimse

   se(num5 > 0)entao
      positivo <- positivo +1
   senao
      negativo <- negativo + 1
   fimse

   escreval("Dos n�meros informados temos: ",impar," impar(es), ",par," par(es), ", positivo," positivo(s), ",negativo, " negativo(s)")
   
   















Fimalgoritmo