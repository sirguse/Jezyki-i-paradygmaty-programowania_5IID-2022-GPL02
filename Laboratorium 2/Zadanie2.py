import numpy as np




def DodawanieMacierzy(mac1, mac2): 
    if mac1.shape != mac2.shape:
        raise ValueError("Macierze muszą być tych samych wymiarów.")
    
    return mac1 + mac2

def OdejmowanieMacierzy(mac1,mac2):
    if mac1.shape != mac2.shape:
        raise ValueError("Macierze muszą być tych samych wymiarów.")
    
    return mac1 - mac2

def MnożenieMacierzy(mac1,mac2):
    if mac1.shape[1] != mac2.shape[0]:
        raise ValueError("Macierze muszą być tych samych wymiarów.")
    
    return np.dot(mac1,mac2)

def TransponowanieMacierzy(mac):
    return np.transpose(mac)


def WykonywanieOperacji(operacja, mac1,mac2=None): #None powoduje że możemy, ale nie musimy zrobić działanie dla 2 macierzy, co pozwala mi na dokonanie transponowania jednej macierzy.
    if operacja == 'transponuj':
        if mac2 is not None:
            return TransponowanieMacierzy(mac2)
        return TransponowanieMacierzy(mac1)
    

    if operacja == 'dodaj':
        return DodawanieMacierzy(mac1,mac2)

    elif operacja =='odejmij':
        return OdejmowanieMacierzy(mac1,mac2)
    
    elif operacja == 'pomnoz':
        return MnożenieMacierzy(mac1,mac2)
    


if __name__ == "__main__": #Wiem że jest to nie potrzebne, ale warto wywoływać to jako główny program :)
    Macierz_1 = np.array([[1,2,3],[4,5,6],[7,8,9]])
    Macierz_2 = np.array([[1,2,3],[4,5,6],[7,8,9]])



    try:
        print("Transponowanie Macierzy 1: ")
        print(WykonywanieOperacji('transponuj',Macierz_1))

        print("Transponowanie Macierzy 2: ")
        print(WykonywanieOperacji('transponuj', Macierz_2))

        
        print("Dodawanie macierzy")
        print(WykonywanieOperacji('dodaj', Macierz_1,Macierz_2))


        print("Odejmowanie macierzy")
        print(WykonywanieOperacji('dodaj', Macierz_1,Macierz_2))
        print("Mnożenie macierzy")
        print(WykonywanieOperacji('pomnoz', Macierz_1,Macierz_2))
    except ValueError:
        print(ValueError)





