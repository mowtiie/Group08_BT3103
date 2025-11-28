CREATE PROCEDURE sp_AddProductVariant
    @ProductID INT,
    @SKU VARCHAR(100),
    @Size VARCHAR(20),
    @Color VARCHAR(50),
    @CostPrice DECIMAL(10, 2),
    @SellingPrice DECIMAL(10, 2),
    @InitialStock INT,
    @ReorderLevel INT,
    @Status VARCHAR(20) = 'Active',
    @ProcessedByUserID INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @NewVariantID INT;
    DECLARE @ErrorMessage NVARCHAR(MAX);
    DECLARE @ErrorSeverity INT;
    DECLARE @ErrorState INT;

    BEGIN TRANSACTION;

    BEGIN TRY
        
        IF NOT EXISTS (SELECT 1 FROM Products WHERE ProductID = @ProductID)
        BEGIN
            RAISERROR('The parent ProductID does not exist.', 16, 1);
        END

        IF EXISTS (SELECT 1 FROM ProductVariants WHERE SKU = @SKU)
        BEGIN
            RAISERROR('The provided SKU is already in use by another variant.', 16, 1);
        END

        IF @SellingPrice < @CostPrice
        BEGIN
            RAISERROR('Selling Price cannot be less than Cost Price . Selling at a loss is not permitted.', 16, 1);
        END
        
        INSERT INTO ProductVariants (ProductID, SKU, Size, Color, CostPrice, SellingPrice, StockQuantity, ReorderLevel, Status)
        VALUES (@ProductID, @SKU, @Size, @Color, @CostPrice, @SellingPrice, @InitialStock, @ReorderLevel, @Status);

        SET @NewVariantID = SCOPE_IDENTITY();


        IF @InitialStock > 0
        BEGIN
            INSERT INTO Inventory (VariantID, QuantityChange, Reason, ProcessedByUserID, Notes)
            VALUES (
                @NewVariantID,
                @InitialStock,
                'Initial Receipt',
                @ProcessedByUserID,
                'Initial stock during product variant creation.'
            );
        END

        COMMIT TRANSACTION;

        SELECT @NewVariantID AS NewVariantID;

    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(), 
            @ErrorSeverity = ERROR_SEVERITY(), 
            @ErrorState = ERROR_STATE();
            
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
        
    END CATCH
END
GO
