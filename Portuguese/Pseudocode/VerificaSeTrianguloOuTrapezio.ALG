Algoritmo "VerificaSeTrianguloOuTrapezio"

Var
   a,b,c, perimetro, area: real;
   medida: caractere

Inicio

   escreval("Informe os valores A, B, C para saber se trata de um triângulo ou de um trapézio!")
   escreval("Para evitar conflitos, informe A e B - medida base, e C - altura, no caso de possível trapézio!")
   escreval("Qual o valor de A?")
   leia(a)
   escreval("Qual o valor de B?")
   leia(b)
   escreval("Qual o valor de C?")
   leia(c)
   escreval("Falta pouco ; Agora nos diga qual o tipo de medida do objeto:")
   escreval(" m - metros, cm - centimetros, se não tá aqui nos diga.")
   leia(medida)

   perimetro <- a+b+c
   se (a=b) e (b=c) entao

      escreval("Se trata de um Triângulo! Seu cujo perimetro é", perimetro, " ",medida)


   senao

      area <- ((a+b)/2)*c
      escreval("Se trata de um Trapézio de cuja Área de ",area," ",medida, "²")

   fimse



Fimalgoritmo