Algoritmo "JurosCompostos"
//juros compostos - fórmula > valorFinal = valorEmprestado * (1 + taxaDeJuros/100)^periodo



Var

   valorEmprestado, taxaDeJuros, valorFinal, periodo, divisao, soma:real;



Inicio

   escreval("Contribua com as informações que serão requisitadas para concluir o valor final do seu empréstimo efetuado!")
   escreval(\n)
   escreval("Informe o valor do seu empréstimo!")
   leia(valorEmprestado)

   escreval("Informe a taxa de juros do seu empréstimo em percentual sem %!")
   leia(taxaDeJuros)

   escreval("Informe o período do seu empréstimo em meses!")
   leia(periodo)

   valorFinal <- valorEmprestado * taxaDeJuros
   divisao <- valorFinal/100
   soma <- valorEmprestado + divisao
   valorFinal <- soma * periodo


   escreval("O valor final do seu empréstimo acrescidos os juros e o periodo é R$ ",valorFinal)








Fimalgoritmo