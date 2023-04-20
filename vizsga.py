
def vizsga(a,b):
    if a >= 48:
        return f"{b} vizsgája sikeres."
    else:
        return f"{b} vizsgája sikertelen."

while True:
    nev = input("Kérem a vizsgázó nevét: ")
    if nev == "":
        break
    num = int(input("Add meg a pontszámát: "))
    print(vizsga(num,nev))


