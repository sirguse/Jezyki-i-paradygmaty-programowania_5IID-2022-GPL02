
# def analyze_data(data):
#     # Zwróć największą liczbę (lub wartość numeryczną)
#     numbers = list(filter(lambda x: isinstance(x, (int, float)), data))
#     max_number = max(numbers) if numbers else None
#     return max_number


def Zadanie3(data):
    liczby = list(filter(lambda x: isinstance(x, (int,float)),data)) #Funkcja isinstance sprawdza czy iterowalne wartości przez lambde są intem, lub floatem
    najwieksza_liczba = max(liczby) if liczby else None # Warunek sprawdza czy lista nie jest pusta, jako iż lista zawiera elemnty, if zostaje wykonany, w innym przypadku zwraca wartość None

    napis = list(filter(lambda x: isinstance(x, str), data))
    najdluzszy_napis = max(napis, key=len) #funkcja max, pozwala na zwrócenie elementu, który znajduje się najwyżej alfabetycznie, lecz gdy zastosuje key=len, wtedy zostają porównywane długości
    
    krotka = list(filter(lambda x: isinstance(x, tuple), data))
    najdlusza_krotka = max(krotka, key=len)
    print(najdlusza_krotka)

data = [1, "Hello", (1, 2), 3.5, "Goodbye", (1, 2, 3), {"key": "value"}, [1, 2, 3]]
Zadanie3(data)