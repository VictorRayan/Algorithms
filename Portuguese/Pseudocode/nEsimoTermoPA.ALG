Algoritmo "nEsimoTermoPA"

Var

   n, razao, nEsimoT, primeiroT, posicao:inteiro


Inicio

   escreval("Informe os dados que ser�o requiridos para lhe mostrar o n-�simo termo da P.A!")
   escreval("Digite o n�mero de ordem da P.A!")
   leia(n)

   escreval("Digite a raz�o da P.A!")
   leia(razao)

   escreval("Digite o primeiro termo da P.A!")
   leia(primeiroT)

   nEsimoT <- primeiroT + (n-1) * razao

   escreval("O n-�simo termo dessa P.A � ", nEsimoT)




Fimalgoritmo