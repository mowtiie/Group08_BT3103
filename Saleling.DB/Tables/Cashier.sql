CREATE TABLE [dbo].[Cashier]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [Username] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL
)
