CREATE TYPE udt_SaleItemType AS TABLE (
    VariantID INT NOT NULL,
    Quantity INT NOT NULL,
    UnitPrice DECIMAL(10, 2) NOT NULL,
    Discount DECIMAL(10, 2) DEFAULT 0.00,
    SubTotal DECIMAL(10, 2) NOT NULL
);
GO
