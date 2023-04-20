adatok = []

forras = open("nyilvantartas.txt","r",encoding="utf-8")
for sor in forras:
    sor = sor.strip().split(" ")
    adatok.append(sor)
print(adatok)

nev = " "
while nev == "":
    nev = input("Név: ")
    if nev == "":
        break
    forgalom = input("Forgalom: ")
    ceg = input("Cég neve: ")
    ev = input("Évek száma: ")
    adatok.append([nev, forgalom, ceg, ev])

