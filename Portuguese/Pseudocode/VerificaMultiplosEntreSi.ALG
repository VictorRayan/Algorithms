Algoritmo "VerificaMultiplosEntreSi"

Var
   a,b,mod1, mod2:inteiro


Inicio

   escreval("Informe dois números para verificar se são Múltiplos entre si.")
   escreval("Digite o primeiro número!")
   leia(a)

   escreval("Digite o segundo número!")
   leia(b)

   mod1 <- a mod b
   mod2 <- b mod a


   se (mod1 = 0) ou (mod2=0) entao
      escreval("São Múltiplos")
   senao
      escreval("Não são Múltiplos")

   fimse



Fimalgoritmo