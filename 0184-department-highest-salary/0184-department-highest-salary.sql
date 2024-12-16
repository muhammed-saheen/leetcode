SELECT 
    Department.name AS Department,
    Employee.name AS Employee,
    MAX(Employee.salary) AS Salary
FROM 
    Employee
JOIN 
    Department ON Employee.departmentId = Department.id
WHERE 
    Employee.salary = (
        SELECT MAX(salary)
        FROM Employee
        WHERE departmentId = Department.id
    )
GROUP BY 
    Department.name, Employee.name;
