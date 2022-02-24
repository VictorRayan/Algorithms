Algoritmo "impostoDeRenda"

Var

   valorSalario, valorImposto, calc1, calc2, calc3:real;
   comando:caractere;






Inicio

   escreval("Informe o seu rendimento mensal em Rombus (R$)! Ex: 1000,10 (mil e dez...)")
   leia(valorSalario)

   se(valorSalario < 2000.01)entao

      escreval("Você está Isento do Imposto de Renda!")

   senao

      se(valorsalario > 2000.00)e (valorSalario < 3000.01)entao

         se(valorSalario>2000.01)entao
            valorImposto <- valorSalario - 2000.00
            valorImposto <- (valorImposto/100)* 8
            escreval("Você Não está Isento! O seu Imposto de Renda é R$ ", valorImposto:2:2)
         fimse

      fimse

      se(valorSalario > 3000.00)e(valorSalario <4500.00)entao
         calc1 <- valorSalario - 2000.00
         calc1 <- ((valorSalario - 1000)/100)*8 //de 2000 a 3000
         calc2 <- (valorSalario - 3000.00)*18 //de 3000 a 4500
         valorImposto <- calc1 + calc2

         escreval("Você Não está Isento! O seu Imposto de Renda é R$ ", valorImposto:2:2)

      fimse

      se(valorSalario > 4500.00)entao

         calc1 <- valorSalario - 2000.00
         calc1 <- ((valorSalario - 1000)/100)*8
         calc2 <- ((valorSalario - 3000.00)/100)*18
         calc3 <- ((valorSalario - 4500.00)/100)*28
         valorImposto <- calc1 + calc2 + calc3

         escreval("Você Não está Isento! O seu Imposto de Renda é R$ ", valorImposto:2:2)

      fimse
   fimse
   escreval("Os cálculos foram baseados na tabela de Impostos de Renda. Deseja visualiza-lá? (sim/não)")
   leia(comando)

   se(comando = "sim")entao

      limpatela
      escreval("Renda                             Imposto")
      escreval(" ")
      escreval("de 0.00 a R$ 2000.00              Isento")
      escreval("de R$ 2000.01 até R$ 3000.00      8%")
      escreval("de R$ 3000.01 até R$ 4500.00      18%")
      escreval("acima de R$ 4500.00               28%")

   senao

      escreval("Obrigado! O Processo será encerrado!")

Fimalgoritmo



fimse




Fimalgoritmo