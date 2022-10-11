import random
import time
import pandas as pd
import seaborn as sns
import matplotlib.pyplot as plt

#Count numbers verification
count_numbers = 0
count_numbers = int(input("Digite a quantidade de numeros que irão ser verificados: "))

#Dataframe for getting count numbers end runtime
list_alg_qnt = [None] * count_numbers
list_runtime = [None] * count_numbers

for i in range(count_numbers):
    
    #CHEKS THE RUNTIME OF PRIME VERIFICATION
    runtime_start = 0.0
    runtime_end = 0.0
    
    #gets runtime 
    runtime_start = time.time()
    
    
    #gets the amount of numerals
    user_input = input("Informe a quantidade de algarismos: ")
    
    #converts got amount to integer
    qnt_alg = int(user_input)
    
    #initilizes variables used in amount of numerals to numbers on the following methods
    first_number = "1"
    last_number = ""
    
    #does a loop to generate a first number of amount of numerals required by user, and a last number too.
    for x in range(qnt_alg):
        if(x>1):
            first_number = first_number + "0"
        
        last_number = last_number + "9"
    
    #converts these string numbers to integer
    first_number_int = int(first_number)
    last_number_int = int(last_number)
    
    #generates a random number with generated numbers (first and last number of amount of numerals demanded by user)
    random_number = random.randint(first_number_int,last_number_int)
    
    #checks if generated random number is odd or even, if it's not odd, then regenerate a random number until gets a even number.
    while(random_number % 2 ==0):
        random_number = random.randint(first_number_int,last_number_int)
    
    
    #initializes a variable that carries if the number is prime or not
    is_prime = 'false'
    
    
    #cheks generated random odd number divided by all possibilities until itself (except itself).
    #excluding division by one or by number itself
    for x in range(random_number -1):
        runtime_start = time.time()
        if(x>1 and random_number % x == 0):
            is_prime='false'
            break
        else:
            is_prime='true' 
            
    #CHEKS O RUNTIME END  
    runtime_end = time.time()
    
    
    #print if genetared random odd number is prime or not.
    if(is_prime=='true'):
        print('o número '+str(random_number)+ ' é primo')
    else:
        print('o número '+str(random_number)+ ' não é primo')
    
    print('tempo de execução: '+ str(runtime_end))
    
    print(i)
    list_alg_qnt[i] = qnt_alg
    list_runtime[i] = runtime_end
    
    
#df = pd.DataFrame([[list_alg_qnt, list_runtime]], columns=['qnt_alg', 'runtime'])
df = pd.DataFrame({'N_algarismos':list_alg_qnt, 'runtime':list_runtime})



    
#VEMOS QUE NO GRAFICO OS PONTOS ESTÃO ALINHADOS COM A LINHA
#CORRELAÇÃO POSITIVA DETECTADA - PONTOS AUMENTAM ASSIM COMO A LINHA
sns.regplot(x="N_algarismos", y="runtime", data=df)
plt.savefig('save_as_a_png.png')


#DESCRIÇAÕ DO GRAFICO 
#LINHA -  MÉDIA DOS PONTOS
#PONTOS -  VALORES DA VARIAVEL COMPARADA COM "price"
#VALORES EIXO Y - VALORES DO PREÇO
#EIXO X - VALORES DA VARIAVEL COMPARADA