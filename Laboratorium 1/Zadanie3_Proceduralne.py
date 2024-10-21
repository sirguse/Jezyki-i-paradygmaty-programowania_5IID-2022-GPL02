zadania = [
    {"czas_wykonania": 3, "nagroda": 100},
    {"czas_wykonania": 1, "nagroda": 50},
    {"czas_wykonania": 2, "nagroda": 75},
]

# Proceduralne podejście
def optymalizacja_zadan_proceduralnie(zadania):
    zadania.sort(key=lambda zadanie: zadanie["czas_wykonania"])
    calkowity_czas_oczekiwania = 0
    czas_biezacy = 0
    for zadanie in zadania:
        calkowity_czas_oczekiwania += czas_biezacy
        czas_biezacy += zadanie["czas_wykonania"]

    return zadania, calkowity_czas_oczekiwania

optymalna_kolejnosc, czas_oczekiwania = optymalizacja_zadan_proceduralnie(zadania)
print("Optymalna kolejność zadań (proceduralnie):", optymalna_kolejnosc)
print("Całkowity czas oczekiwania:", czas_oczekiwania)


#Suma = 0 + 1 + 3 = 4.