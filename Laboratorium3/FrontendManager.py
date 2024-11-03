from EmployeeManager import EmployeesManager

class FrontendManager:
    def __init__(self):
        self.manager = EmployeesManager()

    def login(self):
        username = input("Login: ")
        password = input("Password: ")

        if username == 'admin' and password == 'admin':
            return True
        
        else:
            return False
        
    

    def run(self):
        if not self.login():
            return
        while True:
            print("\n1. Dodaj nowego pracownika")
            print("2. Wyświetl listę pracowników")
            print("3. Usuń pracowników według przedziału wiekowego")
            print("4. Zaktualizuj wynagrodzenie pracownika")
            print("5. Wyjdź")
            choice = input("Wybierz opcję: ")

            if choice == '1':
                firstName = input("Podaj imię: ")
                lastName = input("Podaj nazwisko: ")
                age = int(input("Podaj wiek: "))
                salary = float(input("Podaj wynagrodzenie: "))
                self.manager.addEmployee(firstName, lastName, age, salary)
                print("Pracownik dodany.")
            elif choice == '2':
                print(self.manager.DisplayEmployee())
            elif choice == '3':
                min_age = int(input("Podaj minimalny wiek: "))
                max_age = int(input("Podaj maksymalny wiek: "))
                self.manager.Remove_Employee_By_age(min_age, max_age)
                print("Pracownicy w przedziale wiekowym usunięci.")
            elif choice == '4':
                firstName = input("Podaj imię: ")
                lastName = input("Podaj nazwisko: ")
                new_salary = float(input("Podaj nowe wynagrodzenie: "))
                print(self.manager.Update_Salary(firstName, lastName, new_salary))
            elif choice == '5':
                print("Zamykam program.")
                break
            else:
                print("Nieprawidłowy wybór, spróbuj ponownie.")