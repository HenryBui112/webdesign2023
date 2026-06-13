# Input number of employees
n = int(input("Enter the number of employees: "))

employees = []

# Input employee details
for i in range(n):
    print(f"\nEnter details for employee {i + 1}:")
    emp_id = input("Employee ID: ")
    name = input("Full name: ")
    salary = float(input("Salary: "))

    employee = {
        "id": emp_id,
        "name": name,
        "salary": salary
    }

    employees.append(employee)

# Display all employees
print("\n====List of Employees====")
for emp in employees:
    print(emp)

# Find employee with the highest salary
highest = max(employees, key=lambda x: x['salary'])
print("\n====Employee with the Highest Salary====")
print(highest)

# Calculate average salary
avg_salary = sum(emp['salary'] for emp in employees) / n    
print("\nAverage Salary:", avg_salary)

# Employees with salary above average
print("\n====Employees with Salary > 1000====")
for emp in employees:
    if emp['salary'] > 1000:
        print(emp)