# Árlista tartalma
levesek = {
    "Frankfurti leves": 550,
    "Zöldségleves": 400,
    "Gyümölcsleves": 300
}
foetelek = {
    "Szezámmagos csirkemell": 600,
    "Pizza 2 szelet": 550,
    "Csirkecomb BBQ": 550
}
fozelekek = {
    "Borsófőzelék": 200,
    "Finomfőzelék": 150
}
koretek = {
    "Sültkrumpli": 300,
    "Rizs": 200
}
szoszok = {
    "Kentacky": 100,
    "Ketchup": 100,
    "BBQ": 100
}

#változók megadása
vegosszeg=0
valasztott={}
kilepes=False
H_P=False
H=False
ujra=False

# üdvözlö képernyő
print(8 * "\t", "***************************************")
print(8 * "\t", "* Üdvözöljük önöket a BISTRO iskolai  *")
print(8 * "\t", "*          étkezdében!                *")
print(8 * "\t", "***************************************")

#feladat
while not kilepes:

    #menü elágazás megadása
    menu = bool(input("Ha szeretné megtekinteni az étlapot kérem nyomja meg az ENTER billentyűt "))


    # Árlista kiíratása
    if menu == False:

            print("Árlista:\n")

            print("Levesek:\n", 40 * "*", sep="")
            for x, y in levesek.items():
              print(x, y, "Ft")
            print(40 * "*")

            print("\nFőételek:\n", 40 * "*", sep="")
            for x, y in foetelek.items():
                print(x, y, "Ft")
            print(40 * "*")

            print("\nFőzelékek:\n", 40 * "*", sep="")
            for x, y in fozelekek.items():
                print(x, y, "Ft")
            print(40 * "*")

            print("\nKöretek:\n", 40 * "*", sep="")
            for x, y in koretek.items():
               print(x, y, "Ft")
            print(40 * "*")

            print("\nSzószok:\n", 40 * "*", sep="")
            for x, y in szoszok.items():
                print(x, y, "Ft")
            print(40 * "*")
            i = 0
            #Ételek bekérése
            while i != 1:
                leves = input("\nSzeretne levest? I/N: ")
                if leves == "i" or leves == "I":
                    leves = True
                    while leves:
                        for x,y in levesek.items():
                            v_leves = input(f"Szeretné ezt a levest: {x} >> I/N: ")
                            if v_leves == "i" or v_leves == "I":
                                valasztott.update({x:y})
                                leves = False
                                i = 1
                                break
                            elif v_leves == "n" or v_leves == "N":
                                i = 1
                            else:
                                print("\nNem jó betűt adott meg, kérem próbálja újra\n")
                                break
                elif leves == "n" or leves == "N":
                    i = 1

                else:
                    print("\nNem jó betűt adott meg, kérem próbálja újra\n")

            i = 0
            while i != 1:
                f_etel=input("\nSzeretne főételt? I/N: ")
                if f_etel == "i" or f_etel == "I":
                    f_etel = True
                    while f_etel:
                        for x,y in foetelek.items():
                            v_f_etel = input(f"Szeretné ezt a főátelt: {x} >> I/N: ")
                            if v_f_etel == "i" or v_f_etel == "I":
                                valasztott.update({x:y})
                                f_etel = False
                                i = 1
                                break
                            elif v_f_etel == "n" or v_f_etel == "N":
                                i = 1
                            else:
                                print("\nNem jó betűt adott meg, kérem próbálja újra\n")
                                break
                elif f_etel == "n" or f_etel == "N":
                    i = 1
                else:
                    print("\nNem jó betűt adott meg, kérem próbálja újra\n")

            i = 0
            while i != 1:
                fozelek=input("\nSzeretne főzeléket? I/N: ")
                if fozelek == "i" or fozelek == "I":
                    fozelek = True
                    while fozelek:
                        for x,y in fozelekek.items():
                            v_fozelek = input(f"Szeretné ezt a főzeléket: {x} >> I/N: ")
                            if v_fozelek == "i" or v_fozelek == "I":
                                valasztott.update({x:y})
                                fozelek = False
                                i = 1
                                break
                            elif v_fozelek == "n" or v_fozelek == "N":
                                i = 1
                            else:
                                print("\nNem jó betűt adott meg, kérem próbálja újra\n")
                                break
                elif fozelek == "n" or fozelek == "N":
                    i = 1
                else:
                    print("\nNem jó betűt adott meg, kérem próbálja újra\n")

            i = 0
            while i != 1:
                koret=input("\nSzeretne köretet? I/N: ")
                if koret == "i" or koret == "I":
                    koret = True
                    while koret:
                        for x,y in koretek.items():
                            v_koret = input(f"Szeretné ezt a köretet: {x} >> I/N: ")
                            if v_koret == "i" or v_koret == "I":
                                valasztott.update({x:y})
                                koret = False
                                i = 1
                                break
                            elif v_koret == "n" or v_koret == "N":
                                i = 1
                            else:
                                print("\nNem jó betűt adott meg, kérem próbálja újra\n")
                                break
                elif koret == "n" or koret == "N":
                    i = 1
                else:
                    print("\nNem jó betűt adott meg, kérem próbálja újra\n")

            i = 0
            while i != 1:
                szosz=input("\nSzeretne szószt? I/N: ")
                if szosz == "i" or szosz == "I":
                    szosz = True
                    while szosz:
                        for x,y in szoszok.items():
                            v_f_etel = input(f"Szeretné ezt a szószt: {x} >> I/N: ")
                            if v_f_etel == "i" or v_f_etel == "I":
                                valasztott.update({x:y})
                                szosz = False
                                i = 1
                                break
                            elif v_f_etel == "n" or v_f_etel == "N":
                                i = 1
                            else:
                                print("\nNem jó betűt adott meg, kérem próbálja újra\n")
                                break
                elif szosz == "n" or szosz == "N":
                    i = 1
                else:
                    print("\nNem jó betűt adott meg, kérem próbálja újra\n")


            #Menübe sorolás ellenőrzése
            if not ujra:
                ujra=True
                if "Zöldségleves" in valasztott.keys():
                    if (("Szezámmagos csirkemell" in valasztott.keys()) or ("Csirkecomb BBQ" in valasztott.keys())):
                        if (("Sültkrumpli" in valasztott.keys())  or ("Rizs" in valasztott.keys())):
                            print("\n\nÖn a H-P -i menüt választotta\n")
                            kilepes = True
                            H_P=True

                elif (("Gyümölcsleves" in valasztott.keys()) or ("Frankfurti leves" in valasztott.keys())):
                    if (("Csirkecomb BBQ" in valasztott.keys()) and ("Sültkrumpli" in valasztott.keys())):
                        print("\n\nÖn a Hétvégi menüt választotta!\n")
                        H = True
                        ha_r=bool(input("Ha még szeretne rendelni kérem nyomja le az ENTER bilentyűt!"))
                        if ha_r==True:
                            kilepes = True

                    elif (("Szezámmagos csirkemell" in valasztott.keys()) and ("Rizs" in valasztott.keys())):
                        print("\n\nÖn a Hétvégi menüt választotta!\n")
                        H = True
                        ha_r = bool(input("Ha még szeretne rendelni kérem nyomja le az ENTER bilentyűt!"))
                        if ha_r == True:
                            kilepes = True


            if not H_P and not H:
                print("\n\nÖn egyedi menüt választott!\n")
                kilepes = True

    else:
            kilepes = bool(input("\nHa szeretne kilépni nyomoja le az ENTER billentyűt, vagy bármi mást az újrakezdéshez "))



#A választott menü és a végöszegg kiíratása
print("\nA kiválasztott menü a következő:\n")

for x,y in valasztott.items():
    print(x,y, "Ft")
    vegosszeg += y

print(f"\nA választott menü végösszege: {vegosszeg} Ft ")

if vegosszeg <= 1500:
    print("A menü a megadott értékhatáron belül van")
else:
    print("A menü ára meghalladta a napi keretünket!")

print("\nKöszönjük hogy a BISTRO konyháját választotta!\nKérem válasszon minket máskor is!")