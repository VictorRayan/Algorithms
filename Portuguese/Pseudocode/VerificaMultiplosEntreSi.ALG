Algoritmo "VerificaMultiplosEntreSi"

Var
   a,b,mod1, mod2:inteiro


Inicio

   escreval("Informe dois n�meros para verificar se s�o M�ltiplos entre si.")
   escreval("Digite o primeiro n�mero!")
   leia(a)

   escreval("Digite o segundo n�mero!")
   leia(b)

   mod1 <- a mod b
   mod2 <- b mod a


   se (mod1 = 0) ou (mod2=0) entao
      escreval("S�o M�ltiplos")
   senao
      escreval("N�o s�o M�ltiplos")

   fimse



Fimalgoritmo