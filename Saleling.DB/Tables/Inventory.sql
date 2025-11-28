CREATE TABLE Inventory (
    InventoryID INT PRIMARY KEY IDENTITY(1,1),
    VariantID INT NOT NULL,
    QuantityChange INT NOT NULL,
    ChangeDate DATETIME2 NOT NULL DEFAULT GETDATE(),
    Reason VARCHAR(50) NOT NULL CHECK (Reason IN (
        'Sale',
        'Initial Receipt',
        'Found Stock',
        'Physical Reconciliation',
        'Damaged/Scrap',
        'Shrinkage/Loss',
        'Physical Discrepancy',
        'System Error Correction'
    )),
    ProcessedByUserID INT NOT NULL,
    TransactionReferenceID INT NULL,
    Notes NVARCHAR(MAX),

    FOREIGN KEY (VariantID) REFERENCES ProductVariants(VariantID),
    FOREIGN KEY (ProcessedByUserID) REFERENCES Users(UserID)
);