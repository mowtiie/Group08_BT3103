CREATE PROCEDURE sp_AddProduct
    @ProductName VARCHAR(100),
    @Category VARCHAR(50),
    @Supplier VARCHAR(50) = NULL,
    @Status VARCHAR(20) = 'Active'
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CategoryID INT;
    DECLARE @SupplierID INT = NULL;

    DECLARE @ErrorMessage NVARCHAR(MAX);
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorState INT;

    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Products WHERE ProductName = @ProductName)
        BEGIN
            RAISERROR('A product with this name already exists.', 16, 1);
            RETURN;
        END

        SELECT @CategoryID = CategoryID FROM Categories WHERE CategoryName = @Category
        IF @CategoryID IS NULL
        BEGIN
            RAISERROR('Invalid Category Name provided. Product creation failed.', 16, 1);
            RETURN;
        END

        IF @Supplier IS NOT NULL AND LTRIM(@Supplier) <> '' AND @Supplier <> 'No Assigned Supplier'
        BEGIN
            SELECT @SupplierID = SupplierID FROM Suppliers WHERE SupplierName = @Supplier;

            IF @SupplierID IS NULL
            BEGIN
                RAISERROR('Invalid Supplier Name provided. Product creation failed.', 16, 1);
                RETURN;
            END
        END

        INSERT INTO Products (ProductName, CategoryID, SupplierID, Status)
        VALUES (@ProductName, @CategoryID, @SupplierID, @Status);
    END TRY
    BEGIN CATCH
        SELECT 
            @ErrorMessage = ERROR_MESSAGE(), 
            @ErrorSeverity = ERROR_SEVERITY(), 
            @ErrorState = ERROR_STATE();
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
        RETURN;
    END CATCH
END
GO