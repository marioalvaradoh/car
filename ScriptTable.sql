CREATE DATABASE Practice

CREATE TABLE Car
(
	Id INT PRIMARY KEY IDENTITY
	,Make NVARCHAR(50) NOT NULL
	,Year NVARCHAR(50) NULL
	,Sales INT NOT NULL DEFAULT 0
)


