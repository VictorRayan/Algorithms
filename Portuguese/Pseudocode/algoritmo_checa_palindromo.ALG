Algoritmo "palindromo"

Var

   numero, n1, n2, n3, n4:inteiro
   
Inicio

   escreval("Digite um n�mero de 4 d�gitos.")
   leia(numero)
   
   n1 <- numero mod 10
   n2 <- numero / 10 mod 10
   n3 <- numero / 100 mod 10
   n4 <- numero / 1000 mod 10
   
se ((n4 = n1) e (n2 = n3)) ent�o
   escreval("O n�mero informado � um palindromo!")
   sen�o
   escreval("O n�mero informado n�o � um palindromo!")
   
fimse





Fimalgoritmo