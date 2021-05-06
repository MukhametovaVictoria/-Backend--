SELECT ord.id, cust.id AS Customer_id, cust.name AS Customer_name, ord.Date
FROM     dbo.Customers AS cust INNER JOIN
                  dbo.Orders AS ord ON cust.id = ord.Customer_id