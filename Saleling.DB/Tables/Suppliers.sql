CREATE TABLE [dbo].[Suppliers]
(
	[SupplierID] INT PRIMARY KEY IDENTITY(1,1),
    [SupplierName] VARCHAR(50) NOT NULL,
    [ContactName] VARCHAR(50),
    [Address] VARCHAR(100),
    [Phone] VARCHAR(15)
)
