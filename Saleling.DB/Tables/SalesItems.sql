CREATE TABLE SalesItems (
    SaleItemID INT PRIMARY KEY IDENTITY(1,1),
    SaleID INT NOT NULL,
    VariantID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10, 2) NOT NULL,
    Discount DECIMAL(10, 2) DEFAULT 0.00,
    SubTotal DECIMAL(10, 2) NOT NULL,

    FOREIGN KEY (SaleID) REFERENCES Sales(SaleID),
    FOREIGN KEY (VariantID) REFERENCES ProductVariants(VariantID)
);