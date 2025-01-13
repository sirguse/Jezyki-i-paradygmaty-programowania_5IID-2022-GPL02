import csv

def oblicz_srednia(nazwa_pliku, nazwa_kolumny):
    try:
        with open(nazwa_pliku, mode='r', encoding='utf-8-sig') as plik:  # Zmiana kodowania na utf-8-sig
            czytnik = csv.DictReader(plik, delimiter=';')

            # Diagnostyka: Wyświetlenie nagłówków
            print(f"Nagłówki kolumn w pliku: {czytnik.fieldnames}")
            
            # Pobranie wartości z wybranej kolumny
            wartosci = [float(wiersz[nazwa_kolumny]) for wiersz in czytnik if wiersz[nazwa_kolumny]]

            if wartosci:
                srednia = sum(wartosci) / len(wartosci)
                print(f"Średnia dla kolumny '{nazwa_kolumny}' wynosi: {srednia:.2f}")
            else:
                print(f"Kolumna '{nazwa_kolumny}' jest pusta.")
    except FileNotFoundError:
        print(f"Plik '{nazwa_pliku}' nie został znaleziony. Upewnij się, że ścieżka jest poprawna.")
    except KeyError:
        print(f"Kolumna '{nazwa_kolumny}' nie istnieje w pliku CSV. Sprawdź nagłówki i upewnij się, że są poprawne.")
    except ValueError as e:
        print(f"Wystąpił problem z konwersją wartości: {e}")
    except Exception as e:
        print(f"Wystąpił nieoczekiwany błąd: {e}")

# Ścieżka do pliku CSV
nazwa_pliku = r"C:\Users\TesSf\Desktop\Laboratorium 9\Python\Proceduralne\11.csv"

# Diagnostyka: Wyświetlenie ścieżki
print(f"Ścieżka do pliku: {nazwa_pliku}")

# Nazwa kolumny do analizy
nazwa_kolumny = input("Podaj nazwę kolumny do analizy (np. K1, K2, K3): ")

# Wywołanie funkcji
oblicz_srednia(nazwa_pliku, nazwa_kolumny)
