Algoritmo "nEsimoTermoPG"

Var
       primeiro, razao, posicao, nEsimo:real

Inicio

      escreval("Informe os dados que serão requiridos para lhe mostrar o n-ésimo termo da P.G")
      escreval("Informe o primeiro termo da P.G!")
      leia(primeiro)
      
      escreval("Informe a razao da P.G!")
      leia(razao)
      
      escreval("Informe o número de ordem da P.G")
      leia(posicao)
      

      nEsimo <- primeiro * razao^(posicao - 1)
      
      escreval("O n-ésimo termo dessa P.G é ", nEsimo)
      


Fimalgoritmo