CREATE TABLE OrdersProducts (

id int NOT NULL PRIMARY KEY identity(1,1),

Orders_id int NOT NULL,

Products_id int,

Quantity int

);

INSERT INTO OrdersProducts
VALUES  (1, 2, 5),
		(1, 3, 2),
		(2, 1, 1),
		(2, 3, 2),
		(3, 2, 1),
		(3, 4, 1),
		(4, 5, 1);