CREATE TABLE [dbo].[ProductVariants]
(
    VariantID INT PRIMARY KEY IDENTITY(1,1),
    ProductID INT NOT NULL,
    Size NVARCHAR(50),
    Color NVARCHAR(50),
    UnitsInStock INT,
);
