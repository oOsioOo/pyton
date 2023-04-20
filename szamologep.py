from tkinter import *

#valtozok
tarolas = ""

#definiállás
def tisztitas():
    global tarolas
    tarolas = ""
    kijelzo.config(text=tarolas)

def beolvas(szam):
    global tarolas
    tarolas += szam
    kijelzo.config(text=str(tarolas))

def negativ():
    global tarolas
    if tarolas !="":
        tarolas = str(eval(tarolas + "*(-1)"))

    kijelzo.config(text=tarolas)

def szamolas():
    global tarolas
    eredmeny = ""
    if tarolas != "":
        try:
            eredmeny = eval(tarolas)

        except:
            eredmeny = "Hiba!"
            tarolas = ""
    kijelzo.config(text=eredmeny)


#ablak beallitasai
ablak = Tk()
ablak.title("Számológép")
ablak.geometry("570x700")
ablak.resizable(False,False)
ablak.config(bg="#000012")


kijelzo = Label(ablak, width=25, height=2, text="", font=("Kristen ITC",32))
kijelzo.pack()


#billentyuzet beallitasai
Button(ablak, text="C", height=1, width=4, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#3697f5", command=lambda: tisztitas()).place(x = 10, y = 131)
Button(ablak, text="+/-", height=1, width=4, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#C18A1C",command=lambda: negativ()).place(x = 150, y = 131)
Button(ablak, text="%", height=1, width=4, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#C18A1C", command=lambda: beolvas("%")).place(x = 290, y = 131)
Button(ablak, text=chr(247), height=1, width=4, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#C18A1C", command=lambda: beolvas("/")).place(x = 430, y = 131)

Button(ablak, text="7", height=1, width=4, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#5B574E", command=lambda: beolvas("7")).place(x = 10, y  = 242)
Button(ablak, text="8", height=1, width=4, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#5B574E", command=lambda: beolvas("8")).place(x = 150, y = 242)
Button(ablak, text="9", height=1, width=4, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#5B574E", command=lambda: beolvas("9")).place(x = 290, y = 242)
Button(ablak, text="x", height=1, width=4, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#C18A1C", command=lambda: beolvas("*")).place(x = 430, y = 242)

Button(ablak, text="4", height=1, width=4, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#5B574E", command=lambda: beolvas("4")).place(x = 10, y = 354)
Button(ablak, text="5", height=1, width=4, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#5B574E", command=lambda: beolvas("5")).place(x = 150, y = 354)
Button(ablak, text="6", height=1, width=4, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#5B574E", command=lambda: beolvas("6")).place(x = 290, y = 354)
Button(ablak, text="-", height=1, width=4, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#C18A1C", command=lambda: beolvas("-")).place(x = 430, y = 354)

Button(ablak, text="1", height=1, width=4, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#5B574E", command=lambda: beolvas("1")).place(x = 10, y = 466)
Button(ablak, text="2", height=1, width=4, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#5B574E", command=lambda: beolvas("2")).place(x = 150, y = 466)
Button(ablak, text="3", height=1, width=4, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#5B574E", command=lambda: beolvas("3")).place(x = 290, y = 466)
Button(ablak, text="+", height=1, width=4, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#C18A1C", command=lambda: beolvas("+")).place(x = 430, y = 466)

Button(ablak, text="0", height=1, width=5, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#5B574E", command=lambda: beolvas("0")).place(x = 10, y = 577)
Button(ablak, text=".", height=1, width=4, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#5B574E", command=lambda: beolvas(".")).place(x = 170, y = 577)
Button(ablak, text="=", height=1, width=8, font=("Kristen ITC", 32, "bold"), bd=5, fg="#fff", bg="#C18A1C", command=lambda: szamolas()).place(x = 309, y = 577)


#program futtatasa
ablak.mainloop()

