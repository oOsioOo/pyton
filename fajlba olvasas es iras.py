"""
`r` - read, csak olvasasra nyitjuk meg a filet!
`w` write, irasra nyitjuk meg, vagy letrehozza
`a` append, hozzafuzok uj adatokat a fajlhoz
open() -- fugveny
"""

forras = open("mondat.txt", 'r', encoding="utf-8")
print(forras)
#fajl tartalmanak listaba tarolasa


lista = []
for sor in forras:
    print(sor)
    sor = sor.strip()
    sor = sor.split()
    lista.append(sor)
print(lista)


#fajlba iras mondat2.txt

forras = open('mondat2.txt', 'w', encoding="utf-8")
forras.write("ez az elso mondat!\n")
forras.write("masodik mondat!")
forras.close()

#karakterenkent olvasas fajlbol

forras = open("mondat2.txt","r")
while True:
    betu = forras.read(1)
    if betu:
        if betu == 'm':
            print('MMM')
        else:
            print(betu)
    else:
        break

forras.close()

#fijlba iras  print fugvennyel

lista2 = [1,2,3,4,5,5,6,7]
cel = open("szamok.txt", "w")

for szam in lista2:
    print(szam)
    print(szam)
    print(szam, end="\n", file=cel)
cel.close()
#fajl felulirasa
cel = open("szamok.txt", "w")
cel.write("Szombat reggel!")
cel.close()

#hozzafuzes
cel = open("szamok.txt", "a", encoding="utf-8")
cel.write("\nHozzafuzes")
cel.close()




