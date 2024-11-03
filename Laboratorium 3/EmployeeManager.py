from Employee import Employee
import json
import os
class EmployeesManager:
    FILE_PATH = "employess.json"
    def __init__(self):
        self.employess = []
        self.load_employess()


    def load_employess(self):
        if os.path.exists(self.FILE_PATH):
            with open(self.FILE_PATH , 'r') as file: #r bo read
                data = json.load(file)
                self.employees = [Employee.from_dict(emp) for emp in data]



    def save_employees(self):
        with open(self.FILE_PATH, 'w') as file:
            json.dump([emp.to_dict() for emp in self.employees], file, indent=4)





    def addEmployee(self, firstName,lastName,age,salary):
        new_employee = Employee(firstName,lastName,age,salary)
        self.employess.append(new_employee)
        self.save_employees()



    def DisplayEmployee(self):
        if not self.employess:
            return "Brak pracowników"
        else:
            print(self.employess)

    def Remove_Employee_By_age(self,min_age,max_age):
        self.employess = [emp for emp in self.employess if not (min_age<=emp.age <=max_age)]

    def find_employee(self, firstName,lastName):
        for emp in self.employess:
            if emp.firstName == firstName and emp.lastName == lastName:
                return emp
            return None

    def Update_Salary(self, firstName,lastName, new_salary):
        employee = self.find_employee(firstName,lastName) 
        if employee:
            employee.salary = new_salary
            return f"{employee.firstName} został zaktualizowany"
        return "Wpisz poprawne dane"
    
    