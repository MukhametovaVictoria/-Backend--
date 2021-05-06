SELECT fo.Order_id AS id, fo.Product_list, oc.Customer_name, oc.Date
FROM     dbo.FullOrderCompact AS fo INNER JOIN
                  dbo.OrderCustomers AS oc ON fo.Order_id = oc.id