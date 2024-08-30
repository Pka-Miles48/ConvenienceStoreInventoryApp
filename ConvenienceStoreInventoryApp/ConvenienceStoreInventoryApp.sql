use master

CREATE DATABASE ConvenienceStoreDB;
GO

USE ConvenienceStoreDB;
GO

CREATE TABLE Products (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Category NVARCHAR(100),
    Price DECIMAL(18, 2),
    Stock INT
);
