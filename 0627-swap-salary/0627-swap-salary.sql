UPDATE Salary
SET Sex = CASE
    WHEN Sex = 'f' THEN 'm'
    WHEN Sex = 'm' THEN 'f'
END;
