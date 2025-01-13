import math
# Wzór: ax^2 + bx + c = 0
def func():
    try:
        a = float(input("Podaj a =/= 0 "))
        if a==0:
            raise ValueError("Nie moze miec wartości 0")
        b = float(input("Podaj b: "))
        c = float(input("Podaj c: "))

        delta = b**2 - (4*a*c)
        print(f"Delta to: {delta}")

        match delta:
            case d if d>0:
                x1 = (-b - math.sqrt(delta))/ (2*a)
                x2 = (-b + math.sqrt(delta))/ (2*a)
            case 0:
                x = -b / (2*a)
                
            case d if d<0:
                print("Brak rozwiązań")
    except ValueError as e:
        print(f"Błąd: {e}")


    
    
func()