class Employee:
    def __init__(self, firstName, lastName, age, salary):
        self.firstName = firstName
        self.lastName = lastName
        self.age = age
        self.salary = salary
    def View(self):
        return (f"Pracownik {self.firstName} {self.lastName}, wiek: {self.age}, zarobki: {self.salary}")
    def __str__(self):
        return (f"Pracownik {self.firstName} {self.lastName}, wiek: {self.age}, zarobki: {self.salary}")

    def __repr__(self):
        return (f"Pracownik imie ={self.firstName}, nazwisko={self.lastName}, wiek ={self.age}, zarobki= {self.salary}")

pracownik = Employee('Jan', "Nowak", 34, 1200)
print(pracownik)
print(repr(pracownik))
print(pracownik.View())


