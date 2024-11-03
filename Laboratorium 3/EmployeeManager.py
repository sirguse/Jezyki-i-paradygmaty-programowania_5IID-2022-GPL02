from Employee import Employee

class EmployeesManager:
    def __init__(self):
        self.employess = []

    def addEmployee(self, firstName,lastName,age,salary):
        new_employee = Employee(firstName,lastName,age,salary)
        self.employess.append(new_employee)

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
    
    