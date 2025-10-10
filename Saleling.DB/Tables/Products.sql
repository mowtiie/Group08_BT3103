CREATE TABLE [dbo].[Products]
(
	[ProductID] INT PRIMARY KEY IDENTITY(1,1),
    [ProductName] VARCHAR(50) NOT NULL,
    [CategoryID] INT NOT NULL,
    [SupplierID] INT,
    [UnitPrice] DECIMAL(10, 2) NOT NULL,
    [Description] NVARCHAR(MAX),
    
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID),
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID)
)
