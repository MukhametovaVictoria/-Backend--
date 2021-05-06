CREATE TABLE Orders (

id int NOT NULL Primary key Identity(1,1),

Customer_id int NOT NULL,

Date datetime NOT NULL

);

INSERT INTO Orders
VALUES  (1, '02.05.2021'),
		(3, '03.05.2021'),
		(2, '04.05.2021'),
		(2, '05.05.2021');