CREATE TABLE [dbo].[Suppliers]
(
	SupplierID INT PRIMARY KEY IDENTITY(1,1),
    SupplierName NVARCHAR(150) NOT NULL,
    ContactName NVARCHAR(100),
    Address NVARCHAR(255),
    Phone NVARCHAR(50)
);

