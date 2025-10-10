CREATE TABLE [dbo].[ProductVariants]
(
	[VariantID] INT PRIMARY KEY IDENTITY(1,1),
    [ProductID] INT NOT NULL,
    [SKU] VARCHAR(50) UNIQUE NOT NULL,
    [Size] VARCHAR(10) NOT NULL,
    [Color] VARCHAR(20) NOT NULL,
    [UnitsInStock] INT DEFAULT 0,
    [ReorderLevel] INT DEFAULT 0,
    
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
)
