print("Pesquisa de Utilização dos elevadores")
idade = 1
conta = 0
contb = 0
contc = 0
contm = 0
contv = 0
contn = 0
fxm = 0
fxv = 0
fxn = 0
print("Elevadores:\nA\nB\nC")
print("Período:\nMatutino(m)\nVespertino(v)\nNoturno(n)")
while(idade != 0):
    nome = input("Digite seu nome:")
    idade = int(input("Digite sua idade:"))
    ele = input("Qual elevador você usa com mais frequência:")
    per = input("Em qual período:")
    if(ele.upper() == 'A'):
        conta += 1
    if(ele.upper() == 'B'):
        contb += 1
    if(ele.upper() == 'C'):
        contc += 1
    if(per.upper() == 'M'):
        contm += 1
        fxm = conta + contb + contc
    if(per.upper() == 'V'):
        contv += 1
    if(per.upper() == 'N'):
        contn += 1
maior = ""

if(conta > contb and conta > contc):
    maior = "A"
elif(contb > conta and contb > contc):
    maior = "B"
elif(contc > contb and contc > conta):
    maior = "C"
print("A)Pessoas que usam o elevador A {0}, B {1} e C {2}".format(conta,contb,contc))
print("B)Pessoas que usam o elevador Matutino {0}, Vespertino {1} e Noturno {2}".format(contm,contv,contn))
print("C)Elevador mais usado: {0} e período de maior fluxo: {1}".format(maior,fluxo))
print("Fim")
