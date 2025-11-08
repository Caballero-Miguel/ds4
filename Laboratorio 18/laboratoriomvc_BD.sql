CREATE DATABASE laboratoriomvc
go

Use laboratoriomvc
go

CREATE TABLE [User] 
(
	id INT PRIMARY KEY IDENTITY(1, 1),
	email VARCHAR(50) NULL,
	[password] VARCHAR(100) NULL
);