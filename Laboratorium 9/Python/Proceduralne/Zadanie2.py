def kalkulator():
    x = input("Wybierz operacje: '+', '-', '*', ':' ")
    match x:
        case '+':
            print("Wybrales dodawanie")
            a = int(input("Podaj pierwszą liczbę: "))
            b = int(input("Podaj drugą liczbę: "))
            print(f"Wynik to: {a + b}")
        case '-':
            print("Wybrales odejmowanie")
            c = int(input("Podaj pierwszą liczbę: "))
            d = int(input("Podaj drugą liczbę: "))
            print(f"Wynik to: {c+d}")

        case '*':
            print("Wybrałeś mnożenie")
            e = int(input("Podaj pierwszą liczbę: "))
            f = int(input("Podaj drugą liczbę: "))
            print(f"Wynik to: {c*d}")

        case ":":
            print("Wybrałeś dzielenie")
            g = int(input("Podaj pierwszą liczbę: "))
            h = int(input("Podaj drugą liczbę: "))
            print(f"Wynik to: {g/h}")
kalkulator()