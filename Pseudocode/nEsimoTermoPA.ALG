Algoritmo "nEsimoTermoPA"

Var

   n, razao, nEsimoT, primeiroT, posicao:inteiro


Inicio

   escreval("Informe os dados que serão requiridos para lhe mostrar o n-Ésimo termo da P.A!")
   escreval("Digite o número de ordem da P.A!")
   leia(n)

   escreval("Digite a razão da P.A!")
   leia(razao)

   escreval("Digite o primeiro termo da P.A!")
   leia(primeiroT)

   nEsimoT <- primeiroT + (n-1) * razao

   escreval("O n-ésimo termo dessa P.A é ", nEsimoT)




Fimalgoritmo