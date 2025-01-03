SELECT ROUND(SUM(tiv_2016), 2) AS tiv_2016
FROM Insurance i1
WHERE tiv_2015 IN (
    SELECT tiv_2015
    FROM Insurance
    GROUP BY tiv_2015
    HAVING COUNT(*) > 1
)
AND (lat) IN (
    SELECT lat
    FROM Insurance
    GROUP BY lat, lon
    HAVING COUNT(*) = 1
);
