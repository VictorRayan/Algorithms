Algoritmo "MEDIA"

Var

   nota1, nota2, nota3, nota4, media: real;


Inicio

   escreval("Informe as suas 4 notas!")
   escreval("Digite a primeira!")
   leia(nota1)
   escreval("Digite a segunda!")
   leia(nota2)
   escreval("Digite a terceira!")
   leia(nota3)
   escreval("Digite a �ltima nota!")
   leia(nota4)

   se(nota1>10) ou (nota2>10) ou (nota3>10) ou (nota4>10)entao
      escreval("Valores de notas inv�lidos, finalizando processo!")
      //FimAlgoritmo
   senao
      media <- (nota1 + nota2 + nota3 + nota4) / 4
      escreval("A m�dia das suas notas �: ", media)
   fimse




Fimalgoritmo