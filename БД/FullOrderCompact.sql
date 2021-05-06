SELECT Order_id, string_agg(Product_name + ' [' + CAST(Quantity AS nvarchar) + 'רע.]', ', ') AS Product_list
FROM     dbo.FullOrder
GROUP BY Order_id