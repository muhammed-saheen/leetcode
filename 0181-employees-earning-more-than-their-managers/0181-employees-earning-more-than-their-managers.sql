SELECT e1.name AS Employee
FROM Employee AS e1
LEFT JOIN Employee AS e2
ON e1.ManagerId = e2.id where e1.salary>e2.salary ;
