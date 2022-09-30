Algoritmo "Menor_dos_quatro_numeros"


Var
   v1,v2,v3,v4:inteiro

Inicio
   escreval ("digite o primeiro numero")
   leia(v1)
   escreval ("digite o segundo numero")
   leia(v2)
   escreval ("digite o terceiro numero")
   leia(v3)
   escreval ("digite o quarto numero")
   leia(v4)

//---------------------------

se ((v1<v2) e (v1<v3) e  (v1<v4)) entao
   escreva ("o menor valor e:",v1)
fimse

//---------------------------
se ((v2<v1) e (v2<v3) e  (v2<v4)) entao
   escreva ("o menor valor e:",v2)
fimse

//---------------------------
se ((v3<v1) e (v3<v2) e  (v3<v4)) entao
   escreva ("o menor valor e:",v3)
fimse

//---------------------------
se ((v4<v1) e (v4<v2) e  (v4<v3)) entao
   escreva ("o menor valor e:",v4)
fimse

//----------------------------
Fimalgoritmo