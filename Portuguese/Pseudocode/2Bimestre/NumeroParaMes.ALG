Algoritmo "numeroParaMes"

Var

   numeroDoMes:inteiro;
   nomeDoMes:caracter;


Inicio

   escreval("Digite o n�mero do m�s para reportarmos o nome do m�s!")
   leia(numeroDoMes)


   se(numeroDoMes <= 12)entao
      se(numeroDoMes = 1)entao
         nomeDoMes <- "Janeiro"
      fimse

      se(numeroDoMes = 2)entao
         nomeDoMEs <- "Fevereiro"
      fimse

      se(numeroDoMes = 3)entao
         nomeDoMes <- "Mar�o"
      fimse

      se(numeroDoMes = 4)entao
         nomeDoMes <- "Abril"
      fimse

      se(numeroDoMes = 5)entao
         nomeDoMes <- "Maio"
      fimse

      se(numeroDoMes = 6)entao
         nomeDoMEs <- "Junho"
      fimse

      se(numeroDoMes = 7)entao
         nomeDoMes <- "Julho"
      fimse

      se(numeroDoMes = 8)entao
         nomeDoMes <- "Agosto"
      fimse

      se(numeroDoMes = 9)entao
         nomeDoMes <- "Setembro"
      fimse

      se(numeroDoMes = 10)entao
         nomeDoMes <- "Outubro"
      fimse

      se(numeroDoMes = 11) entao
         nomeDoMes <- "Novembro"
      fimse

      se(numeroDoMes = 12)entao
         nomeDoMes <- "Dezembro"
      fimse

      escreval("O respectivo n�mero ",numeroDoMes," correasponde ao mes: ",nomeDoMes)
      
   senao
        escreval("N�mero informado inv�lido!! O processo ser� reinicializado!")
        Fimalgoritmo
   fimse




Fimalgoritmo