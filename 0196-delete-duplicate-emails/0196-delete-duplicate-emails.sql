/* Write your T-SQL query statement below */
DELETE P1 FROM PERSON as P1, PERSON as P2
WHERE P1.Email = p2.Email AND P1.Id>P2.Id