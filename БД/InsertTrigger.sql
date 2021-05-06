CREATE TRIGGER [dbo].[InsertTrigger]
   ON  [dbo].[Orders]
   AFTER INSERT
AS 
Declare @id int;
begin
	Set @id = (Select MAX(id) from Orders);
	Insert Into OrdersProducts (Orders_id, Products_id, Quantity)
	Values (@id, 0, 0);
END