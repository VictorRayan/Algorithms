Algoritmo "nEsimoTermoPG"

Var
       primeiro, razao, posicao, nEsimo:real

Inicio

      escreval("Informe os dados que ser�o requiridos para lhe mostrar o n-�simo termo da P.G")
      escreval("Informe o primeiro termo da P.G!")
      leia(primeiro)
      
      escreval("Informe a razao da P.G!")
      leia(razao)
      
      escreval("Informe o n�mero de ordem da P.G")
      leia(posicao)
      

      nEsimo <- primeiro * razao^(posicao - 1)
      
      escreval("O n-�simo termo dessa P.G � ", nEsimo)
      


Fimalgoritmo