-- Connecting a database
USE [D:\IDE\VS2017\Projects\Consimple\Emulator\Emulator\App_Data\PurchaseDB.mdf]
GO

-- Create table Product
CREATE TABLE Products
(
	Id int IDENTITY NOT NULL,
	ProductId nvarchar(10) NOT NULL PRIMARY KEY,
	Name nvarchar(50) NOT NULL
)
GO

-- Create table Orders
CREATE TABLE Orders
(
	Id int IDENTITY NOT NULL PRIMARY KEY,
	ProductId nvarchar(10) NOT NULL FOREIGN KEY REFERENCES Products(ProductId),
	Price SmallMoney NOT NULL,
	Quantity int NOT NULL,
	Status nvarchar(10)
)
GO

-- Create table Info
CREATE TABLE Info
(
	Id int IDENTITY NOT NULL,
	OrderId int NOT NULL FOREIGN KEY REFERENCES Orders(Id),
	[Sum] SmallMoney NOT NULL,
	OrderDate Date NOT NULL
)
Go

-- Filling the table Products
INSERT INTO Products
(ProductId, Name)
VALUES
('drink01', N'Сок Садочок 1л'),
('drink02', N'Мин.вода Боржоми 0,5л'),
('drink03', N'Лимонлад Росинка 2л'),
('drink04', N'Ликер Malibu 0,5л'),
('fruit01', N'Хурма'),
('fruit02', N'Груша Вильямс'),
('fruit03', N'Яблоко Украина'),
('fruit04', N'Ананас Беби'),
('meat01', N'Баранина задняя часть'),
('meat02', N'Стейк свинной из грудинки'),
('meat03', N'Корейка свиная на ребре'),
('meat04', N'Свиная голень');
GO

SELECT * FROM Products
SELECT * FROM Orders
SELECT * FROM Info

/*
-- Deleting data from a table
DELETE Orders

-- Deleting data from a table with zeroing of the counter
DELETE FROM Orders
DBCC CHECKIDENT('Orders', RESEED, 0)

-- Delete a row
ALTER TABLE Orders DROP COLUMN Total;
ALTER TABLE Orders DROP COLUMN Date;

-- Creating a new row
ALTER TABLE Orders ADD Total int;
ALTER TABLE Orders ADD Date Date;

-- Delete a table
DROP TABLE Info
DROP TABLE Orders
DROP TABLE Products
*/