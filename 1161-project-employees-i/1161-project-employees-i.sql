SELECT 
    Project.project_id,
    ROUND(AVG(CAST(Employee.experience_years AS DECIMAL(10, 2))), 2) AS average_years
FROM 
    Project
JOIN 
    Employee 
ON 
    Project.employee_id = Employee.employee_id
GROUP BY 
    Project.project_id;
