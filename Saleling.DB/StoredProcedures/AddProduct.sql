CREATE PROCEDURE AddProduct
    @ProductName VARCHAR(50),
    @ProductCategory VARCHAR(50),
    @ProductSupplier VARCHAR(50) = NULL,
    @ProductUnitPrice DECIMAL(10, 2),
    @ProductDescription NVARCHAR(MAX) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CategoryID INT;
    DECLARE @SupplierID INT = NULL;

    IF EXISTS (SELECT 1 FROM Products WHERE ProductName = @ProductName)
    BEGIN
        RAISERROR('A product with the name "%s" already exists.', 16, 1, @ProductName);
		RETURN;
    END
    
    SELECT @CategoryID = CategoryID
    FROM Categories
    WHERE CategoryName = @ProductCategory;

    IF @CategoryID IS NULL
    BEGIN
        RAISERROR('Invalid Category Name provided. Product creation failed.', 16, 1);
        RETURN;
    END

    IF @ProductSupplier IS NOT NULL AND LTRIM(@ProductSupplier) <> '' AND @ProductSupplier <> 'No supplier (N/A)'
    BEGIN
        SELECT @SupplierID = SupplierID
        FROM Suppliers
        WHERE SupplierName = @ProductSupplier;

        IF @SupplierID IS NULL
        BEGIN
            RAISERROR('Invalid Supplier Name provided. Product creation failed.', 16, 1);
            RETURN;
        END
    END

    INSERT INTO Products (
        ProductName,
        CategoryID,
        SupplierID,
        UnitPrice,
        Description
    )
    OUTPUT INSERTED.ProductID
    VALUES (
        @ProductName,
        @CategoryID,
        @SupplierID,
        @ProductUnitPrice,
        @ProductDescription
    );

END
GO