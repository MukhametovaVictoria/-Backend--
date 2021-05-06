CREATE TABLE Products (
	id INT PRIMARY KEY Identity(1,1),
	name VARCHAR(255) NOT NULL
);

INSERT INTO Products
VALUES  ('Пальто'),
	('Рубашка'),
	('Кроссовки'),
    ('Туфли'),
    ('Штаны'),
    ('Браслет');