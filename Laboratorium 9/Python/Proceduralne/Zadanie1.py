def func():
    x = input("Podaj liczbę: ")
    wynik = sum(int(cyfra) for cyfra in x )
    print(wynik)
func()