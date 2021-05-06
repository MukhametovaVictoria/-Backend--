SELECT ord.id AS Order_id, prod.name AS Product_name, ordprod.Quantity
FROM     dbo.Products AS prod INNER JOIN
                  dbo.OrdersProducts AS ordprod ON prod.id = ordprod.Products_id LEFT OUTER JOIN
                  dbo.Orders AS ord ON ordprod.Orders_id = ord.id