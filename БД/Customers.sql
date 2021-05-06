CREATE TABLE Customers (
	id INT PRIMARY KEY IDENTITY(1,1),
	name VARCHAR(255) NOT NULL
);

INSERT INTO Customers
VALUES  ('Синичкин Василий Петрович'),
	('Мухаметова Виктория Валерьевна'),
	('Иванов Иван Иванович'),
	('Петров Петр Петрович');