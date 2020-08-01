#Programa 1 Programa 1 Programa 1 Programa 1 Programa 1 Programa 1 Programa 1 Programa 1
op = int(input("Programa 1 ou 2"))
if(op == 1):
    print("Pesquisa de Satisfação")
    print("\tNota\tValor")
    print("\tA\tÓtimo")
    print("\tB\tBom")
    print("\tC\tRegular")
    print("\tD\tRuim")
    print("\tE\tPéssimo")
    conta = 0
    contb = 0
    contc = 0
    contd = 0
    conte = 0
    acid = 0
    for i in range(0,10):
        idade = int(input("Digite sua idade:"))
        nt = input("Nota:")
        if(nt == 'a'):
            conta+=1
            id1 = idade
            if(idade > id1):
                id1 = idade
        if(nt == 'b'):
            contb+=1
        if(nt == 'c'):
            contc+=1
        if(nt == 'd'):
            contd+=1
            acid = acid + idade
            id2 = idade
            if(idade > id2):
                id2 = idade
        if(nt == 'e'):
            conte+=1
            id3 = idade
            if(idade > id3):
                id23 = idade
    pcB = (contb*100)/10
    pcRe = (contc*100)/10
    pcBR = pcB - pcRe
    did = id1-id2
    mdid = acid / contd
    pcP = conte*100/10
    print("A)Foram {} avaliações A".format(conta))
    print("B)A diferença percentual entre Bom e Regular foi de {}".format(pcBR))
    print("C)A média das idades de quem votou em Ruim é {}".format(mdid))
    print("D)A porcentagem de respostas péssimo {0} e a maior idade que utilizou esta opção foi {1}".format(pcP,id3))
    print("E)A diferença de idade entre a maior idade que respondeu ótimo e a maior idade que respondeu ruim é {}".format(did))

elif(op == 2):
#Programa 2 Programa 2 Programa 2 Programa 2 Programa 2 Programa 2 Programa 2 Programa 2 
    print("Pesquisa de Utilização dos elevadores")
    idade = 1
    conta = 0
    contb = 0
    contc = 0
    contam = 0
    contbm = 0
    contcm = 0
    contav = 0
    contbv = 0
    contcv = 0
    contan = 0
    contbn = 0
    contcn = 0
    contm = 0
    contv = 0
    contn = 0
    fxm = 0
    fxv = 0
    fxn = 0
    cont = 0
    fx2 = 0
    fx1 = 0
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
            if(ele.upper() == 'A'):
                contam += 1
            if(ele.upper() == 'B'):
                contbm += 1
            if(ele.upper() == 'C'):
                contcm += 1
            fxm = contam + contbm + contcm
        if(per.upper() == 'V'):
            contv += 1
            if(ele.upper() == 'A'):
                contav += 1
            if(ele.upper() == 'B'):
                contbv += 1
            if(ele.upper() == 'C'):
                contcv += 1
            fxv = contav + contbv + contcv
        if(per.upper() == 'N'):
            contn += 1
            if(ele.upper() == 'A'):
                contan += 1
            if(ele.upper() == 'B'):
                contbn += 1
            if(ele.upper() == 'C'):
                contcn += 1
            fxn = contan + contbn + contcn
        cont = cont + 1
    maior = ""
    if(conta > contb and conta > contc):
        maior = "A"
        if(contam > contav and contam > contan):
            a = "Manhã"
        elif(contav > contam and contav > contan):
            a = "Vespertino"
        elif(contan > contam and contan > contav):
            a = "Noturno" 
    elif(contb > conta and contb > contc):
        maior = "B"
        if(contbm > contbv and contbm > contbn):
            a = "Manhã"
        elif(contbv > contbm and contbv > contbn):
            a = "Vespertino"
        elif(contbn > contbm and contbn > contbv):
            a = "Noturno" 
    elif(contc > contb and contc > conta):
        maior = "C"
        if(contcm > contcv and contcm > contcn):
            a = "Manhã"
        elif(contcv > contcm and contcv > contcn):
            a = "Vespertino"
        elif(contcn > contcm and contcn > contcv):
            a = "Noturno" 
    fx = ""
    if(fxm > fxv and fxm > fxn):
        fx = "Manhã"
        fx1 = fxm
        if(contam > contbm and contam > contcm):
            m = "A"
        elif(contbm > contam and contbm > contcm):
            m = "B"
        elif(contcm > contam and contcm > contbm):
            m = "C"
    elif(fxv > fxm and fxv > fxn):
        fx = "Vespertino"
        fx1 = fxv
        if(contam > contbm and contam > contcm):
            m = "A"
        elif(contbm > contam and contbm > contcm):
            m = "B"
        elif(contcm > contam and contcm > contbm):
            m = "C"
    elif(fxn > fxm and fxn > fxv):
        fx = "Noturno"
        fx1 = fxn
        if(contam > contbm and contam > contcm):
            m = "A"
        elif(contbm > contam and contbm > contcm):
            m = "B"
        elif(contcm > contam and contcm > contbm):
            m = "C"
    if(fxm < fxv and fxm < fxn):
        fx2 = fxm
    elif(fxv < fxm and fxv < fxn):
        fx2 = fxv
    elif(fxn < fxm and fxn < fxv):
        fx2 = fxn
            
    pcM = (fx1 * 100) / cont
    pcm = (fx2 * 100) / cont
    dif = pcM - pcm
    pcf = (fx1 * 100) / cont
    print("A)Pessoas que usam o elevador A {0}, B {1} e C {2}".format(conta,contb,contc))
    print("B)Pessoas que usam o elevador Matutino {0}, Vespertino {1} e Noturno {2}".format(contm,contv,contn))
    print("C)Elevador mais usado: {0} e período de maior fluxo: {1}".format(maior,a))
    print("D)O período mais usado de todos {0} e a que elevador pertenc {1}".format(fx,m))
    print("E)A diferença percentual entre o mais usado dos horários e o menos usado é {}".format(dif))
    print("F)A porcentagem sobre o total de serviços prestados do elevador de media utilização {}".format(pcf))
else:
    print("Opção inválida")
