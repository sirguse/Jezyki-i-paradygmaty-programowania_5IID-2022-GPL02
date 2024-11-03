class Employee:
    def __init__(self, firstName, lastName, age, salary):
        self.firstName = firstName
        self.lastName = lastName
        self.age = age
        self.salary = salary
    
    def View(self):
        return f"Pracownik {self.firstName} {self.lastName}, wiek: {self.age}, zarobki: {self.salary}"
    
    def __str__(self):
        return self.View()

    def __repr__(self):
        return (f"Pracownik imie={self.firstName}, nazwisko={self.lastName}, wiek={self.age}, zarobki={self.salary}")

    def to_dict(self):
        return {
            "firstName": self.firstName,
            "lastName": self.lastName,
            "age": self.age,
            "salary": self.salary
        }

    @staticmethod
    def from_dict(data):
        return Employee(data["firstName"], data["lastName"], data["age"], data["salary"])