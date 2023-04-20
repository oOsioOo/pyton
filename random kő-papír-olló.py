"""
Készítsünk kő, papír, olló játékot!
A géppel játsszunk, úgy hogy bekérünk egy választ (kő, papír vagy olló)
és a gép is véletlenszerűen előállít egyet e három közül (listából), majd kiírjuk,
hogy melyik nyer.
(A papír nyer a kővel szemben, a kő az olló ellen, míg
az olló a papír ellen. Ha azonosak nem nyer egyik sem.) A játék lehet
előre beállított fordulós, vagy végjelig játszható.
A végén írjuk ki az eredményt!
A gép válaszait listába tároljuk és onnan válasszon véletlenszerűen a gép választását (random modul).

"""

import random


pc = ["Kő","Papír","Olló"]
pc_win = 0
p_win = 0



while pc_win != 3 and p_win != 3:
    r = random.choice(pc)
    p = int(input("\nKérem válasszon ! 1 - KŐ, 2 - PAPíR, 3 - OLLÓ "))

    if 1 <= p <= 3:
        if p == 1:
            p = pc[0]
        elif p == 2:
            p = pc[1]
        elif p == 3:
            p = pc[2]
        print("A PC választása: ", r)
        print("Player választása: ", p)
    else:
        print("Rosz adat!")

    if r == p:
        print("Döntetlen!")

    if r == pc[0] and p == pc[1]:
        print("Player won!")
        p_win += 1
    elif r == pc[1] and p == pc[0]:
        print("PC won!")
        pc_win += 1
    elif r == pc[1] and p == pc[2]:
        print("Player won!")
        p_win +=1
    elif r == pc[2] and p == pc[1]:
        print("PC won!")
        pc_win += 1
    elif r == pc[2] and p == pc[0]:
        print("Player won!")
        p_win += 1
    elif r == pc[0] and p == pc[2]:
        print("PC won!")
        pc_win += 1

    print("Player scores: ", p_win)
    print("PC scores: ", pc_win)

