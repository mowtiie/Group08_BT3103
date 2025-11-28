CREATE PROCEDURE sp_EditProduct
    @ProductID INT,
    @ProductName VARCHAR(50),
    @Category VARCHAR(50),
    @Supplier VARCHAR(50) = NULL,
    @Status VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CategoryID INT;
    DECLARE @SupplierID INT = NULL;

    DECLARE @ErrorMessage NVARCHAR(MAX);
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorState INT;

    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM Products WHERE ProductID = @ProductID)
        BEGIN
            RAISERROR('Product with the specified ID does not exist.', 16, 1);
            RETURN;
        END

        IF EXISTS (
            SELECT 1 
            FROM Products 
            WHERE ProductName = @ProductName 
            AND ProductID <> @ProductID
        )
        BEGIN
            RAISERROR('A product with this name already exists. Please choose a different name.', 16, 1);
            RETURN;
        END

        SELECT @CategoryID = CategoryID FROM Categories WHERE CategoryName = @Category
        IF @CategoryID IS NULL
        BEGIN
            RAISERROR('Invalid Category Name provided. Product edit failed.', 16, 1);
            RETURN;
        END

        IF @Supplier IS NOT NULL AND LTRIM(@Supplier) <> '' AND @Supplier <> 'No Assigned Supplier'
        BEGIN
            SELECT @SupplierID = SupplierID FROM Suppliers WHERE SupplierName = @Supplier;

            IF @SupplierID IS NULL
            BEGIN
                RAISERROR('Invalid Supplier Name provided. Product edit failed.', 16, 1);
                RETURN;
            END
        END

        UPDATE Products
        SET 
            ProductName = @ProductName,
            CategoryID = @CategoryID,
            SupplierID = @SupplierID,
            Status = @Status
        WHERE 
            ProductID = @ProductID;
            
        SELECT @ProductID AS ProductID; 

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