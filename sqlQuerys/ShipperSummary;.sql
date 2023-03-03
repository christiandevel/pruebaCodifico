USE StoreSample;

SELECT 
  s.CompanyName, 
  SUM(od.UnitPrice * od.qty) AS TotalFreight, 
  SUM(od.UnitPrice * od.qty * (1 - od.Discount)) AS TotalCostShipped, 
  SUM(od.qty) AS TotalItemsShipped
FROM 
  Sales.Shippers s
  INNER JOIN Sales.Orders o ON s.ShipperID = o.ShipperID
  INNER JOIN Sales.OrderDetails od ON o.OrderID = od.OrderID
GROUP BY 
  s.CompanyName
ORDER BY 
  TotalFreight DESC;