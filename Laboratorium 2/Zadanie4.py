from functools import reduce
import numpy as np


def Zadanie4(macierz, operacja):

    try:
        result = reduce(lambda x,y: eval(operacja), macierz) #lambda musi posiadać x,y ze względu na użycie metody reduce.
        return result
    
    except ValueError:
        print('Wystąpił błąd')



operacja = "x * y"

macierz = [
    np.array([[1,2],[3,4]]),
    np.array([[5,6],[7,8]]),
    np.array([[9,10],[11,12]])
]

print(Zadanie4(macierz,operacja))