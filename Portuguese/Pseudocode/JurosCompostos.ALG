Algoritmo "JurosCompostos"
//juros compostos - f�rmula > valorFinal = valorEmprestado * (1 + taxaDeJuros/100)^periodo



Var

   valorEmprestado, taxaDeJuros, valorFinal, periodo, divisao, soma:real;



Inicio

   escreval("Contribua com as informa��es que ser�o requisitadas para concluir o valor final do seu empr�stimo efetuado!")
   escreval(\n)
   escreval("Informe o valor do seu empr�stimo!")
   leia(valorEmprestado)

   escreval("Informe a taxa de juros do seu empr�stimo em percentual sem %!")
   leia(taxaDeJuros)

   escreval("Informe o per�odo do seu empr�stimo em meses!")
   leia(periodo)

   valorFinal <- valorEmprestado * taxaDeJuros
   divisao <- valorFinal/100
   soma <- valorEmprestado + divisao
   valorFinal <- soma * periodo


   escreval("O valor final do seu empr�stimo acrescidos os juros e o periodo � R$ ",valorFinal)








Fimalgoritmo