USE StoreSample;

SELECT 
    c.CompanyName AS 'Customer Name', 
    MAX(o.OrderDate) AS 'Last Order Date',
    DATEADD(DAY, AVG(DATEDIFF(DAY, o.OrderDate, o2.OrderDate)), MAX(o.OrderDate)) AS 'Next Predicted Order'
FROM 
    Sales.Customers c
    INNER JOIN Sales.Orders o ON c.custid = o.custid
    LEFT JOIN Sales.Orders o2 ON o.custid = o2.custid AND o.OrderID <> o2.OrderID AND o2.OrderDate > o.OrderDate
GROUP BY 
    c.companyname