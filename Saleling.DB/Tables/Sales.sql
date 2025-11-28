CREATE TABLE Sales (
    SaleID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
    SaleDate DATETIME2 NOT NULL DEFAULT GETDATE(),
    ProcessedByUserID INT NOT NULL,
    TotalAmount DECIMAL(10, 2) NOT NULL,

    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (ProcessedByUserID) REFERENCES Users(UserID)
);