CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName VARCHAR(50) NOT NULL,
    CategoryID INT NOT NULL,
    SupplierID INT,
    Status VARCHAR(20) NOT NULL CHECK (Status IN ('Active', 'Archived')) DEFAULT 'Active',

    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID),
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID)
);