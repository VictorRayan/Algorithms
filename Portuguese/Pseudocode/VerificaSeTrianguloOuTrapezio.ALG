Algoritmo "VerificaSeTrianguloOuTrapezio"

Var
   a,b,c, perimetro, area: real;
   medida: caractere

Inicio

   escreval("Informe os valores A, B, C para saber se trata de um tri�ngulo ou de um trap�zio!")
   escreval("Para evitar conflitos, informe A e B - medida base, e C - altura, no caso de poss�vel trap�zio!")
   escreval("Qual o valor de A?")
   leia(a)
   escreval("Qual o valor de B?")
   leia(b)
   escreval("Qual o valor de C?")
   leia(c)
   escreval("Falta pouco ; Agora nos diga qual o tipo de medida do objeto:")
   escreval(" m - metros, cm - centimetros, se n�o t� aqui nos diga.")
   leia(medida)

   perimetro <- a+b+c
   se (a=b) e (b=c) entao

      escreval("Se trata de um Tri�ngulo! Seu cujo perimetro �", perimetro, " ",medida)


   senao

      area <- ((a+b)/2)*c
      escreval("Se trata de um Trap�zio de cuja �rea de ",area," ",medida, "�")

   fimse



Fimalgoritmo