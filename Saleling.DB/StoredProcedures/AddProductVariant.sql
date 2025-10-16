CREATE PROCEDURE AddProductVariant
    @ProductID INT,
    @SKU VARCHAR(20),
    @Size VARCHAR(20),
    @Color VARCHAR(20),
    @UnitsInStock INT,
    @ReorderLevel INT
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @NewVariantID INT;

    IF EXISTS (SELECT 1 FROM ProductVariants WHERE SKU = @SKU)
    BEGIN
        RAISERROR('A variant with the SKU "%s" already exists.', 16, 1, @SKU);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM Products WHERE ProductID = @ProductID)
    BEGIN
        RAISERROR('Invalid ProductID provided. Variant creation failed.', 16, 1);
        RETURN;
    END

    INSERT INTO ProductVariants (
        ProductID,
        SKU,
        Size,
        Color,
        UnitsInStock,
        ReorderLevel
    )
    OUTPUT INSERTED.VariantID
    VALUES (
        @ProductID,
        @SKU,
        @Size,
        @Color,
        @UnitsInStock,
        @ReorderLevel
    );
    
    SET @NewVariantID = SCOPE_IDENTITY(); 

    IF @UnitsInStock > 0
    BEGIN
        INSERT INTO Inventory (
            VariantID,
            QuantityChange,
            ChangeDate,
            Type
        )
        VALUES (
            @NewVariantID,
            @UnitsInStock,
            GETDATE(),
            'add'
        );
    END
    
    RETURN @NewVariantID;
END
GO
