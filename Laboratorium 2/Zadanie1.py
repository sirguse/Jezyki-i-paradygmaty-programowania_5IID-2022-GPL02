import re
from collections import Counter

tekst = "Aplikacja mobilna do planowania tygodniowego harmonogramu. ćwiczeń dostosowująca program na podstawie dostępności użytkownika oraz preferowanego. czasu trwania sesji"

def Zadanie1(tekst):
    paragraph = tekst.strip().split('\n')
    numParagraph = len(paragraph)

    zdania = tekst.strip().split('.')
    zdanie = re.split(r'[.!?]+', tekst)
    numZdania = len([s for s in zdania if s.strip()])


    slowa = tekst.split()
    slowanum = len(slowa)
    stop_word = {'i','o','a','z','w','u'}

    filter_word = filter(lambda slowo: slowo not in stop_word, slowa)
    filter_wordsNumber = Counter(filter_word)

    print(f"Liczba akapitów {numParagraph}")
    print(f"Liczba zdań: {numZdania}")
    print(f"Liczba słów: {slowanum}")

Zadanie1(tekst)