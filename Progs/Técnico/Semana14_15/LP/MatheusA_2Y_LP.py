#Programa 1
num = int(input("Digite um número de 0 a 9999: "))
u = num % 10
d = num // 10 % 10
c = num // 100 % 10
m = num // 1000 % 10
print("Número: {}".format(num))
print("Unidade: {}".format(u))
print("Dezena: {}".format(d))
print("Centena: {}".format(c))
print("Milhar: {}".format(m))
#Programa 2
cid = str(input("Em qual cidade você nasceu?")).strip()
print(cid[:5].upper() == 'SANTO')
print("Sua cidade tem :", len(cid), " letras")
#Programa 3
nome = str(input("Digite um nome: ")).upper()
print('SILVA' in nome)
#Programa 4
frase = str(input("Digite uma frase: ")).upper()
print("A letra 'a' aparece ", frase.count('A'), " vezes")
print("A letra 'a' aparece pela 1º vez na posição {}".format(frase.find('A')+1))
print("A letra 'a' aparece pela última vez na posição {}".format(frase.rfind('A')+1))
#Programa 5
nome1 = input("Digite seu nome: ")
n = nome1.split()
print("Seu 1º nome é {}".format(n[0]))
print("Seu último nome é {}".format(n[len(n) - 1]))
